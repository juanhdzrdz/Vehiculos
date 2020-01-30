using HDI.Framework.Integration.EventBus.Core.Interfaces;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos;
using Message = HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Tb_Bitacora_GrlBitacora;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Events.Handlers
{
    public class SendLogMessageEventHandler : IIntegrationEventHandler<SendLogMessageEvent>
    {
        private readonly LogDbContext LogDbContext;

        public SendLogMessageEventHandler(LogDbContext dbContext)
        {
            LogDbContext = dbContext;
        }

        public void Handle(SendLogMessageEvent sendLogMessageEvent)
        {
            Message message = new Message
            {
                Bit_PriVal = sendLogMessageEvent.Message.Header.PRI.PriValue,
                Bit_Facility = (int)sendLogMessageEvent.Message.Header.PRI.Facility,
                Bit_Severity = (int)sendLogMessageEvent.Message.Header.PRI.Severity,
                Bit_SyslogVersion = (int)sendLogMessageEvent.Message.Header.Version,
                Bit_CreationDate = sendLogMessageEvent.Message.Header.CreationDate,
                Bit_Hostname = sendLogMessageEvent.Message.Header.Hostname,
                Bit_ApplicationName = sendLogMessageEvent.Message.Header.ApplicationName,
                Bit_ProcessId = sendLogMessageEvent.Message.Header.ProcessId,
                Bit_StructuredData = sendLogMessageEvent.Message.StructuredData.ToString(),
                Bit_Message = sendLogMessageEvent.Message.Msg
            };

            LogDbContext.Tb_Bitacora_GrlBitacora.Add(message);
            LogDbContext.SaveChanges();
        }
    }
}