using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Exportadores
{
    /// <summary>
    /// Clase pública abstracta AbstractExportador.
    /// Clase para construir los exportadores.
    /// </summary>
    public abstract class AbstractExportador
    {
        private string iNombre; // Nombre del tipo de Exportador que vamos a utilizar

        // Constructor de la clase AbstractExportador
        public AbstractExportador(string pNombre)
        {
            this.iNombre = pNombre;
        }
        
        // Propiedad de AbstractExportador
        public string Nombre
        {
            get { return this.iNombre; }
        }

        /// <summary>
        /// Método abstracto Exportar.
        /// Se utiliza para crear una instancia de un Exportador en particular
        /// </summary>
        /// <param name="pEmail">Email que vamos a exportar</param>
        /// <param name="pRuta">Ruta donde exportaremos el mail</param>
        /// <param name="pNombre">Nombre que le asignamos archivo</param>
        public abstract void Exportar(EmailDTO pEmail, string pRuta, string pNombre);
    }
}
