using HDI.Corredores.Cotizacion.ServicioAgente.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
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
    public class ServicioAgente : IServicioAgente
    {
        #region Propiedades

        private readonly ServiceConfiguration Configuration;

        #endregion

        #region Constructor

        public ServicioAgente(IOptions<ServiceConfiguration> configuration)
        {
            Configuration = configuration.Value;
        }

        #endregion

        #region Metodos

        public Agente ObtenerAgente(string agenteNip, string idAgencia)
        {

            Solicitud<RequestObtenerAgente> solicitud = new Solicitud<RequestObtenerAgente>();
            RequestObtenerAgente requestAgente = new RequestObtenerAgente();
            requestAgente.agenteNIP = agenteNip;
            requestAgente.idAgencia = idAgencia;
            Agente ag = null;
            solicitud.Peticion = "ObtenerAgente";
            solicitud.Objeto = requestAgente;

            try
            {
                HttpClient client = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(Configuration.RutaServicioAgente + Constantes.ServiciosExternos.obtenerAgente));

                request.Content = new StringContent(JsonConvert.SerializeObject(solicitud));

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = client.SendAsync(request).Result;
                string content = response.Content.ReadAsStringAsync().Result;


                Respuesta<Agente> respuesta = JsonConvert.DeserializeObject<Respuesta<Agente>>(content);

                return respuesta.Objeto;
            }
            catch (Exception ex)
            {

                ag = null;
            }

            return ag;
        }

        #endregion
    }
}
