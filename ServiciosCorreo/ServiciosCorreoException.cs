using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosCorreo
{
    /// <summary>
    /// Clase pública ServiciosCorreoException.
    /// Manipula todas las excepciones de ServiciosCorreo.
    /// </summary>
    public class ServiciosCorreoException : Exception
    {
        public ServiciosCorreoException(string pMensaje)
            : base(pMensaje)
        {

        }
    }
}
