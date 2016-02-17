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
    /// Formulario Contacto.
    /// Muestra información acerca de las forma de contactarse con los creadores de MailApp.
    /// </summary>
    public partial class Contacto : Form
    {
        /// <summary>
        /// Constructor de la clase Contacto.
        /// </summary>
        public Contacto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método VisitarFbSergioCabral_LinkClick.
        /// Permite visitar la página de Facebook de Sergio Cabral.
        /// </summary>
        private void VisitarFbSergioCabral_LinkClick(object pSender, LinkLabelLinkClickedEventArgs pEvento)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/scabral6");
        }

        /// <summary>
        /// Método VisitarTwitterSergioCabral_LinkClick.
        /// Permite visitar la página de Twitter de Sergio Cabral.
        /// </summary>
        private void VisitarTwitterSergioCabral_LinkClick(object pSender, LinkLabelLinkClickedEventArgs pEvento)
        {
            System.Diagnostics.Process.Start("https://twitter.com/SCabral6");
        }

        /// <summary>
        /// Método VisitarFbNahuelLeiva_LinkClick.
        /// Permite visitar la página de Facebook de Nahuel Leiva.
        /// </summary>
        private void VisitarFbNahuelLeiva_LinkClick(object pSender, LinkLabelLinkClickedEventArgs pEvento)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/nahuel.leiva.10");
        }

        /// <summary>
        /// Método VisitarFbSantiagoPacheco_LinkClick.
        /// Permite visitar la página de Facebook de Santiago Pacheco.
        /// </summary>
        private void VisitarFbSantiagoPacheco_LinkClick(object pSender, LinkLabelLinkClickedEventArgs pEvento)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/santiago.pacheco.5439");
        }
    }
}
