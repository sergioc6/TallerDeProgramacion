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
    public partial class Enviando : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        public Enviando()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        /// <summary>
        /// Propiedad CreateParams.
        /// Se utiliza solo para fines estéticos y desactiva el botón de Cerrar en la ventana de Enviando
        /// al momento de crearse el formulario.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
