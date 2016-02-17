using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using Controladores;
using DTO;
using OpenPop.Mime;
using ServiciosCorreo;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace GUI
{
    /// <summary>
    /// Formulario EnviarMail.
    /// Permite enviar mails desde una dirección de correo seleccionada por el usuario.
    /// </summary>
    public partial class EnviarMail : Form
    {
        /// <summary>
        /// Constructor de la clase EnviarMail.
        /// </summary>
        public EnviarMail()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            List<CuentaDTO> iListaCuentas = iControladorC.ObtenerCuenta();
            foreach (CuentaDTO Cuenta in iListaCuentas)
            {
                comboBoxRemitente.Items.Add(Cuenta.Direccion);
            }
            timerFechaHoraActual.Enabled = true;
        }

        /// <summary>
        /// Método TimerHoraFechaActual_Tick.
        /// Obtiene la fecha y hora actual del sistema y cargarla en el textBox correspondiente a la fecha y hora
        /// presente en el formulario.
        /// </summary>
        private void TimerHoraFechaActual_Tick(object pSender, EventArgs pEvento)
        {
            textBoxFechaMail.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Método EnviarMail_Click.
        /// Permite enviar un mail desde una dirección de correo elegida por el usuario, hacia los destinatarios que desee.
        /// Además se pueden especificar las direcciones que se les desee enviar con copia y copia oculta, y adjuntar archivos.
        /// </summary>
        public void EnviarMail_Click(object pSender, EventArgs pEvento)
        {
                Enviando iWinEspere = new Enviando();
                Thread iHilo = new Thread(EventoEnviarMail);
                iHilo.Start();

                while (iHilo.IsAlive)
                {
                    iWinEspere.Show();
                    Application.DoEvents();
                }

                iHilo.Abort();
                iWinEspere.Dispose();
                iWinEspere.Close();
                MessageBox.Show("¡El mail fue enviado con éxito!", "Mail enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento EventoEnviarMail.
        /// Se ejecuta en segundo plano para enviar mails a una casilla de correo especificada.
        /// </summary>
        public void EventoEnviarMail()
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<String> iDestinatarios = new List<String>();
            List<String> iCC = new List<String>();
            List<String> iCCO = new List<String>();
            MailMessage iMensaje = new MailMessage();
            EmailDTO iEmail = null;
            CuentaDTO iCuenta = null;

            if (comboBoxRemitente.SelectedItem == null)
            {
                MessageBox.Show("Existen campos incompletos. Se recomiendo que seleccione un remitente de los disponibles y luego agregue un destinatario. Luego pruebe enviar el mensaje nuevamente", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxDestinatarios.Lines == null)
            {
                MessageBox.Show("Existen campos incompletos. Se recomiendo que agregue al menos un destinatario escrito en forma correcta. Luego pruebe enviar el mensaje nuevamente", "Campos incompletos o formato de mail inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxAsuntoMail.Text == "" || richTextBoxCuerpoMensajes.Text == "")
            {
                DialogResult Resultado = MessageBox.Show("Está a punto de enviar el mail sin un asunto definido o sin cuerpo. ¿Desea enviarlo de todas maneras?", "Email sin asunto o cuerpo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (Resultado == DialogResult.Yes)
                {
                    iMensaje.From = new MailAddress(comboBoxRemitente.SelectedItem.ToString());
                    foreach (string Linea in textBoxDestinatarios.Lines)
                    {
                        iMensaje.To.Add(new MailAddress(Linea));
                    }

                    foreach (string Linea in textBoxCC.Lines)
                    {
                        iMensaje.CC.Add(new MailAddress(Linea));
                    }

                    foreach (string Linea in textBoxCCO.Lines)
                    {
                        iMensaje.Bcc.Add(new MailAddress(Linea));
                    }

                    iMensaje.Subject = textBoxAsuntoMail.Text;
                    iMensaje.Body = richTextBoxCuerpoMensajes.Text;

                    foreach (TreeNode Nodo in treeViewAdjuntos.Nodes)
                    {
                        Attachment Adjunto = new Attachment(@Nodo.Text);
                        iMensaje.Attachments.Add(Adjunto);
                    }


                    foreach (string Linea in textBoxDestinatarios.Lines)
                    {
                        iDestinatarios.Add(Linea);
                    }
                    foreach (string Linea in textBoxCC.Lines)
                    {
                        iCC.Add(Linea);
                    }
                    foreach (string Linea in textBoxCCO.Lines)
                    {
                        iCCO.Add(Linea);
                    }

                    iCuenta = iControladorC.BuscarPorEmail(comboBoxRemitente.SelectedItem.ToString());
                    iEmail = new EmailDTO(iCuenta.ID, "Enviado", comboBoxRemitente.SelectedItem.ToString(), iDestinatarios, textBoxAsuntoMail.Text, richTextBoxCuerpoMensajes.Text, textBoxFechaMail.Text, true, iCC, iCCO);

                    iControladorE.EnviarEmail(iEmail, iCuenta, iMensaje);
                    MessageBox.Show("¡El mail fue enviado con éxito!", "Mail enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxFechaMail.Refresh();
                }
            }
            else
            {
                foreach (string Linea in textBoxDestinatarios.Lines)
                {
                    iDestinatarios.Add(Linea);
                }
                foreach (string Linea in textBoxCC.Lines)
                {
                    iCC.Add(Linea);
                }
                foreach (string Linea in textBoxCCO.Lines)
                {
                    iCCO.Add(Linea);
                }

                iMensaje.From = new MailAddress(comboBoxRemitente.SelectedItem.ToString());
                foreach (string Linea in textBoxDestinatarios.Lines)
                {
                    iMensaje.To.Add(new MailAddress(Linea));
                }

                foreach (string Linea in textBoxCC.Lines)
                {
                    iMensaje.CC.Add(new MailAddress(Linea));
                }

                foreach (string Linea in textBoxCCO.Lines)
                {
                    iMensaje.Bcc.Add(new MailAddress(Linea));
                }

                iMensaje.Subject = textBoxAsuntoMail.Text;
                iMensaje.Body = richTextBoxCuerpoMensajes.Text;

                foreach (TreeNode Nodo in treeViewAdjuntos.Nodes)
                {
                    Attachment Adjunto = new Attachment(@Nodo.Text);
                    iMensaje.Attachments.Add(Adjunto);
                }

                iCuenta = iControladorC.BuscarPorEmail(comboBoxRemitente.SelectedItem.ToString());
                iEmail = new EmailDTO(iCuenta.ID, "Enviado", comboBoxRemitente.SelectedItem.ToString(), iDestinatarios, textBoxAsuntoMail.Text, richTextBoxCuerpoMensajes.Text, textBoxFechaMail.Text, true, iCC, iCCO);

                iControladorE.EnviarEmail(iEmail, iCuenta, iMensaje);
                textBoxFechaMail.Refresh();
            }
        }

        /// <summary>
        /// Método CambiarNombreRemitente_Click.
        /// Permite mostrar el nombre de la dirección de correo que se encuentra cargada en el
        /// comboBox presente en el formulario.
        /// </summary>
        public void CambiarNombreRemitente_Click(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            string iDireccion = comboBoxRemitente.SelectedItem.ToString();
            CuentaDTO iCuenta = iControladorC.BuscarPorEmail(iDireccion);
            textBoxNombreRemitente.Text = iCuenta.Nombre;
        }

        /// <summary>
        /// Método CerrarEnviarMail_Click.
        /// Cierra el formulario EnviarMail.
        /// </summary>
        public void CerrarEnviarMail_Click(object pSender, EventArgs pEvento)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Método AdjuntarArchivos_Click.
        /// Permite adjuntar archivos y mostrarlos en el treeView presente en el formulario, para luego ser
        /// enviados en el mail.
        /// </summary>
        public void AdjuntarArchivos_Click(object pSender, EventArgs pEvento)
        {
            OpenFileDialog iVentanaAdjuntos = new OpenFileDialog();
            iVentanaAdjuntos.ShowDialog();

            iVentanaAdjuntos.DefaultExt = ".*";
            iVentanaAdjuntos.Filter = "Archivos (.*)|*.*";


            if (iVentanaAdjuntos.FileName.Equals("") == false)
            {
                treeViewAdjuntos.Nodes.Add(iVentanaAdjuntos.FileName);
            }

            bool iHayAdjuntosCargados = treeViewAdjuntos.Nodes.Count > 0;
            buttonQuitarAdjunto.Enabled = iHayAdjuntosCargados;
        }

        /// <summary>
        /// Método QuitarArchivoAdjunto_Click.
        /// Permite quitar de la lista de archivos adjuntos presentes en el treeView, los archivos
        /// que el usuario no considere necesario adjuntar.
        /// </summary>
        public void QuitarArchivoAdjunto_Click(object pSender, EventArgs pEvento)
        {
            if (treeViewAdjuntos.SelectedNode == null)
            {
                MessageBox.Show("Debe seleccionar un archivo adjunto para quitar. Seleccione de la lista alguno que desee quitar, y pruebe nuevamente", "Seleccione un adjunto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                treeViewAdjuntos.SelectedNode.Remove();
            }

        }

        /// <summary>
        /// Método GuardarBorrador_Click.
        /// Permite guardar un email como borrador para ser enviado mas tarde si el usuario
        /// lo considera necesario.
        /// </summary>
        public void GuardarBorrador_Click(object pSender, EventArgs pEvento)
        {
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            CuentaDTO iCuenta = null;
            List<String> iDestinatarios = new List<String>();
            List<String> iCC = new List<String>();
            List<String> iCCO = new List<String>();
            EmailDTO iEmailBorrador = null;
            string iRemitente = "";
            string iEstado = "Borrador";
            if (comboBoxRemitente.SelectedItem == null)
            {

                MessageBox.Show("No se pudo guardar el mensaje como borrador. Se recomienda que deje en el borrador constancia de, al menos, el remitente. Luego pruebe guardar el mensaje nuevamente", "No se pudo guardar el borrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                iRemitente = comboBoxRemitente.SelectedItem.ToString();
                iCuenta = iControladorC.BuscarPorEmail(comboBoxRemitente.SelectedItem.ToString());
                foreach (string Destinatario in textBoxDestinatarios.Lines)
                {
                    iDestinatarios.Add(Destinatario);
                }
                foreach (string CC in textBoxCC.Lines)
                {
                    iCC.Add(CC);
                }
                foreach (string CCO in textBoxCCO.Lines)
                {
                    iCCO.Add(CCO);
                }
                string iAsunto = textBoxAsuntoMail.Text;
                string iFecha = textBoxFechaMail.Text;
                string iCuerpo = richTextBoxCuerpoMensajes.Text;

                iEmailBorrador = new EmailDTO(iCuenta.ID, iEstado, iRemitente, iDestinatarios, iAsunto, iCuerpo, iFecha, true, iCC, iCCO, "", "Leído");
                iControladorE.GuardarCorreo(iEmailBorrador);
                MessageBox.Show("Mensaje ha sido guardado con éxito", "Borrador guardado", MessageBoxButtons.OK);
            }

        }

        /// <summary>
        /// Método ValidarMail.
        /// Permite validar si un email está escrito correctamente.
        /// </summary>
        public bool ValidarMail(string pInputEmail)
        {
            //El operador ?? devuelve el operando izquierdo si NO es NULL; de lo contrario, devuelve el operando derecho.
            pInputEmail = pInputEmail ?? string.Empty;
            string strRegex =
                   @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            //Indica si la expresión regular especificada en el constructor Regex encuentra una coincidencia en una cadena de entrada indicada.
            Regex re = new Regex(strRegex);
            //Indica si la expresión regular especificada en el constructor Regex encuentra una coincidencia en una cadena de entrada indicada.
            if (re.IsMatch(pInputEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
