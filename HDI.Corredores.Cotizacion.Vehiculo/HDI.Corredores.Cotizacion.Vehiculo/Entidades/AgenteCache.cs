using System;
using System.Collections.Generic;


namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class AgenteCache : IDisposable
    {
        #region "Declaración de Variables"
        /// <summary>
        /// Contiene la Referencia de la Cache Generica
        /// </summary>
        private CacheGenerica _cacheGen;
        /// <summary>
        /// 
        /// </summary>
        private UsuarioPermisosSuscripcion _usuarioPermisosSuscripcion;
        #endregion

        #region "Declaración de Contructor"
        /// <summary>
        /// Constructor
        /// </summary>
        public AgenteCache()
        {
            this._cacheGen = new CacheGenerica();
            this._usuarioPermisosSuscripcion = UsuarioPermisosSuscripcion;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="agente">Referencia del Agente</param>
        public AgenteCache(IAgente agente)
        {
            this.AgenteCot = agente;
            this._cacheGen = new CacheGenerica();
            this._usuarioPermisosSuscripcion = UsuarioPermisosSuscripcion;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="agente">Referencia del Agente</param>
        public AgenteCache(IAgente agente, string horasLimpiar)
        {
            this.AgenteCot = agente;
            this._cacheGen = new CacheGenerica(horasLimpiar);
            this._usuarioPermisosSuscripcion = UsuarioPermisosSuscripcion;
        }

        /// <summary>
        /// horasLimpiar
        /// </summary>
        /// <param name="horasLimpiar"></param>
        public AgenteCache(string horasLimpiar)
        {
            this._cacheGen = new CacheGenerica(horasLimpiar);
            this._usuarioPermisosSuscripcion = UsuarioPermisosSuscripcion;
        }
        #endregion

        #region "Declaración de Funciones"
        #region "Dispose"
        /// <summary>
        /// Libera
        /// </summary>
        public void Dispose()
        {
            this._cacheGen = null;
            this.AgenteCot = null;
        }
        #endregion
        #endregion

        #region "Declaración de Propiedades"
        #region "Informacion"
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, object> Informacion
        {
            get
            {
                return this.CacheGen.Informacion;
            }
            set
            {
                this.CacheGen.Informacion = value;
            }
        }
        #endregion
        #region "AgenteCot"
        /// <summary>
        /// Devuelve o Establece el 
        /// </summary>
        public IAgente AgenteCot
        {
            get;
            set;
        }
        #endregion
        #region "indice"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clave"></param>
        /// <returns></returns>
        public object this[string clave]
        {
            get
            {
                object valor = null;
                return valor;
            }
            set
            {
                this._cacheGen[clave] = value;
            }
        }
        #endregion

        #region "CacheGen"
        /// <summary>
        /// 
        /// </summary>
        public CacheGenerica CacheGen
        {
            get
            {
                return this._cacheGen;
            }
            set
            {
                this._cacheGen = value;
            }
        }
        #endregion
        #endregion

        #region "UsuarioPermisosSuscripcion"
        /// <summary>
        /// 
        /// </summary>
        public UsuarioPermisosSuscripcion UsuarioPermisosSuscripcion
        {
            get
            {
                return this._usuarioPermisosSuscripcion;
            }
            set
            {
                this._usuarioPermisosSuscripcion = value;
            }
        }
        #endregion
    }
}