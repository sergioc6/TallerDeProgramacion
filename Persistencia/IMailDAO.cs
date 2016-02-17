using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    public interface IMailDAO
    {
        /// <summary>
        /// Permite insertar un nuevo Email en la base de datos y devuelve su Id
        /// </summary>
        /// <param name="pCuenta"></param>
        void Insertar(EmailDTO pEmail);


        /// <summary>
        /// Permite eliminar un Email de la base de datos
        /// </summary>
        /// <param name="pCuenta"></param>
        void Eliminar(int pIdCorreo);

        /// <summary>
        /// Permite marcar como leido un Email
        /// </summary>
        /// <param name="pIdEmail"></param>
        void MarcarLeido(int pIdEmail);

        /// <summary>
        /// Obtiene todos los Emails correspondiente a una Cuenta de correo
        /// </summary>
        /// <returns></returns>
        List<EmailDTO> Obtener(int pIdCuenta);

        /// <summary>
        /// Obtiene TODOS los mails alojados en la base de datos de todas las cuentas
        /// </summary>
        /// <returns>Lista de emails</returns>
        List<EmailDTO> ObtenerTodos();

        /// <summary>
        /// Obtiene un mail específico a partir de su ID
        /// </summary>
        /// <param name="pIdMail">ID del mail en la base de datos</param>
        /// <returns>Objeto EmailDTO</returns>
        EmailDTO ObtenerMail(int pIdMail);

        /// <summary>
        /// Controla por asunto, fecha y hora del mail si ya esta insertado en la base.
        /// </summary>
        /// <param name="pEmail">Email a comprobar si existe en la base de datos</param>
        /// <returns>TRUE si existe, FALSE en caso contrario</returns>
        bool ExisteCorreo(EmailDTO pEmail);
    }
}
