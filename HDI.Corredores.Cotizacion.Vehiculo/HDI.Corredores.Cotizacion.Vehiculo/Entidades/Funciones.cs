using System;
using System.Collections.Generic;
using System.Data;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public abstract class Funciones
    {
        public abstract void LiberarObjeto(IDisposable objeto);
    }
}
