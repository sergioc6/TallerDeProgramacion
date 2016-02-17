using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportadores
{
    /// <summary>
    /// Clase pública ExportadoresException.
    /// Lanza las excepciones correspondientes en el uso de los objetos Exportadores.
    /// </summary>
    public class ExportadoresException : Exception
    {
        // Constructor de la clase ExportadoresException
        public ExportadoresException(string pMensaje)
            : base(pMensaje)
        {
        }
    }
}
