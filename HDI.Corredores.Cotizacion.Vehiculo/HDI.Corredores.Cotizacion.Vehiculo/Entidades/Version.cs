using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [WcfSerialization::DataContract(Namespace = "http://hdi.com.mx/services/public", Name = "Version")]
    public partial class Version
    {
        private string clave;
        private string descripcion;

        [WcfSerialization::DataMember(Name = "Clave", IsRequired = false, Order = 0)]
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        [WcfSerialization::DataMember(Name = "Descripcion", IsRequired = false, Order = 1)]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
