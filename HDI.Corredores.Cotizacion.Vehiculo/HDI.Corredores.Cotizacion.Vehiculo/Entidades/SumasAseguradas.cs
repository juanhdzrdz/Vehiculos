using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [WcfSerialization::DataContract(Namespace = "http://hdi.com.mx/services/public", Name = "SumasAseguradas")]
    public partial class SumasAseguradas
    {
        private decimal sumaAsegurada;
        private string descripcionSumaAsegurada;

        [WcfSerialization::DataMember(Name = "SumaAsegurada", IsRequired = false, Order = 0)]
        public decimal SumasAsegurada
        {
            get { return sumaAsegurada; }
            set { sumaAsegurada = value; }
        }

        [WcfSerialization::DataMember(Name = "DescripcionSumaAsegurada", IsRequired = false, Order = 1)]
        public string DescripcionSumaAsegurada
        {
            get { return descripcionSumaAsegurada; }
            set { descripcionSumaAsegurada = value; }
        }
    }
}
