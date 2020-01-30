using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers
{

    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecibosController : ControllerBase
    {
        private readonly ServiceConfiguration Configuracion;

        private readonly IBusinessContext BusinessContext;

        public RecibosController(IOptions<ServiceConfiguration> configuration, IBusinessContext businessContext)
        {
            Configuracion = configuration.Value;
            BusinessContext = businessContext;
        }

        [HttpGet]
        public List<Recibo> ObtenerRecibos()
        {
            return BusinessContext.ReadAllRecibos();
        }

        [HttpGet("{numRec}")]
        public Recibo ObtenerReciboPorNumRec(int numRec)
        {
            return BusinessContext.ReadReciboByNumRec(numRec);
        }

        [HttpGet("ObtenerRecibosPorNumRec")]
        public Recibo ObtenerReciboPorNumRec(Recibo recibo)
        {
            return BusinessContext.ReadReciboByNumRec(recibo);
        }

        [HttpPost]
        public int InsertarRecibo(Recibo peticion)
        {
            return BusinessContext.CreateRecibo(peticion);
        }

        [HttpPut]
        public bool ActualizarRecibo(Recibo peticion)
        {
            try
            {
                BusinessContext.UpdateRecibo(peticion);
            }
            catch
            {
                return false;
            }
            return true;
        }

        [HttpDelete]
        public bool EliminarRecibo(Recibo peticion)
        {
            try
            {
                BusinessContext.DeleteRecibo(peticion);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
