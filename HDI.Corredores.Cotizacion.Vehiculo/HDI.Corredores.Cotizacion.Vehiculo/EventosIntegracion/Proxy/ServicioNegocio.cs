using HDI.Corredores.Cotizacion.ServicioAgente.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy
{
    public class ServicioNegocio : IServicioNegocio
    {
        #region Propiedades

        private readonly ServiceConfiguration Configuration;

        #endregion

        #region Constructor

        public ServicioNegocio(IOptions<ServiceConfiguration> configuration)
        {
            Configuration = configuration.Value;
        }

        #endregion
        public DataTable ObtenerConfiguracionNegocio(RequestObtenerConfiguracion request)
        {
            Solicitud<RequestObtenerConfiguracion> solicitud = new Solicitud<RequestObtenerConfiguracion>();

            solicitud.Peticion = "ObtenerConfigAplicacion";
            solicitud.Objeto = request;

            try
            {
                HttpClient client = new HttpClient();

                var respuesta = new HttpRequestMessage(HttpMethod.Post, new Uri(Configuration.RutaServicioConfiguracion + Constantes.ServiciosExternos.obtenerConfigAplicacion));

                respuesta.Content = new StringContent(JsonConvert.SerializeObject(solicitud));

                respuesta.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = client.SendAsync(respuesta).Result;
                string content = response.Content.ReadAsStringAsync().Result;


                Respuesta<DataTable> ConverionRespuesta = JsonConvert.DeserializeObject<Respuesta<DataTable>>(content);

                return ConverionRespuesta.Objeto;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
