using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using System.ServiceModel;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class RequestObtenerSumaAsegurada
    {
        public string AgenteNIPs { get; set; }
        public string ClaveOficina { get; set; }
        public string ClaveVehiculo { get; set; }
        public int Modelo { get; set; }
        public bool ModeloSpecified { get; set; }
        public string TipoDocto { get; set; }
        public int VmodVersionTarifa { get; set; }
        public bool VmodVersionTarifaSpecified { get; set; }

    }
}
