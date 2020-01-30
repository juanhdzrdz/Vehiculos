using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos
{
    public interface IDatosVehiculo
    {
        Modelos CargaGeneral(ObtenerModelosRequest datos);
    }
}
