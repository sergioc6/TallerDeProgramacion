using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using DTO;
using System.IO;
using Exportadores;

namespace GUI
{
    /// <summary>
    /// Formulario VerCorreos.
    /// Presenta información de los correos persistidos en base de datos, además de poder marcar como leídos a llos
    ///  que el usuario desee leer.
    /// </summary>
    public partial class VerCorreos : Form
    {
        /// <summary>
        /// Constructor de la clase VerCorreos.
        /// </summary>
        public VerCorreos()
        {
            InitializeComponent();
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            List<CuentaDTO> iLista = iControladorC.ObtenerCuenta();
            comboBoxFiltroCuentas.Items.Add("<Todos>");
            foreach (CuentaDTO Cuenta in iLista)
            {
                comboBoxFiltroCuentas.Items.Add(Cuenta.Direccion);
            }
        }

        /// <summary>
        /// Método TodosLosMails_Click.
        /// Muestra los mails en el dataGridView de la cuenta seleccionada en el comboBox presente en el formulario.
        /// En el caso de que el comboBox figure la etiqueta <Todos>, se mostrarán los emails de todas las cuentas en
        /// el dataGridView del formulario.
        /// </summary>
        public void TodosLosMails_Click(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreos = new List<EmailDTO>();
            
            if (comboBoxFiltroCuentas.SelectedItem.ToString() == "<Todos>")
            {
                dataGridViewCorreos.Rows.Clear();
                iListaCorreos = iControladorE.ObtenerTodosLosCorreos();
                foreach (EmailDTO EmailEnLista in iListaCorreos)
                {
                    dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                }
                dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
            }
            else
            {
                dataGridViewCorreos.Rows.Clear();
                CuentaDTO iCuenta = iControladorC.BuscarPorEmail(comboBoxFiltroCuentas.SelectedItem.ToString());
                iListaCorreos = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                foreach (EmailDTO EmailEnLista in iListaCorreos)
                {
                    dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                }
                dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
            }
            foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
            {
                if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                    {
                        Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
            }
        }

        /// <summary>
        /// Método MostrarTodos.
        /// Permite filtrar los mensajes en el dataGridView presente en el formulario y mostrar todos los mensajes.
        /// </summary>
        public void MostrarTodos(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreos = new List<EmailDTO>();
            if (checkBoxMostrarTodos.Checked)
            {
                checkBoxBorradores.CheckState = CheckState.Unchecked;
                checkBoxMostrarEnviados.CheckState = CheckState.Unchecked;
                checkBoxMostrarRecibidos.CheckState = CheckState.Unchecked;
                if (comboBoxFiltroCuentas.SelectedItem == null)
                {
                    MessageBox.Show("No hay mensajes para mostrar. Primero seleccione una cuenta para mostrar los mensajes que posee y luego filtre por la opción que desee", "Seleccione una cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxMostrarTodos.CheckState = CheckState.Unchecked;
                }
                else if (comboBoxFiltroCuentas.SelectedItem.ToString() == "<Todos>")
                {
                    dataGridViewCorreos.Rows.Clear();
                    iListaCorreos = iControladorE.ObtenerTodosLosCorreos();
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                else
                {
                    dataGridViewCorreos.Rows.Clear();
                    CuentaDTO iCuenta = iControladorC.BuscarPorEmail(comboBoxFiltroCuentas.SelectedItem.ToString());
                    iListaCorreos = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                
            }
        }

        /// <summary>
        /// Método MostrarEnviados.
        /// Permite filtrar los mensajes en el dataGridView presente en el formulario y mostrar todos los mensajes enviados.
        /// </summary>
        public void MostrarEnviados(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreos = new List<EmailDTO>();
            if (checkBoxMostrarEnviados.Checked)
            {
                checkBoxMostrarTodos.CheckState = CheckState.Unchecked;
                checkBoxMostrarRecibidos.CheckState = CheckState.Unchecked;
                checkBoxBorradores.CheckState = CheckState.Unchecked;
                if (comboBoxFiltroCuentas.SelectedItem == null)
                {
                    MessageBox.Show("No hay mensajes para mostrar. Primero seleccione una cuenta para mostrar los mensajes que posee y luego filtre por la opción que desee", "Seleccione una cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxMostrarEnviados.CheckState = CheckState.Unchecked;
                }
                else if (comboBoxFiltroCuentas.SelectedItem.ToString() == "<Todos>")
                {
                    dataGridViewCorreos.Rows.Clear();
                    iListaCorreos = iControladorE.ObtenerTodosLosCorreos();
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        if (EmailEnLista.Estado == "Enviado")
                        {
                            dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                        }
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                else
                {
                    dataGridViewCorreos.Rows.Clear();
                    CuentaDTO iCuenta = iControladorC.BuscarPorEmail(comboBoxFiltroCuentas.SelectedItem.ToString());
                    iListaCorreos = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        if (EmailEnLista.Estado == "Enviado")
                        {
                            dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                        }
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                
            }
        }

        /// <summary>
        /// Método MostrarRecibidos.
        /// Permite filtrar los mensajes en el dataGridView presente en el formulario y mostrar todos los mensajes recibidos.
        /// </summary>
        public void MostrarRecibidos(object pSender, EventArgs pEvento)
        {
            checkBoxBorradores.CheckState = CheckState.Unchecked;
            checkBoxMostrarEnviados.CheckState = CheckState.Unchecked;
            checkBoxMostrarTodos.CheckState = CheckState.Unchecked;
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreos = new List<EmailDTO>();
            if (checkBoxMostrarRecibidos.Checked)
            {
                if (comboBoxFiltroCuentas.SelectedItem == null)
                {
                    MessageBox.Show("No hay mensajes para mostrar. Primero seleccione una cuenta para mostrar los mensajes que posee y luego filtre por la opción que desee", "Seleccione una cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxMostrarRecibidos.CheckState = CheckState.Unchecked;
                }
                else if (comboBoxFiltroCuentas.SelectedItem.ToString() == "<Todos>")
                {
                    dataGridViewCorreos.Rows.Clear();
                    iListaCorreos = iControladorE.ObtenerTodosLosCorreos();
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        if (EmailEnLista.Estado == "Recibido")
                        {
                            dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                        }
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                else
                {
                    dataGridViewCorreos.Rows.Clear();
                    CuentaDTO iCuenta = iControladorC.BuscarPorEmail(comboBoxFiltroCuentas.SelectedItem.ToString());
                    iListaCorreos = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        if (EmailEnLista.Estado == "Recibido")
                        {
                            dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                        }
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                {
                    if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                    {
                        Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
                }
            }
        }

        /// <summary>
        /// Método MostrarBorradores.
        /// Permite filtrar los mensajes en el dataGridView presente en el formulario y mostrar todos los borradores.
        /// </summary>
        public void MostrarBorradores(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreos = new List<EmailDTO>();
            if (checkBoxBorradores.Checked)
            {
                checkBoxMostrarEnviados.CheckState = CheckState.Unchecked;
                checkBoxMostrarRecibidos.CheckState = CheckState.Unchecked;
                checkBoxMostrarTodos.CheckState = CheckState.Unchecked;
                if (comboBoxFiltroCuentas.SelectedItem == null)
                {
                    MessageBox.Show("No hay mensajes para mostrar. Primero seleccione una cuenta para mostrar los mensajes que posee y luego filtre por la opción que desee", "Seleccione una cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxBorradores.CheckState = CheckState.Unchecked;
                }
                else if (comboBoxFiltroCuentas.SelectedItem.ToString() == "<Todos>")
                {
                    dataGridViewCorreos.Rows.Clear();
                    iListaCorreos = iControladorE.ObtenerTodosLosCorreos();
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        if (EmailEnLista.Estado == "Borrador")
                        {
                            dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                        }
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                else
                {
                    dataGridViewCorreos.Rows.Clear();
                    CuentaDTO iCuenta = iControladorC.BuscarPorEmail(comboBoxFiltroCuentas.SelectedItem.ToString());
                    iListaCorreos = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                    foreach (EmailDTO EmailEnLista in iListaCorreos)
                    {
                        if (EmailEnLista.Estado == "Borrador")
                        {
                            dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Cuenta, EmailEnLista.Asunto, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                        }
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                
            }
        }

        /// <summary>
        /// Método VerInformacionMail_Click.
        /// Permite visualizar la información de un email, seleccionando su fila correspondiente.
        /// </summary>
        public void VerInformacionMail_Click(object pSender, DataGridViewCellEventArgs pEvento)
        {
            textBoxDestinatarios.Text = String.Empty;
            textBoxCCO.Text = String.Empty;
            textBoxCC.Text = String.Empty;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            int iEmailABuscar = Int32.Parse(dataGridViewCorreos.Rows[pEvento.RowIndex].Cells["IdMail"].Value.ToString());
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


            richTextBoxCuerpoMensajes.Text = iEmailSeleccionado.Cuerpo;
            textBoxAsuntoMail.Text = iEmailSeleccionado.Asunto;
            textBoxFechaMail.Text = iEmailSeleccionado.Fecha;
            textBoxIDMail.Text = iEmailSeleccionado.IDCorreo.ToString();
            iControladorE.MarcarLeido(iEmailABuscar);

            if (dataGridViewCorreos.Rows[pEvento.RowIndex].Cells["Leido"].Value.ToString() == "No leído")
            {
                dataGridViewCorreos.Rows[pEvento.RowIndex].Cells["Leido"].Value = "Leído";
                dataGridViewCorreos.CurrentRow.DefaultCellStyle.BackColor = Color.PowderBlue;
            }
        }

        /// <summary>
        /// Método ExportarEML_Click.
        /// Permite exportar un email a formato EML para guardarlo posteriormente.
        /// </summary>
        public void ExportarEML_Click(object pSender, EventArgs pEvento)
        {
            if (dataGridViewCorreos.CurrentRow != null)
            {
                ControladorEmail iControladorE = ControladorEmail.Instancia;
                int iEmailABuscar = Int32.Parse(textBoxIDMail.Text);
                EmailDTO iEmailSeleccionado = iControladorE.ObtenerUnCorreo(iEmailABuscar);

                SaveFileDialog iVentanaExportar = new SaveFileDialog();
                iVentanaExportar.Filter = "Archivo EML|*.eml|Todos los archivos|*.*";
                iVentanaExportar.Title = "Guardar email";
                iVentanaExportar.ShowDialog();

                string iRutaArchivo = Path.GetDirectoryName(iVentanaExportar.FileName);
                string iNombreArchivo = iVentanaExportar.FileName;
                FactoryExportadores.Instancia.GetExportador("EML").Exportar(iEmailSeleccionado, iRutaArchivo, iNombreArchivo);
                MessageBox.Show("El mensaje ha sido exportado con éxito.", "Mensaje exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Primero seleccione un mail de la grilla para que sea exportado","Mail no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Método ExportarTXT_Click.
        /// Permite exportar un email a formato TXT (texto plano) para guardarlo posteriormente.
        /// </summary>
        public void ExportarTXT_Click(object pSender, EventArgs pEvento)
        {
            if (dataGridViewCorreos.CurrentRow != null)
            {
                ControladorEmail iControladorE = ControladorEmail.Instancia;
                int iEmailABuscar = int.Parse(textBoxIDMail.Text);
                EmailDTO iEmailSeleccionado = iControladorE.ObtenerUnCorreo(iEmailABuscar);

                SaveFileDialog iVentanaExportar = new SaveFileDialog();
                iVentanaExportar.Filter = "Archivo TXT|*.txt|Todos los archivos|*.*";
                iVentanaExportar.Title = "Guardar email";
                iVentanaExportar.ShowDialog();
                string iRutaArchivo = Path.GetDirectoryName(iVentanaExportar.FileName);
                string iNombreArchivo = Path.GetFileName(iVentanaExportar.FileName);
                FactoryExportadores.Instancia.GetExportador("TXT").Exportar(iEmailSeleccionado, iRutaArchivo, iNombreArchivo);
                MessageBox.Show("El mensaje ha sido exportado con éxito.", "Mensaje exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero seleccione un mail de la grilla para que sea exportado", "Mail no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Método CerrarVerCorreos_Click.
        /// Cierra el formulario VerCorreos.
        /// </summary>
        public void CerrarVerCorreos_Click(object pSender, EventArgs pEvento)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Método RefrescarDTGV.
        /// Rellena de datos el dataGridView presente en el formulario, y refrescar su contenido por si se han insertado
        /// o eliminado datos.
        /// </summary>
        public void RefrescarDTGV()
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            CuentaDTO iCuenta = null;
            ControladorEmail iControladorE = ControladorEmail.Instancia;
            List<EmailDTO> iListaCorreosBD = new List<EmailDTO>();
            dataGridViewCorreos.Rows.Clear();
            if (comboBoxFiltroCuentas.SelectedItem.ToString() == "<Todos>")
            {
                iListaCorreosBD = iControladorE.ObtenerTodosLosCorreos();
                foreach (EmailDTO EmailEnLista in iListaCorreosBD)
                {
                    dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Asunto, EmailEnLista.Cuerpo, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                }
                dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                {
                    if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                    {
                        Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
                }
            }
            else
            {
                iCuenta = iControladorC.BuscarPorEmail(comboBoxFiltroCuentas.SelectedItem.ToString());
                if (iCuenta != null)
                {
                    iListaCorreosBD = iControladorE.ObtenerCorreosPorCuenta(iCuenta);
                    foreach (EmailDTO EmailEnLista in iListaCorreosBD)
                    {
                        dataGridViewCorreos.Rows.Add(EmailEnLista.IDCorreo, EmailEnLista.Remitente, EmailEnLista.Asunto, EmailEnLista.Cuerpo, EmailEnLista.Fecha, EmailEnLista.Estado, EmailEnLista.Leido);
                    }
                    dataGridViewCorreos.Sort(this.dataGridViewCorreos.Columns["IdMail"], ListSortDirection.Ascending);
                    foreach (DataGridViewRow Row in dataGridViewCorreos.Rows)
                    {
                        if (Convert.ToString(Row.Cells["Leido"].Value) == "Leído")
                        {
                            Row.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }
                    }
                }
                
            }

        }
    }
}
