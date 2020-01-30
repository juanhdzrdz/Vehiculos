using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ServiceConfiguration Configuration;

        private readonly IBusinessContext BusinessContext;

        public ValuesController(IOptions<ServiceConfiguration> configuration, IBusinessContext businessContext)
        {
            Configuration = configuration.Value;
            BusinessContext = businessContext;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Nombre de Entorno: " + Configuration.NombreEntorno;
        }

        [HttpGet("API")]
        public ActionResult<string> GetVariableAPI()
        {
            return "Variable API: " + Configuration.VariableAPI;
        }

        [HttpGet("Negocio")]
        public ActionResult<string> GetVariableNegocio()
        {
            return BusinessContext.GetBusinessVariable();
        }

        [HttpGet("Datos")]
        public ActionResult<string> GetVariableDatos()
        {
            return BusinessContext.GetDataVariable();
        }
    }
}
