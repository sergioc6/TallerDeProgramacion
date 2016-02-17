using Controladores;
using DTO;
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
    /// Formulario ModificarCuenta.
    /// Permite la manipulación de las cuentas disponibles en MailApp para modificar los datos necesarios de éstas.
    /// </summary>
    public partial class ModificarCuenta : Form
    {
        /// <summary>
        /// Constructor de la clase ModificarCuenta.
        /// </summary>
        public ModificarCuenta()
        {
            InitializeComponent();
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            List<CuentaDTO> iListaCorreosBD = new List<CuentaDTO>();
            iListaCorreosBD = iControladorC.ObtenerCuenta();
            comboBoxServicios.Items.Add("Gmail");
            comboBoxServicios.Items.Add("Yahoo");
            comboBoxServicios.Items.Add("Hotmail");
            comboBoxServicios.Items.Add("Otros");
            foreach (CuentaDTO CuentaEnLista in iListaCorreosBD)
            {
                dataGridViewDatosCuentas.Rows.Add(CuentaEnLista.Nombre, CuentaEnLista.Direccion, CuentaEnLista.Servicio);
            }
        }

        /// <summary>
        /// Método DGVVerDatosCuenta_Click.
        /// Permite ver los datos de una cuenta seleccionado la fila correspondiente en el dataGridView presente
        /// en el formulario.
        /// </summary>
        public void DGVVerDatosCuenta_Click(object pSender, DataGridViewCellEventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            string iNombreCuenta = dataGridViewDatosCuentas.Rows[pEvento.RowIndex].Cells["Nombre"].Value.ToString();
            CuentaDTO iCuenta = iControladorC.BuscarCuenta(iNombreCuenta);
            textBoxNombre.Text = iCuenta.Nombre;
            textBoxDireccion.Text = iCuenta.Direccion;
            comboBoxServicios.SelectedItem = iCuenta.Servicio;
            textBoxContraseña.Text = iCuenta.Contraseña;
        }

        /// <summary>
        /// Método ConfirmarCambios_Click.
        /// Permite confirmar los cambios de una cuenta en particular y persistirlos en la base de datos.
        /// </summary>
        public void ConfirmarCambios_Click(object pSender, EventArgs pEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            CuentaDTO iCuentaAModificar = iControladorC.BuscarCuenta(dataGridViewDatosCuentas.CurrentRow.Cells[0].Value.ToString());
            CuentaDTO iCuentaNueva = new CuentaDTO(textBoxNombre.Text, textBoxDireccion.Text, comboBoxServicios.SelectedItem.ToString(), textBoxContraseña.Text, true);
            bool iNombreValido = ValidarCuenta(iCuentaNueva.Nombre);
            bool iNombreValido2 = ValidarCuentaEnTodas(iCuentaNueva.Nombre);
            DialogResult iConfirmar = MessageBox.Show("¿Está seguro que desea modificar los datos de la cuenta?", "Confirmar cambios", MessageBoxButtons.YesNo);

            if (iConfirmar == DialogResult.Yes)
            {
                if (iNombreValido == false)
                {
                    MessageBox.Show("El nombre de la cuenta ya existe. Por favor elija uno distinto e intente nuevamente", "Nombre de cuenta existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (iNombreValido2 == false)
                {
                    MessageBox.Show("El nombre de la cuenta ya existe y corresponde a una cuenta inactiva. Por favor elija uno distinto e intente nuevamente", "Nombre de cuenta existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    iControladorC.ModificarCuenta(iCuentaAModificar.ID, iCuentaNueva);
                    MessageBox.Show("La operación se llevó a cabo con éxito", "Cuenta modificada");
                }
            }
        }

        /// <summary>
        /// Método ValidarCuenta.
        /// El método controla si el nombre de cuenta que estamos ingresando existe o no en la base de datos.
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de cuenta a controlar</param>
        /// <returns>True si ya existe, false en caso contrario</returns>
        public bool ValidarCuenta(string pNombreCuenta)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            CuentaDTO iCuenta = iControladorC.BuscarCuenta(pNombreCuenta);
            if (iCuenta == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Método ValidarCuentaEnTodas.
        /// El método controla el nombre de la cuenta que se va a agregar.
        /// Si el nombre existe, pero corresponde a una cuenta inactiva, entonces devolverá true.
        /// False en caso contrario.
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de la cuenta que se quiere validar</param>
        /// <returns>TRUE si encuentra coincidencias. FALSE en caso contrario</returns>
        public bool ValidarCuentaEnTodas(string pNombreCuenta)
        {
            bool iValidacion = true;
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            List<CuentaDTO> iCuentas = iControladorC.BuscarTodasLasCuentas(pNombreCuenta);
            foreach (CuentaDTO Cuenta in iCuentas)
            {
                if (Cuenta.Nombre == pNombreCuenta && Cuenta.Activo == false)
                {
                    iValidacion = false;
                }
            }
            return iValidacion;
        }



        /// <summary>
        /// Método BuscarCuenta_Click.
        /// Permite buscar una cuenta en particular para realizar los cambios en sus datos que sean necesarios.
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
                List<CuentaDTO> iListaCuentasEncontradas = iControladorC.BuscarCuentas(textBoxBuscador.Text);
                dataGridViewDatosCuentas.Rows.Clear();
                foreach (CuentaDTO Cuenta in iListaCuentasEncontradas)
                {
                    dataGridViewDatosCuentas.Rows.Add(Cuenta.Nombre, Cuenta.Direccion, Cuenta.Servicio);
                }
                dataGridViewDatosCuentas.Sort(this.dataGridViewDatosCuentas.Columns["Nombre"], ListSortDirection.Ascending);
            }
            
        }

        /// <summary>
        /// Método CerrarModificarCuenta_Click.
        /// Cierra el formulario de ModificarCuenta.
        /// </summary>
        public void CerrarModificarCuenta_Click(object pSender, EventArgs pEvento)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Método MostrarContraseña_Click.
        /// Muestra la contraseña de alguna cuenta en particular.
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


    }
}
