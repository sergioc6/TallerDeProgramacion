using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;
using DTO;

namespace Exportadores
{
    /// <summary>
    /// Clase pública ExportadorEML.
    /// Clase que permite exportar a EML los mails que deseamos guardar.
    /// </summary>
    public class ExportadorEML : AbstractExportador
    {
        // Constructor de la clase ExportadorEML
        public ExportadorEML() : base("EML") { }
        
        /// <summary>
        /// Método Exportar.
        /// Permite exportar a EML un mail específico que hayamos elegido.
        /// </summary>
        /// <param name="pEmail">Email a exportar</param>
        /// <param name="pRuta">Ruta donde guardaremos el archivo</param>
        /// <param name="pNombre">Nombre que le daremos al archivo a exportar</param>
        public override void Exportar(EmailDTO pEmail, string pRuta, string pNombre)
        {
            try
            {
                // Utilizamos un cliente SMTP para poder 'enviar' el mail exportado a EML
                // a la ruta que especificamos en los parámetros. Una vez 'enviado', el 
                // email se guardará como un archivo .eml
                MailMessage iEmail = new MailMessage();
                iEmail.From = new MailAddress(pEmail.Remitente);
                foreach (string Destinatario in pEmail.Destinatario)
                {
                    iEmail.To.Add(Destinatario);
                }
                iEmail.Subject = pEmail.Asunto;
                iEmail.Body = pEmail.Cuerpo;
                SmtpClient iCliente = new SmtpClient();
                iCliente.UseDefaultCredentials = true;
                iCliente.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                iCliente.PickupDirectoryLocation = pRuta;
                iCliente.Send(iEmail);
                
            }
            catch (FormatException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. Hubo un problema con el formato del correo a exportar o con la ruta de la carpeta elegida. Eliga una nueva ruta o revise el correo y vuelva a intentarlo.");
            }
            catch (PathTooLongException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. La ruta para guardar el archivo es demasiado larga. Revise la ruta e intente nuevamente");
            }
            catch (IOException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. Hubo un problema al guardar el archivo. Elija otra carpeta e intente nuevamente");
            }
            catch (SmtpException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. Reinicie la aplicación e intente nuevamente");
            }
            catch (Exception)
            {
                throw new ExportadoresException("No se pudo exportar su correo");
            }
        }
    }
}
