using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DTO;
using Controladores;
using ServiciosCorreo;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GUI
{
    /// <summary>
    /// Formulario DescargarMensajes.
    /// Permite descargar mensajes de la casilla de correo de una cuenta en particular.
    /// </summary>
    public partial class DescargarMensajes : Form
    {
        /// <summary>
        /// Constructor de la clase DescargarMensajes
        /// </summary>
        public DescargarMensajes()
        {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false;
                ControladorCuenta iControladorC = ControladorCuenta.Instancia;
                List<CuentaDTO> iListaCorreosEnBD = iControladorC.ObtenerCuenta();
                foreach (CuentaDTO Cuenta in iListaCorreosEnBD)
                {
                    comboBoxCuentasDisponibles.Items.Add(Cuenta.Direccion);
                    textBoxPuerto.Text = "995";
                }  
        }

        /// <summary>
        /// Método SeleccionarItemComboBox_Click.
        /// Permite rellenar el textBox de contraseña con la contraseña de la cuenta que haya sido seleccionada en
        /// el comboBox presente en el formulario.
        /// </summary>
        public void SeleccionarItemComboBox_Click(object pSender, EventArgs pEvento)
        {
            string iDireccionSeleccionada = comboBoxCuentasDisponibles.SelectedItem.ToString();
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            CuentaDTO CuentaEncontrada = iControladorC.BuscarPorEmail(iDireccionSeleccionada);
            textBoxContraseña.Text = CuentaEncontrada.Contraseña;
        }

        /// <summary>
        /// Método MostrarContraseña_Click.
        /// Permite mostrar los caracteres de la contraseña presente en el textBox de contraseña.
        /// </summary>
        public void MostrarContraseña_Click(object pSender, EventArgs pEvento)
        {
            if (checkBoxMostrarContraseña.Checked == true)
            {
                textBoxContraseña.PasswordChar = '\0';
            }
            else
            {
                textBoxContraseña.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Método DescargarMensajes_Click.
        /// Haciendo click en el botón Descargar presente en el formulario, permite descargar los mails
        /// de alguna cuenta de correo en particular que haya sido seleccionada en el comboBox y mostrarlos en el dataGridView.
        /// </summary>
        public void DescargarMensajes_Click(object pSender, EventArgs pEvento)
        {
            Espere iWinEspere = new Espere();
            Thread iHilo = new Thread(EventoDescargarMensajes);
            iHilo.Start();
            
            while (iHilo.IsAlive)
            {
                iWinEspere.Show();
                Application.DoEvents();
            }
            
            iHilo.Abort();
            iWinEspere.Dispose();
            iWinEspere.Close();
            MessageBox.Show("La descarga de mensajes se ha completado con éxito", "Descarga de mensajes completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        /// <summary>
        /// Método EventoDescargarMensajes.
        /// Permite descargar los correos de alguna cuenta en particular, especificada
        /// en el comboBox presente en el formulario.
        /// </summary>
        public void EventoDescargarMensajes()
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;

            if (comboBoxCuentasDisponibles.SelectedItem != null)
            {
                CuentaDTO iCuentaParaDescargar = iControladorC.BuscarPorEmail(comboBoxCuentasDisponibles.SelectedItem.ToString());
                iControladorE.DescargarCorreos(iCuentaParaDescargar);
                List<EmailDTO> iListaEmails = iControladorE.ObtenerCorreosPorCuenta(iCuentaParaDescargar);

                RefrescarDTGV();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar una cuenta para descargar correos. Intente nuevamente eligiendo entre las cuentas disponibles", "Cuenta no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        /// <summary>
        /// Método RefrescarDTGV.
        /// Permite refrescar con datos nuevos el dataGridView presente en el formulario DescargarMensajes.
        /// </summary>
        public void RefrescarDTGV()
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            CuentaDTO iCuenta = iControladorC.BuscarPorEmail(comboBoxCuentasDisponibles.SelectedItem.ToString());
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreosBD = new List<EmailDTO>();
            dataGridViewMensajes.Rows.Clear();
            if (iCuenta != null)
            {
                iListaCorreosBD = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                foreach (EmailDTO EmailEnLista in iListaCorreosBD)
                {
                    dataGridViewMensajes.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Asunto, EmailEnLista.Cuerpo, EmailEnLista.Fecha, EmailEnLista.Leido);
                }
                dataGridViewMensajes.Sort(this.dataGridViewMensajes.Columns["IdMail"], ListSortDirection.Ascending);
                foreach (DataGridViewRow Row in dataGridViewMensajes.Rows)
                {
                    if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                    {
                        Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
                }
            }

        }

        /// <summary>
        /// Método CerrarDescargarMensajes_Click.
        /// Cierra el formulario DescargarMensajes.
        /// </summary>
        public void CerrarDescargarMensajes_Click(object pSender, EventArgs pEvento)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Método VerInformacionMail_Click.
        /// Permite ver la información de un registro alojado en el dataGridView presente en el formulario,
        /// haciendo click en la fila deseada.
        /// </summary>
        public void VerInformacionMail_Click(object pSender, DataGridViewCellEventArgs pEvento)
        {
            textBoxDestinatarios.Text = String.Empty;
            textBoxCCO.Text = String.Empty;
            textBoxCC.Text = String.Empty;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            int iEmailABuscar = Int32.Parse(dataGridViewMensajes.Rows[pEvento.RowIndex].Cells["IdMail"].Value.ToString());
            EmailDTO iEmailSeleccionado = iControladorE.ObtenerUnCorreo(iEmailABuscar);
            // Asigno valor a los textBox correspondientes con los valores cargados en iEmailSeleccionado
            textBoxRemitente.Text = iEmailSeleccionado.Remitente;
            foreach (string Destinatario in iEmailSeleccionado.Destinatario)
            {
                textBoxDestinatarios.Text = textBoxDestinatarios.Text + Destinatario + ", ";
            }

            if (iEmailSeleccionado.ConCopia.Count != 0)
            {
                foreach (string CC in iEmailSeleccionado.ConCopia)
                {
                    textBoxCC.Text = textBoxCC.Text + CC + ", ";
                }
            }
            else
            {
                textBoxCC.Text = "<Ninguno>";
            }

            if (iEmailSeleccionado.ConCopiaOculta.Count != 0)
            {
                foreach (string CCO in iEmailSeleccionado.ConCopiaOculta)
                {
                    textBoxCCO.Text = textBoxCCO.Text + CCO + ", ";
                }
            }
            else
            {
                textBoxCCO.Text = "<Ninguno>";
            }


            textBoxCuerpoMensaje.Text = iEmailSeleccionado.Cuerpo;
            textBoxAsuntoMail.Text = iEmailSeleccionado.Asunto;
            textBoxFechaMail.Text = iEmailSeleccionado.Fecha;

            iControladorE.MarcarLeido(iEmailABuscar);
            
            if (dataGridViewMensajes.Rows[pEvento.RowIndex].Cells["Leido"].Value.ToString() == "No leído")
            {
                dataGridViewMensajes.Rows[pEvento.RowIndex].Cells["Leido"].Value = "Leído";
                dataGridViewMensajes.CurrentRow.DefaultCellStyle.BackColor = Color.PowderBlue;
            }
        }
    }
}
