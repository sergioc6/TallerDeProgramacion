using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.PersistenciaPostgreSQL;

namespace Persistencia
{
    public abstract class DAOFactory
    {
        private static DAOFactory iInstaciaDAO = null;
        /// <summary>
        /// Devuelve una instancia de CuentaDAO que provee funciones para interactuar con la base de datos
        /// </summary>
        public abstract ICuentaDAO CuentaDAO();

        /// <summary>
        /// Devuelve una instancia de MailDAO que provee funciones para interactuar con la base de datos
        /// </summary>
        public abstract IMailDAO MailDAO();

        /// <summary>
        /// Devuelve una instancia de DAOFactory para realizar operaciones en la base de datos
        /// </summary>
        public static DAOFactory Instancia()
        {
            if (iInstaciaDAO == null)
            {
                iInstaciaDAO = new PostgreSQLDAOFactory();
            }
            return iInstaciaDAO;
        }

        /// <summary>
        /// Inicia la conexion entre la capa DAO y la base de datos
        /// </summary>
        public abstract void IniciarConexion();

        /// <summary>
        /// Inicia una transaccion dentro de la base de datos
        /// </summary>
        public abstract void ComenzarTransaccion();

        /// <summary>
        /// Realiza la confirmacion de las operaciones de una transaccion abierta
        /// </summary>
        public abstract void Commit();

        /// <summary>
        /// Deshace las operaciones de una transaccion realizada en la base de datos
        /// </summary>
        public abstract void RollBack();

        /// <summary>
        /// Finaliza la conexion entre la capa DAO y la base de datos
        /// </summary>
        public abstract void FinalizarConexion(); 
    }
}
