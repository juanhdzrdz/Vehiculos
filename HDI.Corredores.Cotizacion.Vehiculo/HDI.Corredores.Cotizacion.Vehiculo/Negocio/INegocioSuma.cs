using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public interface INegocioSuma
    {
        ResponseObtenerSumaAsegurada ObtenerSumaAsegurada(RequestObtenerSumaAsegurada request);

        DataTable ObtenerTarifas(string agenteTaf);

        Usuario ObtenerUsuario(string usuario);

        Agente ObtenerAgenteXUsuario(Usuario usuario, List<ServicioVehiculo.Entidades.Mensaje> errores);

    }
}