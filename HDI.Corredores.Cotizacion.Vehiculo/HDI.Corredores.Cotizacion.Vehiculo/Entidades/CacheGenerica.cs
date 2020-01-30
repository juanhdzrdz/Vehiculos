using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Functions;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class CacheGenerica : IDisposable
    {
        #region "Declaración de Enums"
        /// <summary>
        /// 
        /// </summary>
        private enum enmtipoValida
        {
            /// <summary>
            /// No se realiza Validación
            /// </summary>
            NoEspecificado = 0,
            /// <summary>
            /// Especifica que se valida en base a un intervalo de horas
            /// </summary>
            HorasPeriodo = 1,
            /// <summary>
            /// Especifica la lista de horas en las que se actualiza
            /// </summary>
            HorasDeLimpia = 2
        }
        #endregion

        #region "Declaración de variables"
        /// <summary>
        /// Especifica la fecha de Inicializacioón de la cache
        /// </summary>
        private DateTime _fechaInicializa = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        private DateTime _fechaSiguienteActualizacion;
        /// <summary>
        /// Especifica el numero de horas de Limpia
        /// </summary>
        private int _horasPeriodoLimpia = 0;
        /// <summary>
        /// Especifica la lista de hora de limpia
        /// </summary>
        private string _horaDeLimpia = "";
        /// <summary>
        /// Especifica la validación
        /// </summary>
        private enmtipoValida _tipoValida = enmtipoValida.NoEspecificado;
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, object> _informacion;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor
        /// </summary>
        public CacheGenerica()
        {
            this._tipoValida = enmtipoValida.NoEspecificado;
            this._informacion = new Dictionary<string, object>();
        }
        /// <summary>
        /// Constructor, Se especifica el listado de horas de limpia, estas horas
        /// se especifican separandolas por un espacio.
        /// </summary>
        /// <param name="horasDeLimpia">Listado de Horas de Limpia</param>
        public CacheGenerica(string horasDeLimpia)
        {
            this._tipoValida = enmtipoValida.HorasDeLimpia;
            this._horaDeLimpia = horasDeLimpia;
            this._informacion = new Dictionary<string, object>();
        }
        /// <summary>
        /// Constructor, Se especifica el listado de horas de limpia, estas horas
        /// se especifican separandolas por un espacio.
        /// </summary>
        /// <param name="horasDeLimpia">Listado de Horas de Limpia</param>
        public CacheGenerica(int horasPeriodoLimpia)
        {
            this._tipoValida = enmtipoValida.HorasPeriodo;
            this._horasPeriodoLimpia = horasPeriodoLimpia;
            this._informacion = new Dictionary<string, object>();
        }
        #endregion

        #region "Declaración de Funciones"
        #region "Dispose"
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            this.Limpiar();
            GC.ReRegisterForFinalize(this);
        }
        #endregion

        #region "indice"
        /// <summary>
        /// Obtener la información en base al indice, si no existe el elemento, devuelve NULL
        /// </summary>
        /// <param name="clave">Clave a Buscar</param>
        /// <returns></returns>
        public object this[string clave]
        {
            get
            {
                object valor = null;
                if (this.Existe(clave))
                    valor = this._informacion[clave];

                return valor;
            }
            set
            {
                this._informacion[clave] = value;
            }
        }
        #endregion

        #region "Limpiar"
        /// <summary>
        /// Libera la Cache
        /// </summary>
        public void Limpiar()
        {
            lock (_informacion)
            {
                _informacion.Limpiar();
            }
        }
        #endregion
        #region "ValidarLimpiaCache"
        /// <summary>
        /// Limpia la cache de acuerdo al tiempo o periodos
        /// </summary>
        public void ValidarLimpiaCache()
        {
            switch (this._tipoValida)
            {
                case enmtipoValida.HorasDeLimpia:

                    break;
                case enmtipoValida.HorasPeriodo:

                    break;
                case enmtipoValida.NoEspecificado:
                    break;
            }
        }
        #endregion
        #region "Existe"
        /// <summary>
        /// Devuelve si la clave en especifico existe
        /// </summary>
        /// <param name="clave">clave a buscar</param>
        /// <returns></returns>
        public bool Existe(string clave)
        {
            this.ValidarLimpiaCache();

            bool existe = false;
            this.ValidarLimpiaCache();
            // PGarcia - 25/01/2018 - Adecuacion para apagar Cache
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("ApagarCache"))
            {
                existe = this._informacion.ContainsKey(clave);
            }
            else
            {
                if (Boolean.Parse(ConfigurationManager.AppSettings["ApagarCache"]) == true)
                {
                    existe = false;
                }
                else
                {
                    existe = this._informacion.ContainsKey(clave);
                }

            }
            return existe;
        }
        #endregion
        #region "Obtener"
        /// <summary>
        /// Obtiene la información de una clave en especifico
        /// </summary>
        /// <param name="clave">clave a buscar</param>
        /// <returns></returns>
        public object Obtener(string clave)
        {
            if (this._informacion.ContainsKey(clave))
                return this._informacion[clave];
            else
                return null;
        }
        #endregion
        #region "Agregar"
        /// <summary>
        /// Agrega un elemento a la colección
        /// </summary>
        /// <param name="clave">Clave de la Informacion</param>
        /// <param name="informacion">Información a guardar</param>
        public void Agregar(string clave, object informacion)
        {
            lock (this._informacion)
            {
                if (!this._informacion.ContainsKey(clave))
                    this._informacion.Add(clave, informacion);
            }
        }
        #endregion
        #region "Agregar"
        /// <summary>
        /// Agrega un elemento el cual la clave y el valor estan en una cadena separado por un
        /// caracter especifico
        /// </summary>
        /// <param name="elementos">Cadena con Clave y Valor</param>
        /// <param name="separador">Caracter que separa a la Clave y El valor</param>
        public void Agregar(string[] elementos, char separador)
        {
            string[] valores;
            if (elementos.ContieneElementos())
                foreach (string elemento in elementos)
                {
                    valores = elemento.Split(separador);
                    this.Agregar(valores[0], valores[1]);
                }
        }
        #endregion
        #region "Agregar"
        /// <summary>
        /// Agrega a la chace una lista de claves con sus valores
        /// </summary>
        /// <param name="claves">lista de claves</param>
        /// <param name="valores">lista de valores</param>
        public void Agregar(string[] claves, object[] valores)
        {
            if (claves.ContieneElementos())
                for (int posicion = 0; posicion < claves.Length; posicion++)
                    this.Agregar(claves[posicion], valores[posicion]);
        }
        #endregion
        #region "Remove"
        /// <summary>
        /// Agrega un elemento a la colección
        /// </summary>
        /// <param name="clave">Clave de la Informacion</param>
        /// <param name="informacion">Información a guardar</param>
        public void Remove(string clave)
        {
            lock (this._informacion)
            {
                if (!this._informacion.ContainsKey(clave))
                    this._informacion.Remove(clave);
            }
        }
        #endregion

        #region "Declaración de Propiedades"
        #region "Informacion"
        /// <summary>
        /// Devuelve o Establece la colección de información guardada en la cache
        /// </summary>
        public Dictionary<string, object> Informacion
        {
            get
            {
                return this._informacion;
            }
            set
            {
                this._informacion = value;
            }
        }
        #endregion
        #endregion

        #endregion
    }
}
