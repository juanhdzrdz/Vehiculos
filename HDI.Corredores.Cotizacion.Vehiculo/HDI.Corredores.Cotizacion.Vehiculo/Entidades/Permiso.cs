using System;
using System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [DataContract(Namespace = "http://hdi.com/Uno.Servicios")]
    public class Permiso
    {

        [DataMember]
        public Guid IdPermiso { get; set; }
        [DataMember]
        public string NombrePermiso { get; set; }
        [DataMember]
        public string PermisoGrupo { get; set; }
    }
}
