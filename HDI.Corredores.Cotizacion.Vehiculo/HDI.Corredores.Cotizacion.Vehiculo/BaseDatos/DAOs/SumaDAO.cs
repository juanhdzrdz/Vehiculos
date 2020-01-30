using AdoNetCore.AseClient;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.Core;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using static HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Constantes;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs
{
    public class SumaDAO
    {
        #region Atributos
        private readonly ServiceConfiguration Configuracion;
        private readonly ConfiguracionMicroservicio Configuration;
        #endregion

        #region Constructores
        public SumaDAO(IOptions<ServiceConfiguration> configuracion)
        {
            Configuracion = configuracion.Value;
        }
        #endregion

        #region ObtenerSumaAsegurada
        public DataTable ObtenerSumaAsegurada(string LlaveDatos, string agenteNIP, string claveVehiculo, string tipoDocto, string claveOficina, int modelo, int vmodVersionTarifa)
        {

            DataTable sumasAseguradas;
            DataTable dtVehiculo;
            DataRow nuevoDataRow;
            TarBase tarificaComponente;

            TimeSpan tiempoExpiracion = new TimeSpan(0, 10, 0);
            try
            {
                tarificaComponente = new TarBase();

                dtVehiculo = GetDatosTarifa(LlaveDatos, claveVehiculo, tipoDocto, "", claveOficina);

                // Se crea el datatable.
                sumasAseguradas = new DataTable("SumasAseguradas");
                // Se crean las columnas.
                DataColumn descripcionSumaAsegurada = new DataColumn("DescripcionSumaAsegurada");
                descripcionSumaAsegurada.DataType = System.Type.GetType("System.String");
                sumasAseguradas.Columns.Add(descripcionSumaAsegurada);

                DataColumn sumaAseguarda = new DataColumn("SumaAsegurada");
                sumaAseguarda.DataType = System.Type.GetType("System.Decimal");
                sumasAseguradas.Columns.Add(sumaAseguarda);

                // Agregar valores de sumas aseguradas
                nuevoDataRow = sumasAseguradas.NewRow();

                nuevoDataRow["DescripcionSumaAsegurada"] = "ValorComercial";
                nuevoDataRow["SumaAsegurada"] = GetV2(
                    Convert.ToInt32(dtVehiculo.Rows[0]["CAM_CODIGOID"]), modelo, DateTime.Now, vmodVersionTarifa);
                sumasAseguradas.Rows.Add(nuevoDataRow);

                // Agregar valores de sumas aseguradas
                nuevoDataRow = sumasAseguradas.NewRow();

                nuevoDataRow["DescripcionSumaAsegurada"] = "ValorVehiculoNuevo";
                nuevoDataRow["SumaAsegurada"] = GetV1(
                    Convert.ToInt32(dtVehiculo.Rows[0]["CAM_CODIGOID"]), DateTime.Now, vmodVersionTarifa);
                sumasAseguradas.Rows.Add(nuevoDataRow);

                //_v1 - ValorVehiculoNuevo
                //_v2 - ValorComercial

                return sumasAseguradas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tarificaComponente = null;
            }
        }
        #endregion

        #region ObtenerTarifas

        /// <summary>
        /// Se Obtienen las Tarifas de Acuerdo al Agente
        /// </summary>
        /// <param name="AgenteNIP">NIP del Agente</param>
        /// <returns>Devuelve las Tarifas.</returns>
        public DataTable ObtenerTarifas(string agenteNIP)
        {
            TarificaBP tarificaComponente;
            string claveCache = "ObtenerTarifas|" + agenteNIP;
            TimeSpan tiempoExpiracion = new TimeSpan(0, 10, 0);

                try
                {
                    tarificaComponente = new TarificaBP();
                    return tarificaComponente.ObtenerTarifas(agenteNIP);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    tarificaComponente = null;
                }

        }

        #endregion

        #region "GetDatosTarifa"
        public DataTable GetDatosTarifa(string LlaveDatosTarifa, string ClaveVehiculo, string tipoDocumento, string cotizacion, string agencia)
        {
            DataTable valor = null;
            string resultado = null;
            bool nueva = tipoDocumento == CLAVE.TIPODOCUMENTO.POLIZA ||
                        tipoDocumento == CLAVE.TIPODOCUMENTO.ALTA_DE_CIS_COTIZACION ||
                        tipoDocumento == CLAVE.TIPODOCUMENTO.RENOVACION;

            try
            {
                resultado = "DatCaractVeh" + (nueva ? ClaveVehiculo + tipoDocumento.ToString() : agencia + cotizacion.Trim().PadRight(10, '0'));
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                if (nueva)
                {
                    List<IDataParameter> listaParametros = new List<IDataParameter>
                    {
                        new AseParameter("@ACCION", AseDbType.VarChar,7){Value=LlaveDatosTarifa},
                        new AseParameter("@CLAVE_VEHICULO", AseDbType.VarChar,30){Value=ClaveVehiculo}
                        
                    };
                    listaParametros.Add(new AseParameter("@CPOL_TIP_DOC", AseDbType.VarChar, 2) { Value = tipoDocumento });
                    if (tipoDocumento != null && tipoDocumento.Trim() != string.Empty)
                        new AseParameter("@CPOL_TIP_DOC", AseDbType.VarChar, 2) { Value = tipoDocumento };

                    DataSet dset = SybaseEngine.ExecuteDataSet
                    (
                    SP.GetDatosTarifa.usp_aut_emi_vehiculoCarac,
                    CommandType.StoredProcedure,
                    listaParametros
                    );

                }
                else
                {
                    List<IDataParameter> listaParametros = new List<IDataParameter>
                    {
                        new AseParameter("@AGE_ID", AseDbType.VarChar,7){Value=agencia},
                        new AseParameter("@CPOL_ID_COTIZ", AseDbType.VarChar,30){Value=cotizacion.Trim().PadRight(10, '0')}

                    };
                    DataSet dset = SybaseEngine.ExecuteDataSet
                    (
                    SP.GetDatosTarifa.usp_aut_ObtenerDatosPol99,
                    CommandType.StoredProcedure,
                    listaParametros
                    );
                   
                }
                
            }
            catch
            {
                throw;
            }

            return valor;
        }
        #endregion
        #region "GetV1"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CamCodigoCamID"></param>
        /// <param name="dtFecha"></param>
        /// <param name="versionVAN"></param>
        /// <returns></returns>
        public decimal GetV1(int CamCodigoCamID, DateTime dtFecha, int versionVAN)
        {
            string clave = "V1" + CamCodigoCamID.ToString() + dtFecha.ToShortDateString() + versionVAN.ToString();
            decimal valor = 0;

            SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);
            try
            {
                List<IDataParameter> listaParametros = new List<IDataParameter> {

                new AseParameter("@VanCodigoCamID", AseDbType.Integer, CamCodigoCamID) { Value = CamCodigoCamID },
                new AseParameter("@FECHA", AseDbType.DateTime) { Value = dtFecha },
                new AseParameter("@VanVersionTar", AseDbType.Integer, versionVAN) { Value = versionVAN }
                };
                DataSet dset = SybaseEngine.ExecuteDataSet
                    (
                    SP.GetDatosTarifa.usp_aut_nte_obtenerV1,
                    CommandType.StoredProcedure,
                    listaParametros
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valor;
        }
        #endregion
        #region "GetV2"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="VModCodigoCamID"></param>
        /// <param name="VModAnio"></param>
        /// <param name="dtFecha"></param>
        /// <param name="versionVMOD"></param>
        /// <returns></returns>
        public decimal GetV2(int VModCodigoCamID, int VModAnio, DateTime dtFecha, int versionVMOD)
        {

            string clave = "V2" + VModCodigoCamID.ToString() + VModAnio.ToString() + dtFecha.ToShortDateString() + versionVMOD.ToString();
            decimal valor = 0;
            SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);


            try
            {
                List<IDataParameter> listaParametros = new List<IDataParameter> {

                new AseParameter("@VModCodigoCamID", AseDbType.Integer, VModCodigoCamID) { Value = VModCodigoCamID },
                new AseParameter("@VModAnio", AseDbType.Integer, VModAnio) { Value = VModAnio },
                new AseParameter("@FECHA", AseDbType.DateTime) { Value = dtFecha },
                new AseParameter("@VModVersionTar", AseDbType.Integer, versionVMOD) { Value = versionVMOD }
                };
                DataSet dset = SybaseEngine.ExecuteDataSet
                    (
                    SP.GetDatosTarifa.usp_aut_nte_obtenerV2,
                    CommandType.StoredProcedure,
                    listaParametros
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return valor;
        }
        #endregion

    }
}
