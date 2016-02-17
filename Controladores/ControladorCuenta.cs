using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using Persistencia;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    /// <summary>
    /// Clase singleton ControladorCuenta. Posee métodos para manejar las cuentas y persistirla en la base de datos
    /// </summary>
    public class ControladorCuenta
    {
        DAOFactory iFactory; // Variable que utiliza el patrón factory para las variables DAO

        private static ControladorCuenta iInstanciaControlador = null; // Variable para almacenar una sola instancia del ControladorCuenta

        /// <summary>
        /// Propiedad Instancia.
        /// Si no hay una instancia del ControladorCuenta, crea una única de ella para realizar las operaciones referidas a las cuentas
        /// </summary>
        public static ControladorCuenta Instancia
        {
            get
            {
                if (iInstanciaControlador == null)
                {
                    iInstanciaControlador = new ControladorCuenta();
                }
                return iInstanciaControlador;
            }
        }

        /// <summary>
        /// Método CrearCuenta.
        /// Inserta una nueva cuenta en la base de datos intentando realizar la conexión con la misma.
        /// En caso contrario, realiza un rollback y por último una vez realizada la transacción
        /// cierra la conexión.
        /// </summary>
        /// <param name="pCuenta">Cuenta a insertar</param>
        public void CrearCuenta(CuentaDTO pCuenta)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iFactory.CuentaDAO().Insertar(pCuenta);
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
        /// Método ObtenerCuenta.
        /// Obtiene todas las cuentas de la base de datos para mostrarlas luego
        /// </summary>
        /// <returns>Lista de cuentas almacenadas</returns>
        public List<CuentaDTO> ObtenerCuenta()
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                return iFactory.CuentaDAO().Obtener();
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
        /// Método BuscarCuenta.
        /// Obtiene una cuenta almacenada en la base de datos, mediante la búsqueda por su nombre.
        /// Si coincide el nombre con el almacenado en la base de datos, la devuelve.
        /// En caso contrario, lanzará una excepción
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de la cuenta a buscar</param>
        /// <returns>Cuenta deseada</returns>
        public CuentaDTO BuscarCuenta(string pNombreCuenta)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                return iFactory.CuentaDAO().BuscarCuenta(pNombreCuenta);
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
        /// Método BuscarCuentas.
        /// El método buscará las cuentas que tengan en algún lugar de su nombre el parámetro por el cual lo estamos buscando
        /// Por ejemplo: si hay mas de una cuenta que en el nombre contiene la palabra "Godzilla", entonces
        /// se visualizarán todos los resultados que contengan en el nombre "Godzilla".
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de la cuenta que queremos buscar</param>
        /// <returns>Todas las cuentas que en alguna parte del nombre éste parámetro</returns>
        public List<CuentaDTO> BuscarCuentas(string pNombreCuenta)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                return iFactory.CuentaDAO().BuscarCuentas(pNombreCuenta);
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
        /// Método BuscarTodasLasCuentas.
        /// Permite buscar todas las cuentas activas y no activas de la base de datos
        /// </summary>
        /// <param name="pNombreCuenta">Nombre a buscar</param>
        /// <returns>Lista de cuentas activas y no activas</returns>
        public List<CuentaDTO> BuscarTodasLasCuentas(string pNombreCuenta)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                return iFactory.CuentaDAO().BuscarTodasLasCuentas(pNombreCuenta);
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
        /// Método BuscarPorEmail.
        /// El método busca una cuenta mediante su dirección de email. En caso de encontrarlo devuelve
        /// todo el objeto CuentaDTO.
        /// </summary>
        /// <param name="pDireccion">Dirección de mail por la cual buscamos la cuenta</param>
        /// <returns>La cuenta que contenga dicha dirección</returns>
        public CuentaDTO BuscarPorEmail(string pDireccion)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                return iFactory.CuentaDAO().BuscarPorEmail(pDireccion);
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
        /// Método ModificarCuenta.
        /// Mediante el id de la cuenta a modificar, se busca en la base de datos y el usuario
        /// tiene la posibilidad de modificar los datos que desee. Luego se modifica la cuenta especificada.
        /// </summary>
        /// <param name="pIdCuenta">Id de la cuenta a modificar</param>
        /// <param name="pCuentaAModificar">Objeto CuentaDTO que tendrá cargados los datos a modificar en la BD</param>
        public void ModificarCuenta(int pIdCuenta, CuentaDTO pCuentaAModificar)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iFactory.CuentaDAO().Modificar(pIdCuenta, pCuentaAModificar);
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
        /// Método EliminarCuenta.
        /// Permite marcar como inactiva una cuenta.
        /// </summary>
        /// <param name="pNombreCuentaAEliminar">Nombre de la cuenta que necesitamos eliminar</param>
        public void EliminarCuenta(string pNombreCuentaAEliminar)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iFactory.CuentaDAO().Eliminar(pNombreCuentaAEliminar);
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
        /// Método ReactivarCuenta.
        /// Permite reactivar una cuenta que se ha marcado como inactiva.
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de la cuenta que deseamos reactivar</param>
        public void ReactivarCuenta(string pNombreCuenta)
        {
            try
            {
                iFactory = DAOFactory.Instancia();
                iFactory.IniciarConexion();
                iFactory.ComenzarTransaccion();
                iFactory.CuentaDAO().ReactivarCuenta(pNombreCuenta);
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

    }
}
