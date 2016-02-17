using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.IO;
using System.Threading.Tasks;

namespace Exportadores
{
    /// <summary>
    /// Clase pública ExportadorTextoPlano.
    /// Clase que permite exportar a EML los mails que deseamos guardar.
    /// </summary>
    public class ExportadorTextoPlano : AbstractExportador
    {
        // Constructor de la clase ExportadorEML
        public ExportadorTextoPlano() : base("TXT") { }

        /// <summary>
        /// Método Exportar.
        /// Permite exportar a TXT un mail específico que hayamos elegido.
        /// </summary>
        /// <param name="pEmail">Email a exportar</param>
        /// <param name="pRuta">Ruta donde guardaremos el archivo</param>
        /// <param name="pNombre">Nombre que le daremos al archivo a exportar</param>
        public override void Exportar(EmailDTO pEmail, string pRuta, string pNombre)
        {
            string iDestinatarios = ""; // Cadena que contendrá todas las direcciones de los destinatarios del mail
            
            foreach (string Destinatario in pEmail.Destinatario)
            {
                iDestinatarios = iDestinatarios + Destinatario + ", "; // Construimos la cadena con las direcciones de los destinatarios
            }

            // Construimos el texto principal del archivo con todos los datos del mail que vamos a exportar
            string[] iTextoPlanoAExportar = {"De: <" + pEmail.Remitente + ">", "Para: <" + iDestinatarios + ">",
                                            "Asunto: " + pEmail.Asunto, "Fecha y hora: " + pEmail.Fecha, "Adjuntos: " + "------------------------------------------", "Cuerpo: " + pEmail.Cuerpo};
            try
            {
                File.WriteAllLines(pRuta + "\\" + pNombre, iTextoPlanoAExportar); // Una vez que tenemos construido todo, trataremos de guardarlo en un archivo. Caso contrario, lanzará las debidas excepciones
            }
            catch (FormatException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. Hubo un problema con el formato del correo a exportar o con la ruta de la carpeta elegida. Eliga una nueva ruta o revise el correo y vuelva a intentarlo.");
            }
            catch (PathTooLongException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. La ruta para guardar el archivo es demasiado larga. Revise la ruta e intente nuevamente");
            }
            catch (IOException)
            {
                throw new ExportadoresException("No se pudo exportar su correo. Hubo un problema al guardar el archivo. Elija otra carpeta e intente nuevamente");
            }
            catch (Exception ex)
            {
                throw new ExportadoresException("No se pudo exportar su correo");
            }
        }
    }
}
