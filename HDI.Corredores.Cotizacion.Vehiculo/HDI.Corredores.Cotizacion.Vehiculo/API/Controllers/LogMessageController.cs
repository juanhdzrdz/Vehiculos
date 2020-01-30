using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Events;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio;
using HDI.Framework.Integration.EventBus.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogMessageController : ControllerBase
    {
        private readonly ServiceConfiguration Configuration;

        private readonly IBusinessContext BusinessContext;

        private readonly IEventBus EventBus;

        public LogMessageController(IOptions<ServiceConfiguration> configuration, IBusinessContext businessContext, IEventBus eventBus)
        {
            Configuration = configuration.Value;
            BusinessContext = businessContext;
            EventBus = eventBus;
        }

        [HttpGet]
        public List<Tb_Bitacora_GrlBitacora> GetLogMessages()
        {
            return BusinessContext.GetLogMessages();
        }

        [HttpPost]
        public void SendMessage(Tb_Bitacora_GrlBitacora logMessage)
        {
            HDI.Framework.Logging.LogMessage message = new Framework.Logging.LogMessage
            {
                Header = new Framework.Logging.LogHeader
                {
                    PRI = new Framework.Logging.LogPriorityValue
                    {
                        Facility = (HDI.Framework.Logging.Enums.LogFacility)logMessage.Bit_Facility,
                        Severity = (HDI.Framework.Logging.Enums.LogSeverity)logMessage.Bit_Severity
                    },
                    Version = (Framework.Logging.Enums.SyslogVersion)logMessage.Bit_SyslogVersion,
                    CreationDate = logMessage.Bit_CreationDate,
                    Hostname = logMessage.Bit_Hostname,
                    ApplicationName = logMessage.Bit_ApplicationName,
                    ProcessId = logMessage.Bit_ProcessId,
                    MessageId = logMessage.Bit_MessageId
                },
                Msg = logMessage.Bit_Message
            };

            SendLogMessageEvent logEventMessage = new SendLogMessageEvent(message);

            EventBus.Publish(logEventMessage);
        }
    }
}