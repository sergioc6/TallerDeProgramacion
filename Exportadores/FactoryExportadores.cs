using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportadores
{
    /// <summary>
    /// Clase pública FactoryExportadores.
    /// Utiliza el patrón Factory para crear las instancias de los exportadores especificados por su nombre.
    /// </summary>
    public class FactoryExportadores
    {
        private static FactoryExportadores iInstancia = null;
        /// <summary>
        /// Atributo de tipo diccionario responsable de relacionar los nombres de los exportadores
        /// con los mismos.
        /// </summary>
        private IDictionary<string, AbstractExportador> iExportadores;

        /// <summary>
        /// Constructor privado de la clase FactoryExportadores.
        /// Permite obtener una instancia de ExportadorEML o ExportadorTextoPlano.
        /// </summary>
        private FactoryExportadores()
        {
            this.iExportadores = new Dictionary<string, AbstractExportador>();

            ExportadorEML iExportadorEML = new ExportadorEML();
            ExportadorTextoPlano iExportadorTextoPlano = new ExportadorTextoPlano();

            this.iExportadores.Add("EML", iExportadorEML);
            this.iExportadores.Add("TXT", iExportadorTextoPlano);
        }
        
        /// <summary>
        /// Método responsable de buscar y devolverte un exportador dependiendo del nombre como parametro.
        /// </summary>
        /// <param name="nombre">Nombre que hace referencia al exportador a buscar.</param>
        /// <returns>Devuelve un exportador de tipo AbstractExportador buscado.</returns>
        public AbstractExportador GetExportador(string nombre)
        {
            //Le pedimos al diccionario con el nombre como clave que nos devuelva el exportador asociado.
            AbstractExportador iExportador = this.iExportadores[nombre];
            return iExportador;
        }

        /// <summary>
        /// Propiedad utilizada para lograr mantener una única instancia de la clase FabricaExportadores.
        /// </summary>
        public static FactoryExportadores Instancia
        {
            get
            {
                if (iInstancia == null)
                {
                    iInstancia = new FactoryExportadores();
                }
                return iInstancia;
            }
        }
    }
}
