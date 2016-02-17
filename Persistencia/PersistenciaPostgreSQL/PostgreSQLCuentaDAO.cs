using DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Persistencia.PersistenciaPostgreSQL
{
    /// <summary>
    /// Clase PostgreSQLCuentaDAO. Implementa los métodos de la interfaz iCuentaDAO
    /// para tratar toda la información de los objetos CuentaDTO.
    /// </summary>
    public class PostgreSQLCuentaDAO : ICuentaDAO
    {
        private NpgsqlConnection iConexion;
        private NpgsqlTransaction iTransaccion = null;

        /// <summary>
        /// Constructor PostgreSQLCuentaDAO.
        /// Construye la conexión para la base de datos y setea la transacción.
        /// </summary>
        /// <param name="pConexion">Conexión que se realizará a la base de datos</param>
        /// <param name="pTransaccion">Transacción que se realizará a la base de datos</param>
        public PostgreSQLCuentaDAO(NpgsqlConnection pConexion, NpgsqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }


        /// <summary>
        /// Permite insertar una nueva Cuenta de correo en la base de datos
        /// </summary>
        /// <param name="pCuenta">Cuenta que vamos a insertar en la base de datos</param>
        public void Insertar(CuentaDTO pCuenta)
        {
            try
            {
                // Obtengo el máximo idCuenta que se encuentra en la base de datos
                // que corresponde la última cuenta que inserté
                // En el caso de que la tabla cuenta esté vacía, entonces
                // inicializamos idCuenta en 1.
                NpgsqlCommand cmd = new NpgsqlCommand("select max(idcuenta) from cuenta", this.iConexion, this.iTransaccion);
                NpgsqlCommand command = new NpgsqlCommand("select count(*) from cuenta", this.iConexion, this.iTransaccion);
                int iCantidadRegistros = Convert.ToInt32(command.ExecuteScalar());
                int idCuenta;
                if (iCantidadRegistros == 0)
                {
                    idCuenta = 1;
                }
                else
                {
                    idCuenta = Convert.ToInt32(cmd.ExecuteScalar());
                    idCuenta++;
                }
                NpgsqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"insert into Cuenta(idcuenta,nombre,direccion,servicio,contrasenia,activo) values(@idCuenta,@nombre,@direccion,@servicio,@contrasenia,@activo)";
                comando.Parameters.AddWithValue("@idcuenta", idCuenta);
                comando.Parameters.AddWithValue("@nombre", pCuenta.Nombre);
                comando.Parameters.AddWithValue("@direccion", pCuenta.Direccion);
                comando.Parameters.AddWithValue("@servicio", pCuenta.Servicio);
                comando.Parameters.AddWithValue("@contrasenia", pCuenta.Contraseña);
                comando.Parameters.AddWithValue("@activo", pCuenta.Activo);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {

                throw new DAOException("No se pudo insertar la cuenta correctamente en la base de datos");
            }
        }

        /// <summary>
        /// Permite modificar los datos de una cuenta de correo en la base de datos
        /// </summary>
        /// <param name="pCuenta">Cuenta que vamos a modificar</param>
        public void Modificar(int pIDCuenta, CuentaDTO pCuenta)
        {
            NpgsqlCommand comando = new NpgsqlCommand("UPDATE cuenta SET nombre=@nombre, direccion= @direccion, servicio=@servicio, contrasenia=@contrasenia, activo=@activo WHERE idCuenta=@idCuenta", this.iConexion, this.iTransaccion);
            comando.Parameters.AddWithValue("@idCuenta", pIDCuenta);
            comando.Parameters.AddWithValue("@nombre", pCuenta.Nombre);
            comando.Parameters.AddWithValue("@servicio", pCuenta.Servicio);
            comando.Parameters.AddWithValue("@direccion", pCuenta.Direccion);
            comando.Parameters.AddWithValue("@contrasenia", pCuenta.Contraseña);
            comando.Parameters.AddWithValue("@activo", pCuenta.Activo);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo modificar los datos de la cuenta");
            }
        }

        /// <summary>
        /// Obtiene todas las cuenta de correo electrónico de la base de datos que estén activas.
        /// </summary>
        /// <returns>Lista de las cuentas obtenidas que están activas</returns>
        public List<CuentaDTO> Obtener()
        {
            List<CuentaDTO> iCuentas = new List<CuentaDTO>();
            try
            {
                NpgsqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "SELECT * FROM cuenta WHERE activo = 'true';";
                DataTable iTabla = new DataTable();
                using (NpgsqlDataAdapter iAdaptador = new NpgsqlDataAdapter(comando))
                {
                    iAdaptador.Fill(iTabla);
                    foreach (DataRow fila in iTabla.Rows)
                    {
                        iCuentas.Add(new CuentaDTO(
                            Convert.ToInt32(fila["idcuenta"]),
                            Convert.ToString(fila["nombre"]),
                            Convert.ToString(fila["direccion"]),
                            Convert.ToString(fila["servicio"]),
                            Convert.ToString(fila["contrasenia"]),
                            Convert.ToBoolean(fila["activo"])
                            )
                        );
                    }
                }
                return iCuentas;
            }
            catch (NpgsqlException)
            {
                throw new DAOException("Error en la obtención de datos de cuentas. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de la aplicación.");
            }
        }

        /// <summary>
        /// Obtiene todas las cuentas de la base de datos.
        /// </summary>
        /// <returns>Lista de las cuentas obtenidas</returns>
        public List<CuentaDTO> ObtenerTodasLasCuentas()
        {
            List<CuentaDTO> iCuentas = new List<CuentaDTO>();
            try
            {
                NpgsqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "SELECT * FROM cuenta;";
                DataTable iTabla = new DataTable();
                using (NpgsqlDataAdapter iAdaptador = new NpgsqlDataAdapter(comando))
                {
                    iAdaptador.Fill(iTabla);
                    foreach (DataRow fila in iTabla.Rows)
                    {
                        iCuentas.Add(new CuentaDTO(
                            Convert.ToInt32(fila["idcuenta"]),
                            Convert.ToString(fila["nombre"]),
                            Convert.ToString(fila["direccion"]),
                            Convert.ToString(fila["servicio"]),
                            Convert.ToString(fila["contrasenia"]),
                            Convert.ToBoolean(fila["activo"])
                            )
                        );
                    }
                }
                return iCuentas;
            }
            catch (NpgsqlException)
            {
                throw new DAOException("Error en la obtención de datos de cuentas. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de la aplicación.");
            }
        }

        /// <summary>
        /// Obtiene una cuenta de correo electrónico identificada por su nombre.
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de cuenta a buscar</param>
        /// <returns>Cuenta encontrada</returns>
        public CuentaDTO BuscarCuenta(string pNombreCuenta)
        {
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM cuenta WHERE nombre ILIKE '" + pNombreCuenta + "%' and activo = 'true';", this.iConexion, this.iTransaccion);
            try
            {
                CuentaDTO cuenta = null;
                DataTable tabla = new DataTable();
                NpgsqlDataAdapter operacion = new NpgsqlDataAdapter(comando);
                operacion.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    cuenta = new CuentaDTO(Convert.ToInt32(fila["idcuenta"]), Convert.ToString(fila["nombre"]), Convert.ToString(fila["direccion"]), Convert.ToString(fila["servicio"]), Convert.ToString(fila["contrasenia"]), Convert.ToBoolean(fila["activo"]));
                }
                return cuenta;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo obtener los datos de la cuenta");
            }
        }

        /// <summary>
        /// Método BuscarTodasLasCuentas.
        /// Permite obtener todas las cuentas alojadas en la base de datos que coincida con el nombre que estamos buscando.
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de la cuenta que deseamos buscar</param>
        /// <returns>Lista de cuentas que coinciden con el nombre buscado</returns>
        public List<CuentaDTO> BuscarTodasLasCuentas(string pNombreCuenta)
        {
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM cuenta WHERE nombre ILIKE '" + pNombreCuenta + "%';", this.iConexion, this.iTransaccion);
            try
            {
                List<CuentaDTO> iListaCuentas = new List<CuentaDTO>();
                DataTable tabla = new DataTable();
                NpgsqlDataAdapter operacion = new NpgsqlDataAdapter(comando);
                operacion.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    iListaCuentas.Add(new CuentaDTO(Convert.ToInt32(fila["idcuenta"]), Convert.ToString(fila["nombre"]), Convert.ToString(fila["direccion"]), Convert.ToString(fila["servicio"]), Convert.ToString(fila["contrasenia"]), Convert.ToBoolean(fila["activo"])));
                }
                return iListaCuentas;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo obtener los datos de la cuenta");
            }
        }

        /// <summary>
        /// Método BuscarCuentas.
        /// Obtiene todas las cuentas que en alguna parte de su nomrbe poseen el nombre que estamos buscando.
        /// </summary>
        /// <param name="pNombreCuenta">Parte del nombre de la cuenta que buscamos</param>
        /// <returns>Lista de las cuentas que poseen en alguna parte de su nombre el nombre que buscamos</returns>
        public List<CuentaDTO> BuscarCuentas(string pNombreCuenta)
        {
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM cuenta WHERE nombre ILIKE '" + pNombreCuenta + "%' and activo = 'true';", this.iConexion, this.iTransaccion);
            try
            {
                CuentaDTO iCuenta = null;
                List<CuentaDTO> iListaCuentas = new List<CuentaDTO>();
                DataTable tabla = new DataTable();
                NpgsqlDataAdapter operacion = new NpgsqlDataAdapter(comando);
                operacion.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    iCuenta = new CuentaDTO(Convert.ToInt32(fila["idcuenta"]), Convert.ToString(fila["nombre"]), Convert.ToString(fila["direccion"]), Convert.ToString(fila["servicio"]), Convert.ToString(fila["contrasenia"]), Convert.ToBoolean(fila["activo"]));
                    iListaCuentas.Add(iCuenta);
                }
                return iListaCuentas;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo obtener los datos de la cuenta");
            }
        }

        /// <summary>
        /// Método BuscarPorEmail.
        /// Obtiene la cuenta que buscamos mediante su dirección de mail.
        /// </summary>
        /// <param name="pDireccion">Dirección de mail que estamos buscando</param>
        /// <returns>Cuenta encontrada</returns>
        public CuentaDTO BuscarPorEmail(string pDireccion)
        {
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM cuenta WHERE direccion ILIKE '" + pDireccion + "%' and activo = 'true';", this.iConexion, this.iTransaccion);
            try
            {
                CuentaDTO cuenta = null;
                DataTable tabla = new DataTable();
                NpgsqlDataAdapter operacion = new NpgsqlDataAdapter(comando);
                operacion.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    cuenta = new CuentaDTO(Convert.ToInt32(fila["idcuenta"]), Convert.ToString(fila["nombre"]), Convert.ToString(fila["direccion"]), Convert.ToString(fila["servicio"]), Convert.ToString(fila["contrasenia"]), Convert.ToBoolean(fila["activo"]));
                }
                return cuenta;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo obtener los datos de la cuenta");
            }
        }

        /// <summary>
        /// Método Eliminar.
        /// Permite marcar como inactiva una cuenta la cual no deseamos utilizar.
        /// </summary>
        /// <param name="pCuenta">Cuenta que necesitamos marcar como inactiva</param>
        public void Eliminar(string pCuenta)
        {
            //Este mensaje cambia el valor de activo a FALSE
            //de una cuenta cuyo nombre sea igual a pCuenta.Nombre
            NpgsqlCommand iCommand = new NpgsqlCommand("UPDATE cuenta SET activo= 'false' WHERE nombre='" + pCuenta + "';", this.iConexion, this.iTransaccion);
            try
            {
                iCommand.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo 'eliminar' la cuenta de la base de datos");
            }
        }


        /// <summary>
        /// Método Reactivar.
        /// Permite reactivar una cuenta que deseamos utilizar nuevamente.
        /// </summary>
        /// <param name="pCuenta">Cuenta que necesitamos reactivar</param>
        public void ReactivarCuenta(string pCuenta)
        {
            //Este mensaje cambia el valor de activo a FALSE
            //de una cuenta cuyo nombre sea igual a pCuenta.Nombre
            NpgsqlCommand iCommand = new NpgsqlCommand("UPDATE cuenta SET activo= 'true' WHERE nombre='" + pCuenta + "';", this.iConexion, this.iTransaccion);
            try
            {
                iCommand.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo reactivar la cuenta de la base de datos");
            }
        }

    }
}
