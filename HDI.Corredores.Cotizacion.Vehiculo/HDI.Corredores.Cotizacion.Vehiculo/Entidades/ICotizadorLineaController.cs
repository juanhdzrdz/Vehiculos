using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public interface ICotizadorLineaController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agenteNIP"></param>
        /// <returns></returns>
        Agente ObtenerAgente(string agenteNIP, AgenteCache UsuarioCache);

        Agente ObtenerAgente(string agenteNIP, string idAgencia, AgenteCache agenteCache);

        Agente ObtenerAgente(string agenteNIP, string idAgencia);

        DataTable ObtenerSumaAsegurada(RequestObtenerSumaAsegurada request);

        DataSet ObtenerConfiguracionNegocio(string idNegocio, string cveVehiculo);

        DataTable ObtenTarifa(string agenteNIP, int claveTarifa, int versionTarifa, AgenteCache agenteCache);
    }
}
 