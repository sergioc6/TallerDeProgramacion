using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using Npgsql;
using DTO;

namespace Persistencia.PersistenciaPostgreSQL
{
    /// <summary>
    /// Clase PostgreSQLEmailDAO. Implementa los métodos de la interfaz IMailDAO
    /// para tratar toda la información de los objetos EmailDTO
    /// </summary>
    public class PostgreSQLEmailDAO : IMailDAO
    {
        private NpgsqlConnection iConexion;
        private NpgsqlTransaction iTransaccion = null;

        /// <summary>
        /// Constructor de la clase PostgreSQLEmailDAO. Toma como parámetros la conexión
        /// y la transacción.
        /// </summary>
        /// <param name="pConexion">Conexión para la base de datos</param>
        /// <param name="pTransaccion">Parámetro para iniciar la transacción a la base de datos</param>
        public PostgreSQLEmailDAO(NpgsqlConnection pConexion, NpgsqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        /// <summary>
        /// Método Insertar(). El método permite insertar un mail en la base de datos.
        /// </summary>
        /// <param name="pEmail">Objeto de tipo EmailDTO</param>
        public void Insertar(EmailDTO pEmail)
        {
            try
            {
                // Obtengo el máximo idMail que se encuentra en la base de datos
                // que corresponde al último Email que inserté
                // En el caso de que la tabla Email esté vacía, entonces
                // inicializamos idMail en 1.
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT MAX(idmail) from email", this.iConexion, this.iTransaccion);
                NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) from email", this.iConexion, this.iTransaccion);
                int iCantidadRegistros = Convert.ToInt32(command.ExecuteScalar());
                int idMail;
                if (iCantidadRegistros == 0)
                {
                    idMail = 1;
                }
                else
                {
                    idMail = Convert.ToInt32(cmd.ExecuteScalar());
                    idMail++;
                }


                // Inserto el email en la base de datos
                NpgsqlCommand comando = new NpgsqlCommand("INSERT INTO Email(idmail,fecha,remitente,cuerpo,cuenta,asunto,estado,activo,idmensaje,leido) values(@idmail,@fecha,@remitente,@cuerpo,@cuenta,@asunto,@estado,@activo,@idmensaje,@leido)", this.iConexion, this.iTransaccion);
                comando.Parameters.AddWithValue("@idmail", idMail);
                comando.Parameters.AddWithValue("@fecha", pEmail.Fecha);
                comando.Parameters.AddWithValue("@remitente", pEmail.Remitente);
                comando.Parameters.AddWithValue("@cuerpo", pEmail.Cuerpo);
                comando.Parameters.AddWithValue("@cuenta", pEmail.Cuenta);
                comando.Parameters.AddWithValue("@asunto", pEmail.Asunto);
                comando.Parameters.AddWithValue("@estado", pEmail.Estado);
                comando.Parameters.AddWithValue("@activo", pEmail.Activo);
                comando.Parameters.AddWithValue("@idmensaje", pEmail.IDMensaje);
                comando.Parameters.AddWithValue("@leido", pEmail.Leido);
                comando.ExecuteNonQuery();



                // Obtengo el máximo idDestinatario que se encuentra en la base de datos
                // que corresponde al último destinatario que inserté
                // En el caso de que la tabla Destinatarios esté vacía, entonces
                // inicializamos idDestinatarios en 1.

                // Por cada dirección en la lista de destinatarios, creo una tupla en la base de datos
                foreach (string fDestinatario in pEmail.Destinatario)
                {
                    NpgsqlCommand com = new NpgsqlCommand("INSERT INTO destinatarios(direccion,tipo,idmail) values(@direccion,@tipo,@idmail)", this.iConexion, this.iTransaccion);
                    com.Parameters.AddWithValue("@direccion", fDestinatario);
                    com.Parameters.AddWithValue("@tipo", "D");
                    com.Parameters.AddWithValue("@idmail", idMail);
                    com.ExecuteNonQuery();
                }
                if (pEmail.ConCopia != null)
                {
                    //por cada direccion en la lista de ConCopia, creo una tupla en la base de datos
                    foreach (String CC in pEmail.ConCopia)
                    {
                        NpgsqlCommand com = new NpgsqlCommand("insert into destinatarios(direccion,tipo,idmail) values(@direccion,@tipo,@idmail)", this.iConexion, this.iTransaccion);

                        com.Parameters.AddWithValue("@direccion", CC);
                        com.Parameters.AddWithValue("@tipo", "CC");
                        com.Parameters.AddWithValue("@idMail", idMail);
                        com.ExecuteNonQuery();
                    }
                }
                if (pEmail.ConCopiaOculta != null)
                {
                    //por cada direccion en la lista de ConCopiaOculta, creo una tupla en la base de datos
                    foreach (String CCO in pEmail.ConCopiaOculta)
                    {
                        NpgsqlCommand com = new NpgsqlCommand("insert into destinatarios(direccion,tipo,idmail) values(@direccion,@tipo,@idmail)", this.iConexion, this.iTransaccion);
                        com.Parameters.AddWithValue("@direccion", CCO);
                        com.Parameters.AddWithValue("@tipo", "CCO");
                        com.Parameters.AddWithValue("@idMail", idMail);
                        com.ExecuteNonQuery();
                    }
                }

            }
            catch (NpgsqlException)
            {
                throw new DAOException("No se pudo insertar el email en la base de datos");
            }
        }

        /// <summary>
        /// Método Eliminar(). Éste método marca como inactivo a un email
        /// que coincide con IdCorreo en la base de datos
        /// </summary>
        /// <param name="pIDMail">ID correspondiente a la cuenta que está loggeada en ese momento en el sistema</param>
        public void Eliminar(int pIDMail)
        {
            //Este mensaje cambia el valor de activo a FALSE
            //de un correo cuyo id sea igual a pIdCorreo
            NpgsqlCommand iCommand = new NpgsqlCommand("UPDATE email SET activo= 'FALSE' WHERE idmail = @idmail;", this.iConexion, this.iTransaccion);
            iCommand.Parameters.AddWithValue("@idmail", pIDMail);
            try
            {
                iCommand.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo 'eliminar' el mail de la base de datos");
            }
        }

        /// <summary>
        /// Método MarcarLeido(). Éste método cambia los estados de los mails
        /// a leídos, no leídos, eliminados, etc.
        /// </summary>
        /// <param name="pIDMail">Número de correo para buscar en la base de datos</param>
        public void MarcarLeido(int pIDMail)
        {
            //Este mensaje cambia el valor del estado a LEIDO
            //de un correo cuyo id sea igual a pIdCorreo
            NpgsqlCommand iCommand = new NpgsqlCommand("UPDATE email SET leido= 'Leído' WHERE idmail = @idmail;", this.iConexion, this.iTransaccion);
            iCommand.Parameters.AddWithValue("@idmail", pIDMail);
            try
            {
                iCommand.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo marcar como leido el mail de la base de datos");
            }
        }

        /// <summary>
        /// Método Obtener(). Toma como parámetro un IdCuenta y busca las coincidencias
        /// en la base de datos. De encontrar el IdCuenta, Obtener() devuelve todos los mails
        /// correspondiente a ese IdCuenta
        /// </summary>
        /// <param name="pIdCuenta">Parámetro a buscar en la base de datos</param>
        /// <returns>Lista de emails</returns>
        public List<EmailDTO> Obtener(int pIdCuenta)
        {
            List<EmailDTO> iEmails = new List<EmailDTO>();

            try
            {
                NpgsqlCommand iComando = this.iConexion.CreateCommand();

                iComando.CommandText = "SELECT * FROM email WHERE cuenta=" + pIdCuenta.ToString() + ";";
                DataTable iTabla = new DataTable();
                NpgsqlDataAdapter iAdaptador = new NpgsqlDataAdapter(iComando);
                iAdaptador.Fill(iTabla);
                foreach (DataRow fila in iTabla.Rows)
                {
                    NpgsqlCommand iComandoDestinatario = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'D'", this.iConexion);
                    iComandoDestinatario.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    NpgsqlCommand iComandoCC = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'CC'", this.iConexion);
                    iComandoCC.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    NpgsqlCommand iComandoCCO = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'CCO'", this.iConexion);
                    iComandoCCO.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    // 3 listas para destinatario, CC y CCO
                    List<String> iListaDestinatarios = new List<String>();
                    List<String> iListaCC = new List<String>();
                    List<String> iListaCCO = new List<String>();
                    // 3 DataTable para llenar con los datos de la base de datos
                    DataTable dListaDestinatarios = new DataTable();
                    DataTable dListaCC = new DataTable();
                    DataTable dListaCCO = new DataTable();
                    // 3 adaptadores para llenar las tablas con los datos traídos de la base de datos
                    NpgsqlDataAdapter aDestinatarios = new NpgsqlDataAdapter(iComandoDestinatario);
                    NpgsqlDataAdapter aCC = new NpgsqlDataAdapter(iComandoCC);
                    NpgsqlDataAdapter aCCO = new NpgsqlDataAdapter(iComandoCCO);

                    // Llenamos las tablas
                    aDestinatarios.Fill(dListaDestinatarios);
                    aCC.Fill(dListaCC);
                    aCCO.Fill(dListaCCO);
                    foreach (DataRow otraFila in dListaDestinatarios.Rows)
                    {
                        iListaDestinatarios.Add(Convert.ToString(otraFila["direccion"]));
                    }
                    foreach (DataRow otraFila2 in dListaCC.Rows)
                    {
                        iListaCC.Add(Convert.ToString(otraFila2["direccion"]));
                    }
                    foreach (DataRow otraFila3 in dListaCCO.Rows)
                    {
                        iListaCCO.Add(Convert.ToString(otraFila3["direccion"]));
                    }
                    iEmails.Add(new EmailDTO(
                           Convert.ToInt32(fila["idmail"]),
                           Convert.ToInt32(fila["cuenta"]),
                           Convert.ToString(fila["estado"]),
                           Convert.ToString(fila["remitente"]),
                           iListaDestinatarios,
                           Convert.ToString(fila["asunto"]),
                           Convert.ToString(fila["cuerpo"]),
                           Convert.ToString(fila["fecha"]),
                           Convert.ToBoolean(fila["activo"]),
                           iListaCC,
                           iListaCCO,
                           Convert.ToString(fila["idmensaje"]),
                           Convert.ToString(fila["leido"])
                           )
                       );
                }
                return iEmails;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("Error en la obtención de datos de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.");
            }
        }

        /// <summary>
        /// Método ObtenerTodos.
        /// Obtiene todos los mails de todas las cuentas.
        /// </summary>
        /// <returns>Lista con todos los mails en base de datos</returns>
        public List<EmailDTO> ObtenerTodos()
        {
            List<EmailDTO> iEmails = new List<EmailDTO>();

            try
            {
                NpgsqlCommand iComando = this.iConexion.CreateCommand();

                iComando.CommandText = "SELECT * FROM email;";
                DataTable iTabla = new DataTable();
                NpgsqlDataAdapter iAdaptador = new NpgsqlDataAdapter(iComando);
                iAdaptador.Fill(iTabla);
                foreach (DataRow fila in iTabla.Rows)
                {
                    NpgsqlCommand iComandoDestinatario = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'D'", this.iConexion);
                    iComandoDestinatario.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    NpgsqlCommand iComandoCC = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'CC'", this.iConexion);
                    iComandoCC.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    NpgsqlCommand iComandoCCO = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'CCO'", this.iConexion);
                    iComandoCCO.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    // 3 listas para destinatario, CC y CCO
                    List<String> iListaDestinatarios = new List<String>();
                    List<String> iListaCC = new List<String>();
                    List<String> iListaCCO = new List<String>();
                    // 3 DataTable para llenar con los datos de la base de datos
                    DataTable dListaDestinatarios = new DataTable();
                    DataTable dListaCC = new DataTable();
                    DataTable dListaCCO = new DataTable();
                    // 3 adaptadores para llenar las tablas con los datos traídos de la base de datos
                    NpgsqlDataAdapter aDestinatarios = new NpgsqlDataAdapter(iComandoDestinatario);
                    NpgsqlDataAdapter aCC = new NpgsqlDataAdapter(iComandoCC);
                    NpgsqlDataAdapter aCCO = new NpgsqlDataAdapter(iComandoCCO);
                    // Llenamos las tablas
                    aDestinatarios.Fill(dListaDestinatarios);
                    aCC.Fill(dListaCC);
                    aCCO.Fill(dListaCCO);
                    foreach (DataRow otraFila in dListaDestinatarios.Rows)
                    {
                        iListaDestinatarios.Add(Convert.ToString(otraFila["direccion"]));
                    }
                    foreach (DataRow otraFila2 in dListaCC.Rows)
                    {
                        iListaCC.Add(Convert.ToString(otraFila2["direccion"]));
                    }
                    foreach (DataRow otraFila3 in dListaCCO.Rows)
                    {
                        iListaCCO.Add(Convert.ToString(otraFila3["direccion"]));
                    }
                    iEmails.Add(new EmailDTO(
                           Convert.ToInt32(fila["idmail"]),
                           Convert.ToInt32(fila["cuenta"]),
                           Convert.ToString(fila["estado"]),
                           Convert.ToString(fila["remitente"]),
                           iListaDestinatarios,
                           Convert.ToString(fila["asunto"]),
                           Convert.ToString(fila["cuerpo"]),
                           Convert.ToString(fila["fecha"]),
                           Convert.ToBoolean(fila["activo"]),
                           iListaCC,
                           iListaCCO,
                           Convert.ToString(fila["idmensaje"]),
                           Convert.ToString(fila["leido"])
                           )
                       );
                }
                return iEmails;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("Error en la obtención de datos de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.");
            }
        }

        /// <summary>
        /// Método ObtenerMail.
        /// Obtiene un único mail a partir de su ID
        /// </summary>
        /// <param name="pIDMail">ID del mail que necesitamos obtener</param>
        /// <returns>Email obtenido</returns>
        public EmailDTO ObtenerMail(int pIDMail)
        {
            EmailDTO EmailABuscar = null;
            try
            {
                NpgsqlCommand iComando = this.iConexion.CreateCommand();

                iComando.CommandText = "SELECT * FROM email WHERE idmail = @idmail;";
                iComando.Parameters.AddWithValue("@idmail", pIDMail);
                DataTable iTabla = new DataTable();
                NpgsqlDataAdapter iAdaptador = new NpgsqlDataAdapter(iComando);
                iAdaptador.Fill(iTabla);
                foreach (DataRow fila in iTabla.Rows)
                {
                    NpgsqlCommand iComandoDestinatario = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'D'", this.iConexion);
                    iComandoDestinatario.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    NpgsqlCommand iComandoCC = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'CC'", this.iConexion);
                    iComandoCC.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    NpgsqlCommand iComandoCCO = new NpgsqlCommand("SELECT * FROM destinatarios WHERE idmail = @idmail and tipo = 'CCO'", this.iConexion);
                    iComandoCCO.Parameters.AddWithValue("@idmail", Convert.ToInt32(fila["idmail"].ToString()));
                    // 3 listas para destinatario, CC y CCO
                    List<String> iListaDestinatarios = new List<String>();
                    List<String> iListaCC = new List<String>();
                    List<String> iListaCCO = new List<String>();
                    // 3 DataTable para llenar con los datos de la base de datos
                    DataTable dListaDestinatarios = new DataTable();
                    DataTable dListaCC = new DataTable();
                    DataTable dListaCCO = new DataTable();
                    // 3 adaptadores para llenar las tablas con los datos traídos de la base de datos
                    NpgsqlDataAdapter aDestinatarios = new NpgsqlDataAdapter(iComandoDestinatario);
                    NpgsqlDataAdapter aCC = new NpgsqlDataAdapter(iComandoCC);
                    NpgsqlDataAdapter aCCO = new NpgsqlDataAdapter(iComandoCCO);
                    // Llenamos las tablas
                    aDestinatarios.Fill(dListaDestinatarios);
                    aCC.Fill(dListaCC);
                    aCCO.Fill(dListaCCO);
                    foreach (DataRow otraFila in dListaDestinatarios.Rows)
                    {
                        iListaDestinatarios.Add(Convert.ToString(otraFila["direccion"]));
                    }
                    foreach (DataRow otraFila2 in dListaCC.Rows)
                    {
                        iListaCC.Add(Convert.ToString(otraFila2["direccion"]));
                    }
                    foreach (DataRow otraFila3 in dListaCCO.Rows)
                    {
                        iListaCCO.Add(Convert.ToString(otraFila3["direccion"]));
                    }
                    EmailABuscar = new EmailDTO(
                           Convert.ToInt32(fila["idmail"]),
                           Convert.ToInt32(fila["cuenta"]),
                           Convert.ToString(fila["estado"]),
                           Convert.ToString(fila["remitente"]),
                           iListaDestinatarios,
                           Convert.ToString(fila["asunto"]),
                           Convert.ToString(fila["cuerpo"]),
                           Convert.ToString(fila["fecha"]),
                           Convert.ToBoolean(fila["activo"]),
                           iListaCC,
                           iListaCCO,
                           Convert.ToString(fila["idmensaje"]),
                           Convert.ToString(fila["leido"])
                           );
                }
                return EmailABuscar;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("Error en la obtención de datos de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.");
            }
        }

        /// <summary>
        /// Método ExisteCorreo.
        /// Controla si los mails existen o no en la base de datos.
        /// </summary>
        /// <param name="pEmail">Email a verificar si existe o no en la base de datos</param>
        /// <returns>TRUE en caso de que ya exista, FALSE en caso contrario</returns>
        public bool ExisteCorreo(EmailDTO pEmail)
        {
            bool encontrado = false;
            try
            {
                NpgsqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"select * from email where idmensaje=@idmensaje and activo = 'true'";
                comando.Parameters.AddWithValue("@idmensaje", pEmail.IDMensaje);
                comando.Transaction = iTransaccion;
                DataTable tabla = new DataTable();
                using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla); 
                    if (tabla.Rows.Count > 0)
                    {
                        // En el caso de que la tabla tenga mas de un registro, el método devolverá true.
                        encontrado = true;
                    }
                }
                return encontrado;
            }
            catch (NpgsqlException Ex)
            {
                throw new Exception(Ex.Message);
                throw new DAOException("Se ha producido un error");
            }
        }




    }
}
