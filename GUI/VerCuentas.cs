using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controladores;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Formulario VerCuentas.
    /// Permite visualizar información de las cuentas disponibles en la aplicación.
    /// </summary>
    public partial class VerCuentas : Form
    {
        /// <summary>
        /// Constructor de la clase VerCuentas.
        /// </summary>
        public VerCuentas()
        {
            InitializeComponent();
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            List<CuentaDTO> iListaCorreosBD = new List<CuentaDTO>();
            iListaCorreosBD = iControladorC.ObtenerCuenta();
            foreach (CuentaDTO CuentaEnLista in iListaCorreosBD)
            {
                dataGridViewDatosCuentas.Rows.Add(CuentaEnLista.Nombre, CuentaEnLista.Direccion, CuentaEnLista.Servicio);
            }
        }

        /// <summary>
        /// Método DGVVerDatosCuenta_Click.
        /// Permite visualizar información de una cuenta en específico que ha sido seleccionada de una fila del
        /// dataGridView presente en el formulario.
        /// </summary>
        public void DGVVerDatosCuenta_Click(object pSender, DataGridViewCellEventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            string iNombreCuenta = dataGridViewDatosCuentas.Rows[pEvento.RowIndex].Cells["Nombre"].Value.ToString();
            CuentaDTO iCuenta = iControladorC.BuscarCuenta(iNombreCuenta);
            textBoxNombre.Text = iCuenta.Nombre;
            textBoxDireccion.Text = iCuenta.Direccion;
            textBoxServicio.Text = iCuenta.Servicio;
            textBoxContraseña.Text = iCuenta.Contraseña;
        }

        /// <summary>
        /// Método MostrarContraseña_Click.
        /// Permite visualizar la contraseña de una cuenta en particular.
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
        /// Método BuscarCuenta_Click.
        /// Permite buscar una cuenta por su nombre o parte de él.
        /// En el caso de que exista devuelve la o las cuentas buscadas.
        /// </summary>
        public void BuscarCuenta_Click(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            if (textBoxBuscador.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre para realizar la búsqueda de la cuenta", "Campo vacío");
            }
            else if (iControladorC.BuscarCuenta(textBoxBuscador.Text) == null)
            {
                MessageBox.Show("El nombre de la cuenta no existe. Ingrese otro nombre e intente nuevamente", "No se encontraron coincidencias");
            }
            else
            {
                dataGridViewDatosCuentas.Rows.Clear();
                List<CuentaDTO> iCuentasEncontradas = iControladorC.BuscarCuentas(textBoxBuscador.Text);
                foreach (CuentaDTO Cuenta in iCuentasEncontradas)
                {
                    dataGridViewDatosCuentas.Rows.Add(Cuenta.Nombre, Cuenta.Direccion, Cuenta.Servicio);
                }
            }
            
        }

        /// <summary>
        /// Método CerrarVerCuentas_Click.
        /// Cierra el formulario VerCuentas.
        /// </summary>
        public void CerrarVerCuentas_Click(object pSender, EventArgs pEvento)
        {
            this.Close();
            this.Dispose();
        }
    }
}
