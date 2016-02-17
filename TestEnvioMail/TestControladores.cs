using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using Persistencia;
using Controladores;
using System.Threading.Tasks;

namespace TestEnvioMail
{
    [TestClass]
    public class TestControladores
    {
        
        [TestMethod]
        public void AgregarCuenta()
        {
            ControladorCuenta Controlador = ControladorCuenta.Instancia;
            CuentaDTO Cuenta = new CuentaDTO("Sergio Dennis", "cualquiercosa@tuvieja.com", "tuvieja", "LACONCHADETUMADREALLBOYS", true);
            Controlador.CrearCuenta(Cuenta);
        }

        [TestMethod]
        public void ObtenerCuenta()
        {
            ControladorCuenta Controlador = ControladorCuenta.Instancia;
            List<CuentaDTO> ListaCuentas = Controlador.ObtenerCuenta();
        }

        [TestMethod]
        public void BuscarCuenta()
        {
            string NombreCuenta = "Sergio Dennis";
            ControladorCuenta Controlador = ControladorCuenta.Instancia;
            CuentaDTO Cuenta = Controlador.BuscarCuenta(NombreCuenta);
        }

        [TestMethod]
        public void ModificarCuenta()
        {
            CuentaDTO CuentaAModificar = new CuentaDTO("Sergio Cabral", "sergiocabral.1990@gmail.com", "Gmail", "cacaconchoclo", true);
            ControladorCuenta Controlador = ControladorCuenta.Instancia;
            Controlador.ModificarCuenta(2, CuentaAModificar);
        }

        [TestMethod]
        public void EliminarCuenta()
        {
            string NombreCuentaAEliminar = "Nahuel Leiva";
            ControladorCuenta Controlador = ControladorCuenta.Instancia;
            Controlador.EliminarCuenta(NombreCuentaAEliminar);
        }


        //[TestMethod]
        //public void EnviarMail()
        //{
        //    ControladorEmail Controlador = ControladorEmail.Instancia;
        //    List<String> Destinatarios = new List<String>();
        //    List<String> CC = new List<String>();
        //    List<String> CCO = new List<String>();
        //    Destinatarios.Add("santi.zac.33@gmail.com");
        //    CC.Add("educmack@gmail.com");
        //    CuentaDTO Cuenta = new CuentaDTO("Sergio Cabral", "sergiocabral.1990@gmail.com", "Gmail", "puertonuevo", true);
        //    EmailDTO Email = new EmailDTO(1, "Enviado", "sergiocabral.1990@gmail.com", Destinatarios, "Prueba", "LALALALALA", DateTime.Today.ToString(), true, CC, CCO);
        //    Controlador.EnviarEmail(Email, Cuenta);
        //}

        [TestMethod]
        public void GuardarCorreosDescargados()
        {
            ControladorEmail ControladorEmail = ControladorEmail.Instancia;
            ControladorCuenta ControladorCuenta = ControladorCuenta.Instancia;
            ControladorEmail.DescargarCorreos(ControladorCuenta.BuscarCuenta("Nahuel Leiva Yahoo"));
        }
    }
}
