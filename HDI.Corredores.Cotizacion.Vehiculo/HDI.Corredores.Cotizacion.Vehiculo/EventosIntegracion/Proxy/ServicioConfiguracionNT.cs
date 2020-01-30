using HDI.Corredores.Cotizacion.ServicioAgente.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy
{
    public class ServicioConfiguracionNT : IServicioConfiguracionNT
    {
        #region Propiedades

        private readonly ServiceConfiguration Configuration;

        #endregion

        #region Constructor

        public ServicioConfiguracionNT(IOptions<ServiceConfiguration> configuration)
        {
            Configuration = configuration.Value;
        }

        #endregion

        #region Metodos

        public string ObtenerConfigAplicacion(string llaveConfiguracion)
        {
            string configuracion = "";

            Solicitud<string> solicitud = new Solicitud<string>();

            solicitud.Peticion = "ObtenerConfigAplicacion";
            solicitud.Objeto = llaveConfiguracion;

            try
            {
                HttpClient client = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(Configuration.RutaServicioConfiguracion + Constantes.ServiciosExternos.obtenerConfigAplicacion));

                request.Content = new StringContent(JsonConvert.SerializeObject(solicitud));

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = client.SendAsync(request).Result;
                string content = response.Content.ReadAsStringAsync().Result;


                Respuesta<string> respuesta = JsonConvert.DeserializeObject<Respuesta<string>>(content);

                return respuesta.Objeto;
            }
            catch (Exception ex)
            {

                configuracion =  "";
            }

            return configuracion;
        }

        #endregion
    }
}
