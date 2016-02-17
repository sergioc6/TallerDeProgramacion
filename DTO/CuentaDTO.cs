using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Clase pública CuentaDTO.
    /// La clase permite manipular las cuentas de email que vamos a utilizar para poder descargar o enviar mails
    /// </summary>
    public class CuentaDTO
    {
        private int iIDCuenta; // ID de la cuenta que utilizamos
        private string iNombre; // Nombre de la cuenta. El nombre es unívoco
        private string iDireccion; // Dirección de correo de la cuenta
        private string iServicio; // Servicio de la cuenta {Yahoo, Gmail, Hotmail/Live, etc.}
        private string iContraseña; // Contraseña de la cuenta de correo
        private bool iActivo; // True si la cuenta está activa, false en caso contrario
        private int iCantidadCorreos; // Cantidad de correos máximo que vamos a descargar


        // Constructores de la clase CuentaDTO
        public CuentaDTO(string pNombre, string pDireccion, string pServicio, string pContraseña, bool pActivo)
        {
            this.iNombre = pNombre;
            this.iDireccion = pDireccion;
            this.iServicio = pServicio;
            this.iContraseña = pContraseña;
            this.iActivo = pActivo;
        }

        public CuentaDTO(int pIDCuenta, string pNombre, string pDireccion, string pServicio, string pContraseña, bool pActivo)
        {
            this.iIDCuenta = pIDCuenta;
            this.iNombre = pNombre;
            this.iDireccion = pDireccion;
            this.iServicio = pServicio;
            this.iContraseña = pContraseña;
            this.iActivo = pActivo;
        }

        public CuentaDTO(int pIDCuenta, string pNombre, string pDireccion, string pServicio, string pContraseña, bool pActivo, int pCantidadCorreos)
        {
            this.iIDCuenta = pIDCuenta;
            this.iNombre = pNombre;
            this.iDireccion = pDireccion;
            this.iServicio = pServicio;
            this.iContraseña = pContraseña;
            this.iActivo = pActivo;
            this.iCantidadCorreos = pCantidadCorreos;
        }

        // Propiedades de CuentaDTO
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public int ID
        {
            get { return this.iIDCuenta; }
            set { this.iIDCuenta = value; }
        }

        public string Direccion
        {
            get { return this.iDireccion; }
            set { this.iDireccion = value; }
        }

        public string Servicio
        {
            get { return this.iServicio; }
            set { this.iServicio = value; }
        }

        public string Contraseña
        {
            get { return this.iContraseña; }
            set { this.iContraseña = value; }
        }

        public bool Activo
        {
            get { return this.iActivo; }
            set { this.iActivo = value; }
        }

        public int CantidadCorreos
        {
            get { return this.iCantidadCorreos; }
            set { this.iCantidadCorreos = value; }
        }
    }
}
