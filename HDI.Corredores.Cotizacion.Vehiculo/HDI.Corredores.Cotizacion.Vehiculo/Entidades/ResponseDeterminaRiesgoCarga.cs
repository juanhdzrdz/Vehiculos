using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class ResponseDeterminaRiesgoCarga
    {
        private Mensajes mensajes;
        private Mensajes errores;
        private int idRiesgoCarga;

        public Mensajes Mensajes { get => mensajes; set => mensajes = value; }
        public Mensajes Errores { get => errores; set => errores = value; }
        public int IdRiesgoCarga { get => idRiesgoCarga; set => idRiesgoCarga = value; }
    }
}
