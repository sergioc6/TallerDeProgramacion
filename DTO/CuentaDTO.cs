using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CuentaDTO
    {
        private string iNombre;
        private string iID;
        private string iDireccion;
        private string iServicio;
        private string iContraseña;


        CuentaDTO(string pNombre, string pID, string pDireccion, string pServicio, string pContraseña)
        {
            this.iNombre = pNombre;
            this.iID = pID;
            this.iDireccion = pDireccion;
            this.iServicio = pServicio;
            this.iContraseña = pContraseña;
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public string ID
        {
            get { return this.iID; }
            set { this.iID = value; }
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
    }
}
