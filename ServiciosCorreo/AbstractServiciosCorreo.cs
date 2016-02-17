using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using DTO;

namespace ServiciosCorreo
{
    /// <summary>
    /// Clase pública abstracta AbstractSeriviosCorreo.
    /// Clase para construir las clase de servicios de correo.
    /// </summary>
    public abstract class AbstractServiciosCorreo
    {
        private string iNombre; // Nombre del servicio de la cuenta

        /// <summary>
        /// Constructor de la clase AbstracServiciosCorreo
        /// </summary>
        /// <param name="pNombre">Nombre del servicio de la cuenta</param>
        public AbstractServiciosCorreo(string pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Método abstracto DescargarCorreos.
        /// Permite descargar los correos de una cuenta específica.
        /// </summary>
        /// <param name="pCuenta">Cuenta para descargar correos</param>
        /// <returns>Lista de emails descargados</returns>
        public abstract List<EmailDTO> DescargarCorreos(CuentaDTO pCuenta);

        /// <summary>
        /// Método EnviarCorreo.
        /// Permite enviar un correo mediante una cuenta especificada.
        /// </summary>
        /// <param name="pCuenta">Cuenta de la cual queremos enviar el mail</param>
        /// <param name="pMensaje">Mail que construimos para enviarlo</param>
        public abstract void EnviarCorreo(CuentaDTO pCuenta, MailMessage pMensaje);

        /// <summary>
        /// Propiedad de la clase AbstractServiciosCorreo
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
    }
}
