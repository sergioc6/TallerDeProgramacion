using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using OpenPop.Pop3;
using Persistencia;
using ServiciosCorreo;
using System.Net.Mail;

namespace Controladores
{
    /// <summary>
    /// Clase singleton ControladorEmail. Posee métodos para manipular los mails y persistirlos en la base de datos
    /// </summary>
    public class ControladorEmail
    {
        private DAOFactory iFactory;
        private static ControladorEmail iInstanciaControlador = null;

        /// <summary>
        /// Método singleton Instancia.
        /// Devuelve solo una instancia del objeto ControladorEmail.
        /// </summary>
        public static ControladorEmail Instancia
        {
            get
            {
                if (iInstanciaControlador == null)
                {
                    iInstanciaControlador = new ControladorEmail();
                }
                return iInstanciaControlador;
            }
        }

        /// <summary>
        /// Método EnviarEmail.
        /// Permite enviar un email desde de una cuenta de correo específica.
        /// </summary>
        /// <param name="pEmail">Email que se guardará en la base de datos</param>
        /// <param name="pCuenta">Cuenta desde la cual enviamos el mail</param>
        /// <param name="pMensaje">Objeto tipo MailMessage para armar el mensaje a enviar</param>
        public void EnviarEmail(EmailDTO pEmail, CuentaDTO pCuenta, MailMessage pMensaje)
        {

            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                FactoryServicios.Instancia.Servicio(pCuenta.Servicio).EnviarCorreo(pCuenta, pMensaje);
                if (pEmail.IDMensaje == null)
                {
                    pEmail.IDMensaje = "";
                }
                if (pEmail.Leido == null)
                {
                    pEmail.Leido = "Leído";
                }
                iFactory.MailDAO().Insertar(pEmail);
                iFactory.Commit();
            }
            catch (Exception ex)
            {
                iFactory.RollBack();
                throw new Exception(ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método GuardarCorreo.
        /// El método permite guardar los emails en la base de datos y persistirlos.
        /// </summary>
        /// <param name="pEmail">Email que vamos a persistir en la base de datos</param>
        public void GuardarCorreo(EmailDTO pEmail)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iFactory.MailDAO().Insertar(pEmail);
                iFactory.Commit();
            }
            catch (Exception ex)
            {
                iFactory.RollBack();
                throw new Exception(ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método DescargarCorreos.
        /// El método permite descargar los correos de la bandeja de una cuena específica.
        /// </summary>
        /// <param name="pCuenta">Cuenta de la cual vamos a descargar los correos</param>
        public void DescargarCorreos(CuentaDTO pCuenta)
        {
            List<EmailDTO> CorreosDescargados = FactoryServicios.Instancia.Servicio(pCuenta.Servicio).DescargarCorreos(pCuenta);
            foreach (EmailDTO pEmailDescargado in CorreosDescargados)
            {
                // Si el correo ya existe, no lo guarda
                // En caso contrario, lo guardará sin problema
                if (!ExisteCorreo(pEmailDescargado))
                {
                    GuardarCorreo(pEmailDescargado);
                }
            }



            //// El while sirve para poder seguir circulando en la bandeja de correo de la cuenta especificada
            //// en el caso de que existan mas correos para descargar. Cuando no hay mas correos nuevos para descargar
            //// se sale del ciclo y termina.
            //while (iCorreosGuardados != iCantidadCorreosADescargar)
            //{
            //    pCuenta.CantidadCorreos = pCuenta.CantidadCorreos + 1;
            //    List<EmailDTO> CorreosDescargadosNuevamente = FactoryServicios.Instancia.Servicio(pCuenta.Servicio).DescargarCorreos(pCuenta);
            //    int iCorreosDescargadosNuevamente = CorreosDescargadosNuevamente.Count();
            //    // Pregunta si la cantidad de correos descargado nuevamente es igual a los correos descargados inicialmente.
            //    // En caso que suceda, quiere decir que no hay mas correos para descargar en la bandeja de correo.
            //    if (iCorreosDescargadosNuevamente == iCorreosDescargados)
            //    {
            //        iCorreosGuardados = iCantidadCorreosADescargar;
            //    }
            //    else
            //    {
            //        // En el caso de que todavía no sean iguales, toma el último mail obtenido
            //        // e intenta insertarlo en la base de datos
            //        if (!ExisteCorreo(CorreosDescargadosNuevamente[0]))
            //        {
            //            GuardarCorreo(CorreosDescargadosNuevamente[0]);
            //            iCorreosGuardados++;
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Método ObtenerCorreosPorCuenta.
        /// Permite obtener todos los correos de una cuenta específica.
        /// </summary>
        /// <param name="pCuenta">Cuenta de la cual queremos obtener sus correos</param>
        /// <returns>Lista de todos los emails obtenidos</returns>
        public List<EmailDTO> ObtenerCorreosPorCuenta(CuentaDTO pCuenta)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                List<EmailDTO> iListaCorreosObtenidos = iFactory.MailDAO().Obtener(pCuenta.ID);
                return iListaCorreosObtenidos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }


        }

        /// <summary>
        /// Método ObtenerTodosLosCorreos.
        /// Obtiene todos los correos que están persistidos en la base de datos, de todas las cuentas disponibles.
        /// </summary>
        /// <returns>Lista de todos los correos persistidos en la base de datos</returns>
        public List<EmailDTO> ObtenerTodosLosCorreos()
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                List<EmailDTO> iListaCorreosObtenidos = iFactory.MailDAO().ObtenerTodos();
                return iListaCorreosObtenidos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método ObtenerUnCorreo.
        /// Obtiene un único correo mediante su ID para poder extraer la información necesaria de él.
        /// </summary>
        /// <param name="pIDMail">ID del mail que necesitamos obtener</param>
        /// <returns>Email encontrado</returns>
        public EmailDTO ObtenerUnCorreo(int pIDMail)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                EmailDTO iEmail = iFactory.MailDAO().ObtenerMail(pIDMail);
                return iEmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }

        }

        /// <summary>
        /// Método ExisteCorreo.
        /// El método controla si existen o no los correos en la base de datos.
        /// </summary>
        /// <param name="pEmail">Email que se verifica si existe o no en la base de datos</param>
        /// <returns>TRUE en caso de que exista. FALSE en caso contrario</returns>
        public bool ExisteCorreo(EmailDTO pEmail)
        {
            bool iEncontrado = false;
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iEncontrado = iFactory.MailDAO().ExisteCorreo(pEmail);
                iFactory.Commit();
                return iEncontrado;
            }
            catch (Exception Ex)
            {
                iFactory.RollBack();
                throw new Exception(Ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método MarcarLeido.
        /// Permite marcar como leído un mail.
        /// </summary>
        /// <param name="pIDMail">ID del mail que se marcará como leído.</param>
        public void MarcarLeido(int pIDMail)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iFactory.MailDAO().MarcarLeido(pIDMail);
                iFactory.Commit();
            }
            catch (Exception Ex)
            {
                iFactory.RollBack();
                throw new Exception(Ex.Message);
            }
            finally
            {
                iFactory.FinalizarConexion();
            }
        }

    }
}
