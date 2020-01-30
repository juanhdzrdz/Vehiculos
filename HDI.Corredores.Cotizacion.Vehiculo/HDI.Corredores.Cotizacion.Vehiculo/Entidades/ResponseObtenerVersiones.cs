using System.ServiceModel;
using System;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers
{
    public class ResponseObtenerVersiones
    {
        public Versiones ListaVersiones { get; set; }
    }
}