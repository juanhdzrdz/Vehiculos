using HDI.Framework.Integration.EventBus.Core.Events;
using HDI.Framework.Logging;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Events
{
    public class SendLogMessageEvent : IntegrationEvent
    {
        public LogMessage Message { get; set; }

        public SendLogMessageEvent(LogMessage message)
        {
            Message = message;
        }
    }
}
