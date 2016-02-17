using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Controladores;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    /// <summary>
    /// Formulario AgregarCuenta.
    /// Permite crear cuentas y guardarlas en la base de datos.
    /// </summary>
    public partial class AgregarCuenta : Form
    {
        /// <summary>
        /// Al inicializar, la venta carga en el comboBox todos los servicios que se pueden manipular
        /// </summary>
        public AgregarCuenta()
        {
            InitializeComponent();
            comboBoxServicio.Items.Add("Gmail");
            comboBoxServicio.Items.Add("Yahoo");
            comboBoxServicio.Items.Add("Otro");
        }

        /// <summary>
        /// Método AgregarCuenta_Click.
        /// Permite agregar una cuenta a la base de datos.
        /// </summary>
        public void AgregarCuenta_Click(object pSender, EventArgs pEvento)
        {
            if (Validar() == true)
            {
                MessageBox.Show("Verifique que existen campos incompletos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ControladorCuenta iControladorC = ControladorCuenta.Instancia;
                string iNombreCuenta = textBoxNombreCuenta.Text;
                string iDireccion = textBoxDireccionCuenta.Text;
                bool iMailValido = ValidarMail(iDireccion);
                bool iNombreValido = ValidarCuenta(iNombreCuenta);
                bool iNombreValido2 = ValidarCuentaEnTodas(textBoxNombreCuenta.Text);
                if (iNombreValido == false)
                {
                    MessageBox.Show("El nombre de cuenta ya existe. Utilice un nombre diferente", "Nombre de cuenta existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (iNombreValido2 == false)
                {
                    DialogResult iResultado = MessageBox.Show("La cuenta se encuentra inactiva. ¿Desea reactivar la cuenta?", "Cuenta inactiva", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (iResultado == DialogResult.OK)
                    {
                        iControladorC.ReactivarCuenta(iNombreCuenta);
                        MessageBox.Show("La cuenta ha sido reactivada.", "Cuenta reactivada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (iMailValido == false)
                {
                    MessageBox.Show("El formato del mail es inválido. Escríbalo nuevamente", "Mail inválido", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    CuentaDTO iNuevaCuenta = new CuentaDTO(iNombreCuenta, iDireccion, comboBoxServicio.SelectedItem.ToString(), textBoxContraseña.Text, true);
                    iControladorC.CrearCuenta(iNuevaCuenta);
                    MessageBox.Show("La cuenta se ha agregado con éxito", "¡Cuenta agregada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        /// <summary>
        /// Método ValidarMail.
        /// Valida si el mail que estamos ingresando, está ingresado correctamente.
        /// </summary>
        /// <param name="pInputEmail">Expresión a validar</param>
        /// <returns>True en el caso de que sea válido sintácticamente, false en caso contrario</returns>
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
        /// Método Validar.
        /// Controla que los campos necesarios estén correctamente llenados.
        /// </summary>
        /// <returns>True si están todos los campos correctamente llenados, false en caso contrario</returns>
        public bool Validar()
        {
            bool iVacio = false; // se inicializa la variable "vacio" con el valor false

            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls.Enabled == true) //revisión de que los textBox a controlar solo sean los activos
                {
                    if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                    {
                        iVacio = true; //Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                    }
                }
            }
            return iVacio;
        }


        /// <summary>
        /// Método MostrarContraseña_Click.
        /// Permite mostrar la contraseña ingresada.
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
        /// Método CerrarAgregarCuenta_Click.
        /// Permite cerrar la ventana de AgregarCuenta y eliminar su carga de la memoria.
        /// </summary>
        public void CerrarAgregarCuenta_Click(object pSender, EventArgs pEvento)
        {
            this.Close();
            this.Dispose();
        }

    }
}
