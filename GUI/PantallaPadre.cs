using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using Persistencia;
using Controladores;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Formulario PantallaPadre.
    /// Pantalla principal de la aplicación MailApp.
    /// </summary>
    public partial class PantallaPadre : Form
    {
        private int childFormNumber = 0;

        /// <summary>
        /// Constructor de la clase PantallaPadre.
        /// </summary>
        public PantallaPadre()
        {
            ControladorConexion iControlador = new ControladorConexion();
            if (iControlador.ProbarConexionBD())
            {
                InitializeComponent();
                this.CenterToScreen();
                this.InicializarTimer();
                timerHoraActual.Enabled = true;
            }  
            else 
            {
                InitializeComponent();
                this.CenterToScreen();
                this.InicializarTimer();
                timerHoraActual.Enabled = true;
                MessageBox.Show("Actualmente no se encuentra conectado a la base de datos, por lo que no podrá realizar acciones. Revise en la lista de servicios (en Windows, Inicio -> Ejecutar -> escribir services.msc -> Enter) que el servicio del motor de base de datos esté iniciado. Luego reinicie la aplicación y pruebe nuevamente.", "Hubo un problema en la conexión a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cuentasMenu.Enabled = false;
                this.correosMenu.Enabled = false;
            }
            
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        #region Código generado por Visual Studio
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion

        private void verCorreosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método AbrirAgregarCuenta_Click.
        /// Permite abrir el formulario AgregarCuenta.
        /// </summary>
        private void AbrirAgregarCuenta_Click(object pSender, EventArgs pEvento)
        {
            AgregarCuenta iWinAgregarCuenta = new AgregarCuenta();
            iWinAgregarCuenta.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinAgregarCuenta.Show();

        }
        /// <summary>
        /// Método AbrirVerCuentas_Click.
        /// Permite abrir el formulario VerCuentas.
        /// </summary>
        private void AbrirVerCuentas_Click(object pSender, EventArgs pEvento)
        {
            VerCuentas iWinVerCuentas = new VerCuentas();
            iWinVerCuentas.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinVerCuentas.Show();
        }

        /// <summary>
        /// Método AbrirModificarCuenta_Click.
        /// Permite abrir el formulario ModificarCuenta.
        /// </summary>
        private void AbrirModificarCuenta_Click(object pSender, EventArgs pEvento)
        {
            ModificarCuenta iWinModificarCuenta = new ModificarCuenta();
            iWinModificarCuenta.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinModificarCuenta.Show();
        }

        /// <summary>
        /// Método AbrirEliminarCuenta_Click.
        /// Permite abrir el formulario EliminarCuenta.
        /// </summary>
        private void AbrirEliminarCuenta_Click(object pSender, EventArgs pEvento)
        {
            EliminarCuenta iWinEliminarCuenta = new EliminarCuenta();
            iWinEliminarCuenta.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinEliminarCuenta.Show();
        }

        /// <summary>
        /// Método AbrirVerCorreos_Click.
        /// Permite abrir el formulario VerCorreos.
        /// </summary>
        private void AbrirVerCorreos_Click(object pSender, EventArgs pEvento)
        {
            VerCorreos iWinVerCorreos = new VerCorreos();
            iWinVerCorreos.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinVerCorreos.Show();
        }

        /// <summary>
        /// Método AbrirEnviarMail_Click.
        /// Permite abrir el formulario EnviarMail.
        /// </summary>
        private void AbrirEnviarMail_Click(object pSender, EventArgs pEvento)
        {
            EnviarMail iWinEnviarMail = new EnviarMail();
            iWinEnviarMail.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinEnviarMail.Show();
        }

        /// <summary>
        /// Método AbrirDescargarMails_Click.
        /// Permite abrir el formulario DescargarMails.
        /// </summary>
        private void AbrirDescargarMails_Click(object pSender, EventArgs pEvento)
        {
            DescargarMensajes iWinDescargarMails = new DescargarMensajes();
            iWinDescargarMails.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinDescargarMails.Show();
        }

        /// <summary>
        /// Método AbrirAyuda_Click.
        /// Permite abrir el formulario Ayuda.
        /// </summary>
        private void AbrirAyuda_Click(object pSender, EventArgs pEvento)
        {
            Ayuda iWinAyuda = new Ayuda();
            iWinAyuda.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinAyuda.Show();
        }
        
        /// <summary>
        /// Método AbrirContacto_Click.
        /// Permite abrir el formulario Contacto.
        /// </summary>
        private void AbrirContacto_Click(object pSender, EventArgs pEvento)
        {
            Contacto iWinContacto = new Contacto();
            iWinContacto.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinContacto.Show();
        }

        /// <summary>
        /// Método AbrirAcercaDe_Click.
        /// Permite abrir el formulario AcercaDe.
        /// </summary>
        private void AbrirAcercaDe_Click(object pSender, EventArgs pEvento)
        {
            AcercaDe iWinAcercaDe = new AcercaDe();
            iWinAcercaDe.MdiParent = this;
            this.PanelInicio.Visible = false;
            iWinAcercaDe.Show();
        }

        /// <summary>
        /// Método VerEstadoInternet.
        /// Permite verificar si estamos conectados o no a internet, realizando un ping a la página de Google.
        /// </summary>
        /// <returns>TRUE si estamos conectados a internet, FALSE en caso contrario</returns>
        private bool VerEstadoInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Método SetLabelConexion.
        /// Cambia el label que muestra la información del estado de la conexión, si es que estamos o no conectados
        /// a internet. Es a modo de información para el usuario.
        /// </summary>
        private void SetLabelConexion()
        {
            bool iEstadoConexion = this.VerEstadoInternet();
            if (iEstadoConexion)
            {
                toolStripStatusLabelEstadoConexion.Text = "Estado de conexión a internet: Conectado";
                toolStripStatusLabelEstadoConexion.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                toolStripStatusLabelEstadoConexion.Text = "Estado de conexión a internet: No conectado";
                toolStripStatusLabelEstadoConexion.ForeColor = System.Drawing.Color.Red;
            }
        }


        /// <summary>
        /// Método InicializarTimer.
        /// Inicializa el timer para obtener la fecha y hora actual, y reflejarla en la aplicación a modo
        /// de información para el usuario.
        /// </summary>
        public void InicializarTimer()
        {
            timerRefrescar.Tick += new EventHandler(TimerRefrescar_Tick);
            timerRefrescar.Interval = 2000; // Refresca la pantalla cada 2 segundos
            timerRefrescar.Start();
        }

        /// <summary>
        /// Método TimerRefrescar_Tick.
        /// Método que permite actualizar el label que muestra información del estado de conexión,
        /// si es que estamos o no conectados a internet.
        /// </summary>
        private void TimerRefrescar_Tick(object pSender, EventArgs pEvento)
        {
            this.SetLabelConexion();
        }

        /// <summary>
        /// Método TimerHoraFechaAactual_Tick.
        /// Permite obtener la fecha y hora actual para el sistema.
        /// </summary>
        private void TimerHoraFechaActual_Tick(object pSender, EventArgs pEvento)
        {
            toolStripStatusLabelHoraActual.Text = DateTime.Now.ToString();
        }
    }
}
