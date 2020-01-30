using System.ServiceModel;
using System;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers
{
    public class RequestObtenerVersiones
    {

        public string IdNegocio { get; set; }
        public int IdTipoVehiculo { get; set; }
        public int IdMarca { get; set; }
        public string IdTipo { get; set; }
        public int IdModelo { get; set; }
        public string usuario { get; set; }

    }
}