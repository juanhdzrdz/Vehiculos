using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs
{
    public class VehiculoDAO
    {
        #region Atributos
        private readonly ServiceConfiguration Configuracion;
        #endregion

        #region Constructores
        public VehiculoDAO(IOptions<ServiceConfiguration> configuracion)
        {
            Configuracion = configuracion.Value;
        }
        #endregion

        //public Agente ObtenerAgente(string agenteNIP, string idAgencia)
        //{
        //    Agente objAgente = null;
        //    DataTable dtAgente = null;
        //    NTEAgenteBE agenteBE = null;
        //    string verificaCedula = string.Empty;
        //    TimeSpan tiempoExpiracion = new TimeSpan(0, 10, 0);


        //        try
        //        {
        //            if (agenteNIP != null &&
        //                agenteNIP.Trim() != string.Empty &&
        //                agenteNIP.Split(new char[] { '¬' }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
        //            {
        //                verificaCedula = agenteNIP.Split(new char[] { '¬' }, StringSplitOptions.RemoveEmptyEntries)[1]
        //                    .Trim();
        //                agenteNIP = agenteNIP.Split(new char[] { '¬' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
        //            }

        //            objAgente = new Agente();
        //            agenteBE = new NTEAgenteBE(agenteNIP, idAgencia);
        //            if (verificaCedula.Trim() != string.Empty) agenteBE.verificaCedula = bool.Parse(verificaCedula);
        //            dtAgente = new NTEAgenteBP().Recuperar(agenteBE);

        //            if (dtAgente.ContieneElementos())
        //            {
        //                objAgente.Nombre = dtAgente.ObtenerValorString("DESCRIPCION", string.Empty);
        //                objAgente.RFC = dtAgente.ObtenerValorString("RFC", string.Empty);
        //                objAgente.NIP = agenteNIP;
        //                objAgente.Tipo = dtAgente.ObtenerValorString("TIPO PERSONA", string.Empty);
        //                objAgente.AgenciaID = dtAgente.ObtenerValorString("ID_AGENCIA", string.Empty);
        //                objAgente.ZonaCirculacionCamiones = dtAgente.ObtenerValorEntero("ZONA_C", NUMERO.CERO);
        //                objAgente.ZonaCirculacionVehiculo = dtAgente.ObtenerValorEntero("ZONA_V", NUMERO.CERO);
        //                objAgente.Agencia = dtAgente.ObtenerValorString("AGE_NOMBRE", string.Empty);
        //                objAgente.TipoCedula = dtAgente.ObtenerValorString("CLI_CED_TIPO", string.Empty);
        //                objAgente.AplicaIVAFronterizo = dtAgente.ObtenerValorBooleano("IVA_FRONTEROZO", false);
        //                objAgente.TipoAgente = dtAgente.ObtenerValorString("CLI_CLASIF_9B", string.Empty);
        //            }
        //            else
        //            {
        //                objAgente.Nombre = String.Empty;
        //                objAgente.RFC = String.Empty;
        //                objAgente.NIP = String.Empty;
        //                objAgente.Tipo = String.Empty;
        //                objAgente.AgenciaID = string.Empty;
        //                objAgente.Agencia = string.Empty;
        //                objAgente.TipoCedula = string.Empty;
        //                objAgente.TipoAgente = string.Empty;
        //            }

        //            return objAgente;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            objAgente = null;
        //            dtAgente = null;

        //        }
        //    }, null, tiempoExpiracion);
        }
    }

