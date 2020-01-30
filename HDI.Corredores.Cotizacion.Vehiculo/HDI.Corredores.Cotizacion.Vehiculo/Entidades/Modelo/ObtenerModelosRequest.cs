using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo
{
    public class ObtenerModelosRequest
    {
        public int idTipoVehiculo { get; set; }
        public int idMarca { get; set; }
        public string idTipo { get; set; }
        public string idVersion { get; set; }
        public int idTransmision { get; set; }
    }
}
