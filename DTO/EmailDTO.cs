using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DTO
{
    public class EmailDTO
    {
        private string iIDMensaje; // ID único que identifica al mail que estamos descargando
        private int iIDMail; // ID único que identifica el Email que estamos mandando
        private int iCuenta; // Nombre de la cuenta que está enviando el mail
        private string iEstado; // Si está leído o no
        private string iRemitente; // Quién envía el mail
        private List<String> iDestinatario; // A quién enviamos el mail
        private string iAsunto; // La razón por la que estamos enviando el mail
        private string iCuerpo; // Texto principal del correo
        private string iFecha; // La fecha en que estamos enviando el correo. Se utilizará DateTime para obtener la fecha actual
        private bool iActivo;
        private List<String> iCC; // Lista que contiene las direcciones a quienes enviamos la copia de carbón
        private List<String> iCCO; // Lista que contiene las direcciones a quienes enviamos la copia oculta
        private string iLeido;

        // Constructores de la clase EmialDTO
        public EmailDTO(int pCuenta, string pEstado, string pRemitente, List<String> pDestinatario, string pAsunto, string pCuerpo, string pFecha, bool pActivo, List<String> pCC, List<String> pCCO)
        {
            this.iCuenta = pCuenta;
            this.iEstado = pEstado;
            this.iRemitente = pRemitente;
            this.iDestinatario = pDestinatario;
            this.iAsunto = pAsunto;
            this.iCuerpo = pCuerpo;
            this.iFecha = pFecha;
            this.iActivo = pActivo;
            this.iCC = pCC;
            this.iCCO = pCCO;
        }

        public EmailDTO(string pEstado, string pRemitente, List<String> pDestinatario, string pAsunto, string pCuerpo, string pFecha, bool pActivo, List<String> pCC, List<String> pCCO)
        {
            this.iEstado = pEstado;
            this.iRemitente = pRemitente;
            this.iDestinatario = pDestinatario;
            this.iAsunto = pAsunto;
            this.iCuerpo = pCuerpo;
            this.iFecha = pFecha;
            this.iActivo = pActivo;
            this.iCC = pCC;
            this.iCCO = pCCO;
        }


        public EmailDTO(int pIDMail, int pCuenta, string pEstado, string pRemitente, List<String> pDestinatario, string pAsunto, string pCuerpo, string pFecha, bool pActivo, List<String> pCC, List<String> pCCO, string pIDMensaje, string pLeido)
        {
            this.iIDMail = pIDMail;
            this.iCuenta = pCuenta;
            this.iEstado = pEstado;
            this.iRemitente = pRemitente;
            this.iDestinatario = pDestinatario;
            this.iAsunto = pAsunto;
            this.iCuerpo = pCuerpo;
            this.iFecha = pFecha;
            this.iActivo = pActivo;
            this.iCC = pCC;
            this.iCCO = pCCO;
            
            this.iIDMensaje = pIDMensaje;
            this.iLeido = pLeido;
        }

        public EmailDTO(int pCuenta, string pEstado, string pRemitente, List<String> pDestinatario, string pAsunto, string pCuerpo, string pFecha, bool pActivo, List<String> pCC, List<String> pCCO, string pIDMensaje, string pLeido)
        {
            this.iCuenta = pCuenta;
            this.iEstado = pEstado;
            this.iRemitente = pRemitente;
            this.iDestinatario = pDestinatario;
            this.iAsunto = pAsunto;
            this.iCuerpo = pCuerpo;
            this.iFecha = pFecha;
            this.iActivo = pActivo;
            this.iCC = pCC;
            this.iCCO = pCCO;
            this.iIDMensaje = pIDMensaje;
            this.iLeido = pLeido;
        }


        // Propiedades de EmailDTO
        public string Leido
        {
            get { return this.iLeido; }
            set { this.iLeido = value; }
        }

        public string IDMensaje
        {
            get { return this.iIDMensaje; }
            set { this.iIDMensaje = value; }
        }

        public int IDCorreo
        {
            get { return this.iIDMail; }
            set { this.iIDMail = value; }
        }

        public int Cuenta
        {
            get { return this.iCuenta; }
            set { this.iCuenta = value; }
        }

        public string Estado
        {
            get { return this.iEstado; }
            set { this.iEstado = value; }
        }

        public string Remitente
        {
            get { return this.iRemitente; }
            set { this.iRemitente = value; }
        }

        public List<String> Destinatario
        {
            get { return this.iDestinatario; }
            set { this.iDestinatario = value; }
        }

        public List<String> ConCopia
        {
            get { return this.iCC; }
            set { this.iCC = value; }
        }

        public List<String> ConCopiaOculta
        {
            get { return this.iCCO; }
            set { this.iCCO = value; }
        }

        public string Asunto
        {
            get { return this.iAsunto; }
            set { this.iAsunto = value; }
        }

        public string Cuerpo
        {
            get { return this.iCuerpo; }
            set { this.iCuerpo = value; }
        }

        public string Fecha
        {
            get { return this.iFecha; }
            set { this.iFecha = value; }
        }

        public bool Activo
        {
            get { return this.iActivo; }
            set { this.iActivo = value; }
        }

    }
}
