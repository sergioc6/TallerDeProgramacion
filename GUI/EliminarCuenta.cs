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
    /// Formulario EliminarCuenta.
    /// Permite eliminar una cuenta específica seleccionada por el usuario.
    /// </summary>
    public partial class EliminarCuenta : Form
    {
        /// <summary>
        /// Constructur de la clase EliminarCuenta.
        /// </summary>
        public EliminarCuenta()
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
        /// Método EliminarCuenta_Click.
        /// Permite eliminar de la base de datos una cuenta específica seleccionada por el usuario en el dataGridView presente
        /// en el formulario.
        /// </summary>
        public void EliminarCuenta_Click(object pSender, EventArgs pOtroEvento)
        {
            ControladorCuenta iControladorC = ControladorCuenta.Instancia;
            string iNombreCuentaEliminar = dataGridViewDatosCuentas.CurrentRow.Cells[0].Value.ToString();
            DialogResult iConfirmar = MessageBox.Show("¿Está seguro que desea eliminar la cuenta", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (iConfirmar == DialogResult.Yes)
            {
                iControladorC.EliminarCuenta(iNombreCuentaEliminar);
                dataGridViewDatosCuentas.Rows.Remove(dataGridViewDatosCuentas.CurrentRow);
                MessageBox.Show("La operación se llevó a cabo con éxito", "Cuenta eliminada");
            }
        }

        /// <summary>
        /// Método BuscarCuenta_Click.
        /// Permite buscar una cuenta o varias cuentas en particular ingresando el nombre completo o parte del él en el
        /// textBox presente en el formulario.
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
                    dataGridViewDatosCuentas.Rows.Add(Cuenta.Nombre, Cuenta.Direccion, Cuenta.Servicio, Cuenta.CantidadCorreos);
                }
                dataGridViewDatosCuentas.Sort(this.dataGridViewDatosCuentas.Columns["Nombre"], ListSortDirection.Ascending);
            }
        }

        /// <summary>
        /// Método CerrarEliminarCuenta.
        /// Cierra el formulario EliminarCuenta.
        /// </summary>
        public void CerrarEliminarCuenta(object pSender, EventArgs pEvento)
        {
            this.Close();
            this.Dispose();
        }
    }
}
