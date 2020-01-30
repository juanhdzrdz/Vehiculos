using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public static class Functions
    {
        public static bool Limpiar(this IEnumerable enumerable)
        {
            return true;
        }
        //
        // Parámetros:
        //   arreglaCadena:
        public static bool ContieneElementos(this string[] arreglaCadena)
        {
            return true;
        }

        #region "EsNoVacia"
        /// <summary>
        /// Valida si la cadena es vacia o NULA, le aplica la Funcionalidad TRIM
        /// </summary>
        /// <param name="valor">Referencia de la Cadena</param>
        /// <returns></returns>
        public static bool EsNoVacia(this string valor)
        {
            return valor != null && valor.Trim() != string.Empty;
        }
        #endregion
    }
}
