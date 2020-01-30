#region Ensamblado UNO.Herramientas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\Juan\Desktop\UNO\UNOServices\UNO.Services\Source\Resource Access\UNO.Services.Emision.DataAccess\bin\Debug\UNO.Herramientas.dll
#endregion

using System;
using System.Collections.Generic;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class ProveedorCacheASPNet : IProveedorCache
    {
        public ProveedorCacheASPNet() { }

        public List<string> LiberarCache() {
            return null;
        }
        public void LiberarClave(string key) {
            return;
        }
        public T Obtener<T>(string clave, Func<T> recuperarDatos, DateTime? fechaExpiracion, TimeSpan? tiempoExpiracion) {
            return default(T);
        }
        public IEnumerable<T> Obtener<T>(string clave, Func<IEnumerable<T>> recuperarDatos, DateTime? fechaExpiracion, TimeSpan? tiempoExpiracion)
        {
            return null;
        }
        public T Obtener<T>(string clave)
        {
            return default(T);
        }
        public List<string> ObtenerCache()
        {
            return null;
        }
    }
}