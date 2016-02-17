using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Persistencia.PersistenciaPostgreSQL
{
    /// <summary>
    /// Clase PostgreSQLDAOFactory.
    /// Clase que utiliza el patrón Factory para crear instancias de CuentaDTO o EmailDTO.
    /// Además maneja métodos para poder manipular conexiones a base de datos.
    /// </summary>
    public class PostgreSQLDAOFactory : DAOFactory
    {
        NpgsqlConnection iConexion;
        NpgsqlTransaction iTransaccion;
        private string cadenaConexion = "Server = localhost; User Id = postgres; Password=postgres; Database = Taller;";

        /// <summary>
        /// Método IniciarConexion.
        /// Permite iniciar una conexión a una base de datos.
        /// </summary>
        public override void IniciarConexion()
        {
           try
           {
                this.iConexion= new NpgsqlConnection(cadenaConexion);
                iConexion.Open();
           }
           catch (Exception)
           {
               throw new DAOException("No se pudo conectar a la base de datos correctamente");
           }
            
        }

        /// <summary>
        /// Método ComenzarTransaccion.
        /// Permite iniciar las transacciones que se van a producir en la base de datos.
        /// </summary>
        public override void ComenzarTransaccion()
        {
            if (this.iConexion == null)
            {
                throw new DAOException("No se puede iniciar una transacción sin una conexión abierta");
            }
            try
            {
                this.iTransaccion = this.iConexion.BeginTransaction();
            }
            catch (NpgsqlException)
            {
                throw new DAOException("Hubo un problema al iniciar la transacción en la Base de Datos");
            }
        }

        /// <summary>
        /// Método FinalizarConexion.
        /// Permite cerrar la conexión a la base de datos abierta anteriormente.
        /// </summary>
        public override void FinalizarConexion()
        {
            if (this.iConexion != null)
            {
                try
                {
                    this.iConexion.Close();
                }
                catch (NpgsqlException)
                {
                    
                    throw new DAOException("Hubo un problema en cerrar la conexión con la Base de Datos");
                }
            }
        }

        /// <summary>
        /// Método Commit.
        /// Permite realizar los commits necesarios para persistir los cambios en la base de datos.
        /// </summary>
        public override void Commit()
        {
            if (this.iTransaccion != null)
            {
                try
                {
                    this.iTransaccion.Commit();
                }
                catch (NpgsqlException)
                {

                    throw new DAOException("Hubo un problema al realizar el commit en la Base de Datos");
                }
            }
        }

        /// <summary>
        /// Método RollBack.
        /// Permite deshacer los cambios que se producen en la base de datos dejándola en su estado original
        /// antes de que se produjeran.
        /// </summary>
        public override void RollBack()
        {
            if (this.iTransaccion != null)
            {
                try
                {
                    this.iTransaccion.Rollback();
                }
                catch (NpgsqlException)
                {
                    
                    throw new DAOException("Hubo un problema al realizarse el rollback en la base de datos");
                }
            }
        }

        /// <summary>
        /// Método CuentaDAO.
        /// Devuelve una instancia del objeto CuentaDAO para poder manipularlo.
        /// </summary>
        /// <returns></returns>
        public override ICuentaDAO CuentaDAO()
        {
            PostgreSQLCuentaDAO cuenta = new PostgreSQLCuentaDAO(iConexion, iTransaccion);
            return cuenta;
        }

        /// <summary>
        /// Método MailDAO.
        /// Devuelve una instancia del objeto EmailDAO para poder manipularlo.
        /// </summary>
        /// <returns></returns>
        public override IMailDAO MailDAO()
        {
            PostgreSQLEmailDAO mail = new PostgreSQLEmailDAO(iConexion, iTransaccion);
            return mail;
        }

    }
}