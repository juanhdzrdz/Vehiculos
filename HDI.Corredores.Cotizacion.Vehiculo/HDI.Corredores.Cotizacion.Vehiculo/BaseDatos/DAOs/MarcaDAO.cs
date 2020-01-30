using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AdoNetCore.AseClient;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.Core;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs
{
    public class MarcaDAO
    {
        private readonly ServiceConfiguration Configuration;

        public MarcaDAO(IOptions<ServiceConfiguration> configuration)
        {
            Configuration = configuration.Value;
        }

        public DataTable RecuperarMarcas(int tipoVehiculoID, int anio, int versionModelo, string usuario)
        {
            DataTable result = null;
            try
            {
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                List<IDataParameter> parameters = new List<IDataParameter>
                {
                    new AseParameter("@TIPOVEHICULO", AseDbType.Integer){ Value = tipoVehiculoID }
                    , new AseParameter("@ANIO", AseDbType.Integer){ Value = anio }
                    , new AseParameter("@VMOD_VERSION", AseDbType.Integer){ Value = versionModelo }
                    , new AseParameter("@Cli_Nip", AseDbType.VarChar){ Value = usuario }
                };

                DataSet dset = SybaseEngine.ExecuteDataSet
                (
                    SP.Vehiculo.USP_AUT_EMI_GET_MARCAS,
                    CommandType.StoredProcedure,
                    parameters
                );
                if (dset.Tables != null && dset.Tables.Count > 0)
                {
                    result = dset.Tables[0];
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
