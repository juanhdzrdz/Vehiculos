using HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public class NegocioMarca : INegocioMarca
    {
        #region Constantes

        #endregion

        #region Atributos
        private readonly ServiceConfiguration Configuracion;
        private readonly IDataMarca _DataMarca;
        private readonly IServicioNegocio _ServicioNegocio;
        private readonly IServicioTarifa _ServicioTarifa;


        #endregion

        #region Propiedades

        #endregion

        #region Constructores
        public NegocioMarca(IOptions<ServiceConfiguration> configuracion, IDataMarca dataMarca, IServicioNegocio servicioNegocio, IServicioTarifa servicioTarifa)
        {
            Configuracion = configuracion.Value;
            _DataMarca = dataMarca;
            _ServicioNegocio = servicioNegocio;
            _ServicioTarifa = servicioTarifa;
        }
        #endregion
        public Marcas ObtenerMarcas(int idModelo, int idTipoVehiculo, string usuario)
        {
            throw new NotImplementedException();
        }

        public Marcas ObtenerMarcasPorNegocio(int idModelo, int idTipoVehiculo, string idNegocio)
        {
            DataTable configuracionNegocio = _ServicioNegocio.ObtenerConfiguracionNegocio(new RequestObtenerConfiguracion() { negocioId=idNegocio, cveVehiculo="" });
            DataRow drConfiguracion = configuracionNegocio.Rows[0]; 
            string cadenaVersiones = string.Empty;

            if (drConfiguracion != null && drConfiguracion["Tar_TarifaId"] != null && drConfiguracion["Tar_TarifaId"].ToString().Trim() != string.Empty
                                   && Convert.ToInt32(drConfiguracion["Tar_TarifaId"]) > 0
                                   && drConfiguracion["Tar_Version"] != null && drConfiguracion["Tar_Version"].ToString().Trim() != string.Empty
                                   && Convert.ToInt32(drConfiguracion["Tar_Version"]) >= 0
                                   && drConfiguracion["cli_nip"].ToString().Trim() != string.Empty

                   )
            {
                List<Tarifa> tarifa = _ServicioTarifa.ObtenerTarifas(new TarifaRequest() { agenteNIP = drConfiguracion["cli_nip"].ToString().Trim(), claveTarifa = Convert.ToInt32(drConfiguracion["Tar_TarifaId"]), versionTarifa = Convert.ToInt32(drConfiguracion["Tar_Version"]) });
            }
                throw new NotImplementedException();
        }
    }
}
