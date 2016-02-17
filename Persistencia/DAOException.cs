using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    /// <summary>
    /// Clase pública DAOException.
    /// Lanza las excepciones correspondientes en el uso de de los objetos de Email y Cuenta.
    /// </summary>
    public class DAOException : Exception
    {
        // Constructor de la clase ExportadoresException
        public DAOException(string pMensaje)
            : base(pMensaje)
        {
        }
    }
}
