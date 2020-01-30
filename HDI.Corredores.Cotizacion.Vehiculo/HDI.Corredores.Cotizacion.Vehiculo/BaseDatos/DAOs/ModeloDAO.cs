using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using AdoNetCore.AseClient;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.Core;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs
{
    public class ModeloDAO
    {
        private readonly ServiceConfiguration Configuration;

        public ModeloDAO(IOptions<ServiceConfiguration> configuration)
        {
            Configuration = configuration.Value;
        }

        public Modelos CargaGeneral(ObtenerModelosRequest datos) 
        {
            Modelos result = null;
            try
            {
                string[] tipo = datos.idTipo.Split("°");
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                List<IDataParameter> parameters = new List<IDataParameter>
                {
                    new AseParameter("@ACCION", AseDbType.Integer){ Value= 4 }
                    , new AseParameter("@MARCA_VEHICULO", AseDbType.Integer){ Value= datos.idMarca }
                    , new AseParameter("@TIP_VEHICULO", AseDbType.Integer){ Value= datos.idTipoVehiculo }
                    , new AseParameter("@TIPO", AseDbType.VarChar){ Value= datos.idTipo }
                    , new AseParameter("@VERSION", AseDbType.VarChar){ Value= datos.idVersion }
                    , new AseParameter("@FECHA", AseDbType.DateTime){ Value= DateTime.Today }
                    , new AseParameter("@TIPOTRANSMISION", AseDbType.VarChar){ Value=datos.idTransmision }                    
                };
                if(tipo.Length>=2)
                {
                    parameters.Add(new AseParameter("@CLAVE_VEHICULO", AseDbType.Integer) { Value = tipo[1] });

                    if(tipo.Length > 2)
                    {
                        parameters.Add(new AseParameter("@TAR_TARIFAID", AseDbType.Integer) { Value = tipo[2] });
                        parameters.Add(new AseParameter("@TAR_VERSION", AseDbType.Integer) { Value = tipo[3] });
                    }
                }
                

                DataSet dset = SybaseEngine.ExecuteDataSet
                (
                    SP.Vehiculo.CSTR_USP_AUT_EMI_VEHICULOCARAC,
                    CommandType.StoredProcedure,
                    parameters
                );
                if (dset.Tables != null && dset.Tables.Count > 0)
                {
                    if (dset.Tables[0].Rows.Count > 0)
                    {
                        result = new Modelos();
                        foreach (DataRow renglon in dset.Tables[0].Rows)
                        {
                            Modelo modeloAgregar = new Modelo();
                            modeloAgregar.clave= (renglon.Table.Columns.Contains("VMOD_ANIO") && renglon["VMOD_ANIO"] != DBNull.Value) ? Convert.ToInt32(renglon["VMOD_ANIO"]) : 0;
                            modeloAgregar.descripcion= (renglon.Table.Columns.Contains("VMOD_ANIO") && renglon["VMOD_ANIO"] != DBNull.Value) ? Convert.ToString(renglon["VMOD_ANIO"]) : "";
                            result.Add(modeloAgregar);
                        }
                    }
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
