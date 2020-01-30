using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca
{
    public class ObtenerMarcasRequest
    {
        public int IdModelo { get; set; }
        public string IdNegocio { get; set; }
        public int IdTipoVehiculo { get; set; }
        public string usuario { get; set; }
    }
}
