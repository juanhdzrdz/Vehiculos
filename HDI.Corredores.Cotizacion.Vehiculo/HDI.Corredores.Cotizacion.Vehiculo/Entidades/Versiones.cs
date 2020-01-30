using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [WcfSerialization::CollectionDataContract(Namespace = "http://hdi.com.mx/services/public", ItemName = "Versiones")]
    public partial class Versiones : System.Collections.Generic.List<Version>
    {
    }
}
