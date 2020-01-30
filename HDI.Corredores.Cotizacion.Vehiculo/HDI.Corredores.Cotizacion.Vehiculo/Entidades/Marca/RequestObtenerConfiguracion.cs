using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca
{
    public class RequestObtenerConfiguracion
    {
        public string negocioId { get; set; }
        public string cveVehiculo { get; set; }
    }
}
