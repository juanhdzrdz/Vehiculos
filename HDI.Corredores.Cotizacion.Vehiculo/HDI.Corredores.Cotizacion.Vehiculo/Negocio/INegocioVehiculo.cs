using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo;
using HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public interface INegocioVehiculo
    {
        ResponseDeterminaRiesgoCarga DeterminaRiesgoCarga(RequestDeterminaRiesgoCarga request);

        ObtenerModelosResponse ObtenerModelos(ObtenerModelosRequest request);

        ObtenerMarcasResponse ObtenerMarcas(ObtenerMarcasRequest request);

        ResponseObtenerVersiones ObtenerVersiones(RequestObtenerVersiones request);


    }
}
