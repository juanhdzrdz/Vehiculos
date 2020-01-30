using HDI.Corredores.Cotizacion.ServicioAgente.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy
{
    public interface IServicioTarifa
    {
        List<Tarifa> ObtenerTarifas(TarifaRequest request);
    }
}
