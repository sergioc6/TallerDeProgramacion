using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    public interface ICuentaDAO
    {
        /// <summary>
        /// Permite insertar una nueva Cuenta de correo en la base de datos
        /// </summary>
        /// <param name="pCuenta"></param>
        void Insertar(CuentaDTO pCuenta);

        /// <summary>
        /// Permite modificar los datos de una cuenta de correo en la base de datos
        /// </summary>
        /// <param name="pCuenta"></param>
        void Modificar(int pIDCuenta, CuentaDTO pCuenta);

        /// <summary>
        /// Permite eliminar una cuenta de correo en la base de datos
        /// </summary>
        /// <param name="pCuenta"></param>
        void Eliminar(string pCuenta);

        /// <summary>
        /// Obtiene todas las cuenta de correo electronico de la base de datos que estén activas.
        /// </summary>
        /// <returns>Todas las cuentas activas</returns>
        List<CuentaDTO> Obtener();

        /// <summary>
        /// Obtiene todas las cuentas de la base de datos
        /// </summary>
        /// <returns>Todas las cuentas</returns>
        List<CuentaDTO> ObtenerTodasLasCuentas();

        /// <summary>
        /// Obtiene una cuenta de correo electronico identificada por su nombre.
        /// </summary>
        /// <param name="pNombreCuenta"></param>
        /// <returns>Cuenta persistida en BD</returns>
        CuentaDTO BuscarCuenta(string pNombreCuenta);

        /// <summary>
        /// Obtiene todas las cuentas.
        /// </summary>
        /// <param name="pNombreCuenta"></param>
        /// <returns>Lista de cuentas</returns>
        List<CuentaDTO> BuscarTodasLasCuentas(string pNombreCuenta);

        /// <summary>
        /// Obtiene una lista de las cuentas de correo electrónico identificadas por el nombre.
        /// Éste método se utiliza cuando utilizando como parámetro de búsqueda el nombre,
        /// se obtiene mas de un resultado
        /// </summary>
        /// <param name="pNombreCuenta">Nombre de la cuenta a buscar</param>
        /// <returns>Lista de cuentas guardadas</returns>
        List<CuentaDTO> BuscarCuentas(string pNombreCuenta);


        /// <summary>
        /// Obtiene un objeto del tipo CuentaDTO, que fue buscado por su dirección de correo
        /// </summary>
        /// <param name="pDireccion">Dirección de correo a buscar</param>
        /// <returns>Cuenta persistida en BD</returns>
        CuentaDTO BuscarPorEmail(string pDireccion);

        /// <summary>
        /// Permite reactivar una cuenta para ser usada nuevamente.
        /// </summary>
        /// <param name="pCuenta">Nombre de la cuenta a reactivar.</param>
        void ReactivarCuenta(string pCuenta);
    }
}
