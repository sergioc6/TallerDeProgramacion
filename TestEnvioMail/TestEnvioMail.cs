using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using Persistencia;
using DTO;
using Npgsql;

namespace TestEnvioMail
{
    [TestClass]
    public class TestEnvioMail
    {
        private DAOFactory DAO;
        private EmailDTO iEmail;
        private CuentaDTO iCuenta;
        private string iFecha = DateTime.Now.ToString();

        [TestMethod]
        public void EnviarMailPrueba()
        {
            SmtpClient iCliente = new SmtpClient();
            iCliente.Port = 587;
            iCliente.Host = "smtp.gmail.com";
            iCliente.EnableSsl = true;
            iCliente.Timeout = 10000;
            iCliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            iCliente.UseDefaultCredentials = false;
            iCliente.Credentials = new System.Net.NetworkCredential("educmack@gmail.com", "AlexanderAnderson");
            MailMessage iMensaje = new MailMessage("educmack@gmail.com", "testtallerprog@gmail.com", "Prueba", "Te mando un cosito");
            iCliente.Send(iMensaje);
            List<String> iDestinatarios = new List<String>();
            List<String> iCCO = new List<String>();
            List<String> iCC = new List<String>();
            iDestinatarios.Add("testtallerprog@gmail.com");
            iDestinatarios.Add("santi.zac.33@gmail.com");
            iEmail = new EmailDTO(1 ,"enviado", "educmack@gmail.com", iDestinatarios, "Prueba", "Te mando un cosito", iFecha, true, iCC, iCCO);
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            DAO.MailDAO().Insertar(iEmail);
            DAO.Commit();
        }

        
        [TestMethod]
        public void GuardarCuenta()
        {
            iCuenta = new CuentaDTO("Taller", "testtallerprog@gmail.com", "Gmail", "diplomatic", true);
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            DAO.CuentaDAO().Insertar(iCuenta);
            DAO.Commit();  
        }

        [TestMethod]
        public void EliminarMail()
        {
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            DAO.MailDAO().Eliminar(1);
            DAO.Commit();
        }

          [TestMethod]
        public void ModificarCuenta()
        {
            iCuenta = new CuentaDTO("Nahuel Pacheco", "educmack@gmail.com", "Gmail", "Machupichu", true);
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            DAO.CuentaDAO().Modificar(1, iCuenta);
            DAO.Commit();
        }

        [TestMethod]
        public void MarcarLeidoMail()
        {
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            DAO.MailDAO().MarcarLeido(1);
            DAO.Commit();
        }

        [TestMethod]
        public void ObtenerMail()
        {
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            List<EmailDTO> email = new List<EmailDTO>();
            email = DAO.MailDAO().Obtener(1);
        }

        [TestMethod]
        public void BuscarCuenta()
        {
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            CuentaDTO cuenta = DAO.CuentaDAO().BuscarCuenta("Nahuel Pacheco");

        }


        [TestMethod]
        public void ObtenerCuentas()
        {
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            List<CuentaDTO> cuenta = new List<CuentaDTO>();
            cuenta = DAO.CuentaDAO().Obtener();
        }

        [TestMethod]
        public void EliminarCuenta()
        {
            DAO = DAOFactory.Instancia();
            DAO.IniciarConexion();
            DAO.ComenzarTransaccion();
            DAO.CuentaDAO().Eliminar("Nahuel Leiva");
            DAO.Commit();
        }
    }
}
