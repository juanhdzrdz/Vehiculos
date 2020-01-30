using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    //
    // Resumen:
    //     Contiene las Reglas de Coberturas correpondientes a todos los paquetes que le
    //     corresponden a un tipo de ServicioVehiculo.
    public abstract class CotizacionLinea
    {

        public static string ObtenerVersionesParaTarificacion(DataRow tarifa)
        {
            StringBuilder versionesTarifas = new StringBuilder();

            if (tarifa != null)
            {
                try
                {
                    versionesTarifas.Append("TAR:");
                    versionesTarifas.Append(tarifa["TAR_VERSION"].ToString());
                    versionesTarifas.Append(",");
                    versionesTarifas.Append("VAN:");
                    versionesTarifas.Append(tarifa["VAN_VERSION"].ToString());
                    versionesTarifas.Append(",");
                    versionesTarifas.Append("VMOD:");
                    versionesTarifas.Append(tarifa["VMOD_VERSION"].ToString());
                    versionesTarifas.Append(",");
                    versionesTarifas.Append("TAMI:");
                    versionesTarifas.Append(tarifa["TAMI_VERSION"].ToString());
                    versionesTarifas.Append(",");
                    versionesTarifas.Append("TVAR:");
                    versionesTarifas.Append(tarifa["TVAR_VERSION"].ToString());
                    versionesTarifas.Append(",");
                    versionesTarifas.Append("FZON:");
                    versionesTarifas.Append(tarifa["FZON_VERSION"].ToString());
                    versionesTarifas.Append(",");
                    versionesTarifas.Append("TVARV:");
                    versionesTarifas.Append(tarifa["TVARV_VERSION"].ToString());
                    return versionesTarifas.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception("No existe una columna de Version de Tarifas, en el DataRow Proporcionado", ex);
                }
                finally
                {
                    versionesTarifas = null;
                }
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
