using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistencia;
using System.Threading.Tasks;

namespace Controladores
{
    /// <summary>
    /// Clase pública ControladorConexion.
    /// Se utiliza para controlar de que la aplicación al iniciar esté conectada a una base de datos.
    /// </summary>
    public class ControladorConexion
    {
        DAOFactory iInstancia = DAOFactory.Instancia();
        /// <summary>
        /// Método ProbarConexion.
        /// Permite probar si la conexión está conectada a la base de datos.
        /// </summary>
        /// <returns>TRUE en el caso de que esté conectada. FALSE en caso contrario</returns>
        public bool ProbarConexionBD()
        {
            try
            {
                iInstancia.IniciarConexion();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw new Exception("No se pudo conectar a la base de datos");
            }
            finally
            {
                iInstancia.FinalizarConexion();
            }
        }

        
    }
}
