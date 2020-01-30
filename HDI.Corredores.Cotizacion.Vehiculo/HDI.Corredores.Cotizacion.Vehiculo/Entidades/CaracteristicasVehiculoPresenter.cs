using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using static HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Constantes;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class CaracteristicasVehiculoPresenter : Presenter<IUCCaracteristicasVehiculoView>
    {
        #region "Declaración de Variables"

        private IEmisionController _controller;


        #endregion

        #region "Declaración de Funciones"

        #region ObtenNumTarVersion
        public int ObtenNumTarVersion(string tipoTarifa, string versionesTarifas)
        {
            int version = -1;
            string[] versionesTarifa = versionesTarifas.Split(',');

            foreach (string versionTar in versionesTarifa)
                if (versionTar.Split(':')[0] == tipoTarifa)
                {
                    version = int.Parse(versionTar.Split(':')[1]);
                    break;
                }

            return version;
        }
        #endregion
        #region "RecuperarVersiones"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoVehiculoID"></param>
        /// <param name="marcaID"></param>
        /// <param name="tipo"></param>
        /// <param name="anio"></param>
        /// <param name="fecha"></param>
        /// <param name="versionVehiculo"></param>
        /// <returns></returns>
        public DataTable RecuperarVersiones(RequestObtenerVersiones request)
        {
            return this._controller.RecuperarVersiones(request);
        }
        /// <summary>
        /// Recupera el listado de versiones
        /// </summary>
        /// <param name="tipoVehiculoID">ID del tipo de vehículo</param>
        /// <param name="marcaID">ID de la marca</param>
        /// <param name="tipo">Tipo</param>
        /// <param name="anio">Año/Modelo</param>
        /// <param name="fecha">Fecha</param>
        /// <param name="tarVersion">Version de la tarifa</param>
        /// <returns></returns>

        #endregion
        #region "RecuperarVersiones"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoVehiculoID"></param>
        /// <param name="marcaID"></param>
        /// <param name="tipo"></param>
        /// <param name="anio"></param>
        /// <param name="fecha"></param>
        /// <param name="versionVehiculo"></param>
        /// <returns></returns>
        public DataTable RecuperarVersiones(int tipoVehiculoID, int marcaID, string tipo, int anio, DateTime fecha, int versionVehiculo, string usuario)
        {
            return this._controller.RecuperarVersiones(tipoVehiculoID, marcaID, tipo, anio, fecha, versionVehiculo, usuario);
        }
        /// <summary>
        /// Recupera el listado de versiones
        /// </summary>
        /// <param name="tipoVehiculoID">ID del tipo de vehículo</param>
        /// <param name="marcaID">ID de la marca</param>
        /// <param name="tipo">Tipo</param>
        /// <param name="anio">Año/Modelo</param>
        /// <param name="fecha">Fecha</param>
        /// <param name="tarVersion">Version de la tarifa</param>
        /// <returns></returns>
        public DataTable RecuperarVersiones(int tipoVehiculoID, int marcaID, string tipo, int anio, DateTime fecha, string versionesTarifas, string usuario)
        {
            return this._controller.RecuperarVersiones(tipoVehiculoID, marcaID, tipo, anio, fecha, versionesTarifas.Trim() == string.Empty ? View.VersionModeloTarifa : ObtenNumTarVersion(TIPO_TARIFAS.VMOD, versionesTarifas), usuario);
        }
        #endregion

    }

}
#endregion