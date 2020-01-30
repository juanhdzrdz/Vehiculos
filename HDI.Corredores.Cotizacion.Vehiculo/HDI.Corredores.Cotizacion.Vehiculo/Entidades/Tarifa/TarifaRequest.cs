using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class TarifaRequest
    {
        public string agenteNIP { get; set; }
        public int claveTarifa { get; set; }
        public int versionTarifa { get; set; }
    }
}
