using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Formulario Ayuda.
    /// Muestra información de ayuda para el usuario sobre los componentes de MailApp.
    /// </summary>
    public partial class Ayuda : Form
    {
        /// <summary>
        /// Constructor de la clase Ayuda.
        /// </summary>
        public Ayuda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para cerrar la ventana Ayuda.
        /// </summary>
        public void CerrarAyuda_Click(object pSender, EventArgs pEvento)
        {
            this.Dispose();
            this.Close();
        }
    }
}
