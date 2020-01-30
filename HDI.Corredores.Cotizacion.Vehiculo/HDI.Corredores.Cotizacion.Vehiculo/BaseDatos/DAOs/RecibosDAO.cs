using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.Core;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;

using AdoNetCore.AseClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Extensions.Options;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs
{
    public class RecibosDAO
    {
        private readonly ServiceConfiguration Configuration;

        public RecibosDAO(IOptions<ServiceConfiguration> configuration)
        {
            Configuration = configuration.Value;
        }

        public List<Recibo> GetAllRecibos()
        {
            List<Recibo> result;
            try
            {
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                result = SybaseEngine.ToCollection<Recibo>
                (
                    SP.Pruebas.Usp_Uno_GrlPruebaReciboArq_ObtAll,
                    CommandType.StoredProcedure
                );

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public Recibo GetReciboByNumRec(Recibo recibo)
        {
            Recibo result;

            try
            {
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                List<IDataParameter> parameters = new List<IDataParameter>
                {
                    new AseParameter("@NumRec", AseDbType.Integer){ Value=recibo.NumRec }
                };

                result = SybaseEngine.ToObject<Recibo>
                (
                    SP.Pruebas.Usp_Uno_GrlPruebaReciboArq_ObtByNumRec,
                    CommandType.StoredProcedure,
                    parameters
                );

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int CreateRecibo(Recibo recibo)
        {
            int result;
            try
            {
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                List<IDataParameter> parameters = new List<IDataParameter>
                {
                    new AseParameter("@Oficina", AseDbType.VarChar,10){Value=recibo.Oficina},
                    new AseParameter("@Cotizacion", AseDbType.VarChar,10){Value=recibo.Cotizacion},
                    new AseParameter("@Folio", AseDbType.VarChar,10){Value=recibo.Folio},
                    new AseParameter("@PrimaNeta", AseDbType.Decimal,10){Value=recibo.PrimaNeta, Precision = 2}
                };
                result = (int)SybaseEngine.ExecuteScalar
                (
                    SP.Pruebas.Usp_Uno_GrlPruebaReciboArq_Ins,
                    CommandType.StoredProcedure,
                    parameters
                );

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public void UpdateRecibo(Recibo recibo)
        {
            try
            {
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                List<IDataParameter> parameters = new List<IDataParameter>
                {
                    new AseParameter("@NumRec", AseDbType.Integer){ Value=recibo.NumRec },
                    new AseParameter("@Oficina", AseDbType.VarChar,10){Value=recibo.Oficina},
                    new AseParameter("@Cotizacion", AseDbType.VarChar,10){Value=recibo.Cotizacion},
                    new AseParameter("@Folio", AseDbType.VarChar,10){Value=recibo.Folio},
                    new AseParameter("@PrimaNeta", AseDbType.Decimal,10){Value=recibo.PrimaNeta, Precision = 2}
                };
                SybaseEngine.ExecuteNonQuery
                (
                    SP.Pruebas.Usp_Uno_GrlPruebaReciboArq_Act,
                    CommandType.StoredProcedure,
                    parameters
                );

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteRecibo(Recibo recibo)
        {
            try
            {
                SybaseEngine SybaseEngine = new SybaseEngine(Configuration.SybaseConnectionString);

                List<IDataParameter> parameters = new List<IDataParameter>
                {
                    new AseParameter("@NumRec", AseDbType.Integer){ Value=recibo.NumRec }
                };
                SybaseEngine.ExecuteNonQuery
                (
                    SP.Pruebas.Usp_Uno_GrlPruebaReciboArq_Eli,
                    CommandType.StoredProcedure,
                    parameters
                );

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
