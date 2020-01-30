using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy
{
    public interface IServicioNegocio
    {
        DataTable ObtenerConfiguracionNegocio(RequestObtenerConfiguracion request);
    }
}
