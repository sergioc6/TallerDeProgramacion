using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosCorreo
{
    /// <summary>
    /// Clase pública FactoryServicios.
    /// Utiliza el patrón Factory para crear las instancias de las clases de Servicios especificados por su nombre.
    /// </summary>
    public class FactoryServicios
    {
        private static FactoryServicios iInstancia = null;
        /// <summary>
        /// Atributo de tipo diccionario responsable de relacionar los nombres de los Servicios
        /// con los mismos.
        /// </summary>
        private IDictionary<string, AbstractServiciosCorreo> DiccionarioServicios;

        /// <summary>
        /// Constructor privado de la clase FactoryServicios.
        /// Permite obtener una instancia de Gmail o Yahoo.
        /// </summary>
        private FactoryServicios()
        {
            this.DiccionarioServicios = new Dictionary<string, AbstractServiciosCorreo>();
            Gmail ServicioGmail = new Gmail();
            Yahoo ServicioYahoo = new Yahoo();

            this.DiccionarioServicios.Add("Gmail", ServicioGmail);
            this.DiccionarioServicios.Add("Yahoo", ServicioYahoo);
        }

        /// <summary>
        /// Propiedad utilizada para lograr mantener una únca instancia de la clase FabricaExportadores.
        /// </summary>
        public static FactoryServicios Instancia
        {
            get
            {
                if (iInstancia == null)
                {
                    iInstancia = new FactoryServicios();
                }
                return iInstancia;
            }
        }

        /// <summary>
        /// Metodo responsable de buscar y devolverte un Servicio dependiendo del nombre como parametro.
        /// </summary>
        /// <param name="pNombreServicio">Nombre del servicio que necesitamos</param>
        /// <returns>Devuelve un exportador de tipo AbstractExportador buscado</returns>
        public AbstractServiciosCorreo Servicio(string pNombreServicio)
        {
            AbstractServiciosCorreo ServicioCorreo = this.DiccionarioServicios[pNombreServicio];
            return ServicioCorreo;
        }

    }
}
