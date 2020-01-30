#region Ensamblado UNO.Herramientas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\Juan\Desktop\UNO\UNOServices\UNO.Services\Source\Resource Access\UNO.Services.Emision.DataAccess\bin\Debug\UNO.Herramientas.dll
#endregion

using System;
using System.Collections.Generic;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public interface IProveedorCache
    {
        List<string> LiberarCache();
        void LiberarClave(string key);
        T Obtener<T>(string clave, Func<T> recuperarDatos, DateTime? fechaExpiracion, TimeSpan? tiempoExpiracion);
        IEnumerable<T> Obtener<T>(string clave, Func<IEnumerable<T>> recuperarDatos, DateTime? fechaExpiracion, TimeSpan? tiempoExpiracion);
        T Obtener<T>(string clave);
        List<string> ObtenerCache();
    }
}