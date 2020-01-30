using System;
using System.Data;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class CotizadorEnLineaPresenter : Presenter<ICotizadorEnLineaView>
    {
        private ICotizadorLineaController _controller;
        private AgenteCache _usuarioCacheInterno;

        public AgenteCache UsuarioCache
        {
            get
            {
                /************************************************
                 * Se obtiene el usuario cache actual
                 * **********************************************/
                AgenteCache resultado = this._usuarioCacheInterno;
                /************************************************
                 * Se valida si ya tiene objeto de cache, en caso
                 * contrario se determina el usuario cache.
                 * **********************************************/
                if (resultado == null)
                {
                    if (this.View != null)
                    {
                        if (this.View.UsuarioCache != null)
                        {
                            resultado = this.View.UsuarioCache;
                        }
                        else
                        {
                            resultado = this.UsuarioCacheInterno;
                        }
                    }
                    else
                    {
                        resultado = this.UsuarioCacheInterno;
                    }
                }

                return resultado;
            }
            set
            {
                this._usuarioCacheInterno = value;
            }

        }
        private AgenteCache UsuarioCacheInterno
        {
            get
            {
                if (this._usuarioCacheInterno == null)
                    this._usuarioCacheInterno = new AgenteCache();

                return this._usuarioCacheInterno;
            }
        }

        public DataTable ObtenerConfiguracionNegocio(string negocioId, string cveVehiculo)
        {
            DataSet ds = ObtenerConfiguracionNegocioGlobal(negocioId, cveVehiculo);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                return ds.Tables[0]; //Configuracion NEgocio

            return null;
        }

        public DataSet ObtenerConfiguracionNegocioGlobal(string negocioId, string cveVehiculo)
        {
            return this._controller.ObtenerConfiguracionNegocio(negocioId, cveVehiculo);
        }

        public DataTable ObtenerTarifa(string agenteNIP, int claveTarifa, int versionTarifa, AgenteCache agenteCache)
        {
            if (agenteNIP.EsNoVacia())
                return this._controller.ObtenTarifa(agenteNIP, claveTarifa, versionTarifa, this.UsuarioCache);
            else
                return null;
        }

        #region "ObtenerAgente"
        /// <summary>
        /// Se obtienen los datos del agente de acuerdo al NIP y este es asignado al cotizador
        /// en linea
        /// </summary>
        /// <param name="agenteNIP">Clave del NIP</param>
        /// <returns>Devuelve la Referencia del agente</returns>
        //public Agente ObtenerAgente(string agenteNIP, string idAgencia, AgenteCache agenteCache)
        //{
        //    Agente agente = new Agente();
        //    TimeSpan tiempoExpiracion = new TimeSpan(0, 10, 0);

        //        if (agenteCache != null)
        //        {
        //            agente = this.ObtenerAgente(agenteNIP, idAgencia);
        //        }
        //        else
        //        {
        //            agente = this.ObtenerAgente(agenteNIP, idAgencia);
        //        }

        //        return agente;
        //}
        #endregion
    }
}