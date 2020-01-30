using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy
{
    public interface IServicioAgente
    {
        Agente ObtenerAgente(string agenteNip, string idAgencia);
    }
}
