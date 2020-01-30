using System;
using System.Data;
using HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    internal interface IEmisionController
    {
        DataTable RecuperarVersiones(RequestObtenerVersiones request);

        DataTable RecuperarVersiones(int tipoVehiculoID, int marcaID, string tipo, int anio, DateTime fecha, int tarVersion, string usuario);
    }
}