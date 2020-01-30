using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion
{
    public class ConfiguracionMicroservicio
    {
        public string NombreEntorno { get; set; }
        public string VariableAPI { get; set; }
        public string VariableNegocio { get; set; }
        public string VariableDatos { get; set; }
        public string SybaseConnectionString { get; set; }
    }
}
