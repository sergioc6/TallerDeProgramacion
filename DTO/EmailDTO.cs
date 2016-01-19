using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class EmailDTO
    {
        private string iIDCorreo;
        private string iEstado;
        private string iRemitente;
        private string iDestinatario;
        private string iAsunto;
        private string iCuerpo;
        private string iFecha;

        EmailDTO(string pIDCorreo, string pEstado, string pRemitente, string pDestinatario, string pAsunto, string pCuerpo, string pFecha)
        {
            this.iIDCorreo = pIDCorreo;
            this.iEstado = pEstado;
            this.iRemitente = pRemitente;
            this.iDestinatario = pDestinatario;
            this.iAsunto = pAsunto;
            this.iCuerpo = pCuerpo;
            this.iFecha = pFecha;
        }
        public string IDCorreo
        {
            get { return this.iIDCorreo; }
            set { this.iIDCorreo = value; }
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

        public string Destinatario
        {
            get { return this.iDestinatario; }
            set { this.iDestinatario = value; }
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
    }
}
