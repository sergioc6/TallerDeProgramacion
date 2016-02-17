using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using OpenPop;
using Persistencia;
using DTO;
using ServiciosCorreo;
using Npgsql;
using Controladores;
using System.Threading.Tasks;

namespace TestEnvioMail
{
    [TestClass]
    public class TestServiciosCorreo
    {
        //[TestMethod]
        //public void EnviarAGmail()
        //{
        //    DateTime FechaDeHoy = new DateTime();
        //    List<String> ListaDestinatarios = new List<String>();
        //    ListaDestinatarios.Add("sergiocabral.1990@gmail.com");
        //    ListaDestinatarios.Add("santi.zac.33@gmail.com");
        //    List<String> ListaCC = new List<String>();
        //    List<String> ListaCCO = new List<String>();
        //    EmailDTO Email = new EmailDTO(1, "enviado", "educmack@gmail.com", ListaDestinatarios, "Prueba", "Te mando un cosito versión 2, like always papá", FechaDeHoy.ToString(), true, ListaCC, ListaCCO);
        //    CuentaDTO Cuenta = new CuentaDTO("Nahuel Leiva", "educmack@gmail.com", "Gmail", "AlexanderAnderson", true);
        //    Gmail CorreoGmail = new Gmail();
        //    CorreoGmail.EnviarCorreo(Email, Cuenta);
        //}

        //[TestMethod]
        //public void EnviarAYahoo()
        //{
        //    string fechaDeHoy = DateTime.Today.ToString();
        //    List<String> ListaDestinatarios = new List<String>();
        //    ListaDestinatarios.Add("sergiocabral90@yahoo.com");
        //    List<String> ListaCC = new List<String>();
        //    List<String> ListaCCO = new List<String>();
        //    EmailDTO Email = new EmailDTO(1, "enviado", "markova24@yahoo.com", ListaDestinatarios, "Prueba", "Te mando un cosito versión 2, like always papá", fechaDeHoy, true, ListaCC, ListaCCO);
        //    CuentaDTO Cuenta = new CuentaDTO("Nahuel Leiva", "markova24@yahoo.com", "Yahoo", "AlexanderAnderson", true);
        //    Yahoo CorreoYahoo = new Yahoo();
        //    CorreoYahoo.EnviarCorreo(Email, Cuenta);
        //}

        [TestMethod]
        public void ObtenerCorreosGmail()
        {
            ControladorCuenta ControladorCuenta = ControladorCuenta.Instancia;
            Gmail CuentaGmail = new Gmail();
            List<EmailDTO> iListaGMAIL = new List<EmailDTO>();
            CuentaDTO Cuenta = ControladorCuenta.BuscarCuenta("Taller");
            iListaGMAIL = CuentaGmail.DescargarCorreos(Cuenta);

            ControladorEmail ControladorEmail = ControladorEmail.Instancia;
            for (int i = 0; i <= iListaGMAIL.Count - 1; i++)
            {
                ControladorEmail.GuardarCorreo(iListaGMAIL[i]);
            }
        }


        [TestMethod]
        public void ObtenerCorreosYahoo()
        {
            ControladorCuenta ControladorCuenta = ControladorCuenta.Instancia;
            Yahoo CuentaYahoo = new Yahoo();
            List<EmailDTO> iListaYAHOO = new List<EmailDTO>();
            CuentaDTO Cuenta = ControladorCuenta.BuscarCuenta("Nahuel Leiva Yahoo");
            iListaYAHOO = CuentaYahoo.DescargarCorreos(Cuenta);
            
            ControladorEmail ControladorEmail = ControladorEmail.Instancia;
            //for (int i = 0; i <= iListaYAHOO.Count - 1; i++)
            //{
            //    ControladorEmail.GuardarCorreo(iListaYAHOO[i]);
            //}
        }
    
    }
}
