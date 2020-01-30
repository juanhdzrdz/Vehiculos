namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion
{
    public class ServiceConfiguration
    {
        public string NombreEntorno { get; set; }
        public string VariableAPI { get; set; }
        public string VariableNegocio { get; set; }
        public string VariableDatos { get; set; }
        public string SybaseConnectionString { get; set; } //MJPL
        public string LogConnectionStringSQL { get; set; }
        public string RabbitHostName { get; set; }
        public string RabbitUserName { get; set; }
        public string RabbitPassword { get; set; }
        public string RabbitVirtualHost { get; set; }
        public string RabbitPort { get; set; }
        public string RabbitExchangeName { get; set; }
        public string RabbitExchangeType { get; set; }
        public string RabbitExchangeIsDurable { get; set; }
        public string RabbitExchangeIsAutoDelete { get; set; }
        public string RabbitQueueName { get; set; }
        public string RabbitQueueIsDurable { get; set; }
        public string RabbitQueueIsExclusive { get; set; }
        public string RabbitQueueIsAutoDelete { get; set; }
        public string RutaServicioConfiguracion { get; set; }
        public string RutaServicioAgente { get; set; }
    }
}
