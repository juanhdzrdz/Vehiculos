using HDI.Corredores.Cotizacion.ServicioAgente.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Configuration;
using System.Web;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Comun;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController
    {
        #region Constantes

        #region "ObtenUsuario"
        /// <summary>
        /// Obtienen el usuario que se autentifico en los servicios o ya se encuentre autentificado en el contexto
        /// </summary>
        /// <returns></returns>


        /// <summary>
        /// Obtienen el usuario, si el usuario no es especificado, lo intenta tomar del ServiceSecurityContext.Current.PrimaryIdentity.Name, 
        /// en caso contrario lo toma del Header con el que se auttentifico.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <returns></returns>

        #endregion
        #endregion

        #region Atributos
        private readonly ServiceConfiguration Configuracion;

        private readonly INegocioVehiculo NegocioVehiculo;

        private readonly IServicioConfiguracionNT ServicioConfiguracionNT;

        private readonly INegocioSuma NegocioSuma;
        #endregion

        #region Propiedades

        #endregion

        #region Constructores
        public VehiculoController(IOptions<ServiceConfiguration> configuracion, INegocioVehiculo negocioVehiculo, IServicioConfiguracionNT servicioConfiguracionNT, INegocioSuma negocioSuma)
        {
            Configuracion = configuracion.Value;
            NegocioVehiculo = negocioVehiculo;
            ServicioConfiguracionNT = servicioConfiguracionNT;
            NegocioSuma = negocioSuma;

        }



        #endregion

        [Route("DeterminaRiesgoCarga")]
        [HttpPost]
        public Respuesta<ResponseDeterminaRiesgoCarga> DeterminaRiesgoCarga(Solicitud<RequestDeterminaRiesgoCarga> solicitud)
        {
            Respuesta<ResponseDeterminaRiesgoCarga> respuesta = new Respuesta<ResponseDeterminaRiesgoCarga>();

            respuesta.Accion = "ObtenerRiesgoCarga";

            try
            {
                respuesta.Codigo = Constantes.Codigo.Ok;
                respuesta.Mensaje = Constantes.Mensaje.Correcto;
                respuesta.Objeto = NegocioVehiculo.DeterminaRiesgoCarga(solicitud.Objeto);

            }
            catch (Exception ex)
            {
                respuesta.Codigo = Constantes.Codigo.Error;
                respuesta.Mensaje = Constantes.Mensaje.Error + ": " + ex;
                respuesta.Objeto = null;
            }

            return respuesta;
        }

        [Route("ObtenerModelos")]
        [HttpPost]
        public Respuesta<ObtenerModelosResponse> ObtenerModelos(Solicitud<ObtenerModelosRequest> solicitud)
        {
            Respuesta<ObtenerModelosResponse> respuesta = new Respuesta<ObtenerModelosResponse>();

            respuesta.Accion = "ObtenerModelos";

            try
            {
                respuesta.Codigo = Constantes.Codigo.Ok;
                respuesta.Mensaje = Constantes.Mensaje.Correcto;
                respuesta.Objeto = NegocioVehiculo.ObtenerModelos(solicitud.Objeto);

            }
            catch (Exception ex)
            {
                respuesta.Codigo = Constantes.Codigo.Error;
                respuesta.Mensaje = Constantes.Mensaje.Error + ": " + ex;
                respuesta.Objeto = null;
            }

            return respuesta;
        }

        [Route("ObtenerMarcas")]
        [HttpPost]
        public Respuesta<ObtenerMarcasResponse> ObtenerMarcas(Solicitud<ObtenerMarcasRequest> solicitud)
        {
            Respuesta<ObtenerMarcasResponse> respuesta = new Respuesta<ObtenerMarcasResponse>();

            respuesta.Accion = "ObtenerMarcas";

            try
            {
                respuesta.Codigo = Constantes.Codigo.Ok;
                respuesta.Mensaje = Constantes.Mensaje.Correcto;
                respuesta.Objeto = NegocioVehiculo.ObtenerMarcas(solicitud.Objeto);

            }
            catch (Exception ex)
            {
                respuesta.Codigo = Constantes.Codigo.Error;
                respuesta.Mensaje = Constantes.Mensaje.Error + ": " + ex;
                respuesta.Objeto = null;
            }

            return respuesta;
        }

        [Route("ObtenerVersiones")]
        [HttpPost]
        public Respuesta<ResponseObtenerVersiones> ObtenerVersiones(Solicitud<RequestObtenerVersiones> solicitud)
        {
            //List<Versiones> listaVersiones = new List<Versiones>();
            Respuesta<ResponseObtenerVersiones> respuesta = new Respuesta<ResponseObtenerVersiones>();

            respuesta.Accion = "ObtenerVersiones";

            try
            {
                respuesta.Codigo = Constantes.Codigo.Ok;
                respuesta.Mensaje = Constantes.Mensaje.Correcto;
                respuesta.Objeto = NegocioVehiculo.ObtenerVersiones(solicitud.Objeto);

            }
            catch (Exception ex)
            {
                respuesta.Codigo = Constantes.Codigo.Error;
                respuesta.Mensaje = Constantes.Mensaje.Error + ": " + ex;
                respuesta.Objeto = null;
            }

            return respuesta;
        }

        [Route("ObtenerSumaAsegurada")]
        [HttpPost]
        public Respuesta<ResponseObtenerSumaAsegurada> ObtenerSumaAsegurada(Solicitud<RequestObtenerSumaAsegurada> solicitud)
        {
            Respuesta<ResponseObtenerSumaAsegurada> respuesta = new Respuesta<ResponseObtenerSumaAsegurada>();

            respuesta.Accion = "ObtenerSumaAsegurada";

            try
            {
                respuesta.Codigo = Constantes.Codigo.Ok;
                respuesta.Mensaje = Constantes.Mensaje.Correcto;
                respuesta.Objeto = NegocioSuma.ObtenerSumaAsegurada(solicitud.Objeto);

            }
            catch (Exception ex)
            {
                respuesta.Codigo = Constantes.Codigo.Error;
                respuesta.Mensaje = Constantes.Mensaje.Error + ": " + ex;
                respuesta.Objeto = null;
            }

            return respuesta;

        }
    }
}
