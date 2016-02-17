using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using OpenPop.Pop3;
using OpenPop.Pop3.Exceptions;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ServiciosCorreo
{
    /// <summary>
    /// Clase pública Yahoo.
    /// Contiene los métodos necesarios para poder manipular un objeto que se conecta al servidor de Yahoo.
    /// </summary>
    public class Yahoo : AbstractServiciosCorreo
    {
        /// <summary>
        /// Constructor de la clase Yahoo.
        /// </summary>
        public Yahoo() : base("Yahoo") { }

        /// <summary>
        /// Método EnviarCorreo.
        /// Permite enviar un correo desde una casilla de Yahoo.
        /// </summary>
        /// <param name="pCuenta">Cuenta para enviar el correo</param>
        /// <param name="pMensaje">Mensaje que se construye para ser enviado</param>
        public override void EnviarCorreo(CuentaDTO pCuenta, MailMessage pMensaje)
        {
            try
            {
                SmtpClient iCliente = new SmtpClient("smtp.mail.yahoo.com");
                iCliente.EnableSsl = true;
                iCliente.Port = 587;
                iCliente.Credentials = new System.Net.NetworkCredential(pCuenta.Direccion, pCuenta.Contraseña);
                iCliente.Send(pMensaje);
            }
            catch (FormatException)
            {
                throw new ServiciosCorreoException("No se pudo enviar su correo. Revise si el correo del destinatario no está mal escrito e intente nuevamente");
            }
            catch (SmtpException)
            {
                throw new ServiciosCorreoException("No se pudo enviar su correo. Revise que su conexión a Internet esté funcionando e intente nuevamente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new ServiciosCorreoException("No se pudo enviar su correo");
            }
        }


        /// <summary>
        /// Método DescargarCorreos.
        /// Permite descargar los correos de una casilla de correo del tipo Yahoo.
        /// </summary>
        /// <param name="pCuenta">Cuenta para descargar correos</param>
        /// <returns>Lista de emails descargados</returns>
        public override List<EmailDTO> DescargarCorreos(CuentaDTO pCuenta)
        {
            List<EmailDTO> iListaCorreosDescargados = new List<EmailDTO>();
            Pop3Client iPop = new Pop3Client();
            Message iMensaje;
            string iIDMensaje;
            try
            {
                iPop.Connect("pop.mail.yahoo.com", 995, true);
                iPop.Authenticate(pCuenta.Direccion, pCuenta.Contraseña);
                int iCantidadMensajes = iPop.GetMessageCount();
                string iCuerpo = "";
                string iTipoCorreo = "";
                List<String> iDestino = new List<String>();
                List<String> iCC = new List<String>();
                List<String> iCCO = new List<String>();
                List<MessagePart> iListaAdjuntos = new List<MessagePart>();
                for (int i = iCantidadMensajes; i > 0; i--)
                {
                    iDestino.Clear();
                    iCC.Clear();
                    iCCO.Clear();
                    iMensaje = iPop.GetMessage(i);
                    iIDMensaje = iPop.GetMessageHeaders(i).MessageId;
                    if (iIDMensaje == null)
                    {
                        iIDMensaje = "";
                    }
                    MessagePart iTexto = iMensaje.FindFirstPlainTextVersion();
                    if (iTexto != null)
                    {
                        iCuerpo = iTexto.GetBodyAsText();
                    }
                    else
                    {
                        MessagePart iHTML = iMensaje.FindFirstHtmlVersion();
                        if (iHTML != null)
                        {
                            iCuerpo = iHTML.GetBodyAsText();
                        }
                    }
                    if (iMensaje.Headers.From.Address == pCuenta.Direccion)
                    {
                        iTipoCorreo = "Enviado";
                    }
                    else
                    {
                        iTipoCorreo = "Recibido";
                    }

                    foreach (RfcMailAddress direccionCorreo in iMensaje.Headers.To)
                    {
                        iDestino.Add(direccionCorreo.Address);

                    }

                    foreach (RfcMailAddress direccionCC in iMensaje.Headers.Cc)
                    {
                        iCC.Add(direccionCC.Address);
                    }

                    foreach (RfcMailAddress direccionCCO in iMensaje.Headers.Bcc)
                    {
                        iCCO.Add(direccionCCO.Address);
                    }
                    iListaAdjuntos = iMensaje.FindAllAttachments();
                   

                    EmailDTO iNuevoMail = new EmailDTO(
                            pCuenta.ID,
                            iTipoCorreo,
                            iMensaje.Headers.From.Address,
                            iDestino,
                            iMensaje.Headers.Subject,
                            iCuerpo,
                            iMensaje.Headers.DateSent.ToString(),
                            true,
                            iCC,
                            iCCO,
                            iIDMensaje,
                            "No leído"
                        );

                    iListaCorreosDescargados.Add(iNuevoMail);
                }
            }
            catch (InvalidLoginException)
            {
                throw new ServiciosCorreoException("No se puede actualizar la bandeja de la cuenta " + pCuenta.Direccion + ". Hubo un problema en el acceso");
            }
            catch (PopServerNotFoundException)
            {
                throw new ServiciosCorreoException("No se puede actualizar la bandeja de la cuenta " + pCuenta.Direccion + ". Hubo un error en el acceso al servidor POP3 de Yahoo");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new ServiciosCorreoException("No se puede actualizar la bandeja de la cuenta " + pCuenta.Direccion + ".");
            }

            return iListaCorreosDescargados;
        }
    }
}
