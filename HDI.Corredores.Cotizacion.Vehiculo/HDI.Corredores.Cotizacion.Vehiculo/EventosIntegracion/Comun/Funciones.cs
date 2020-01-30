using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Comun
{
    public class Funciones
    {
        public void AgregaMensaje(Mensajes objeto, string _descripcion, string _valor, int tipoError)
        {
            if (objeto == null) objeto = new Mensajes();

            objeto.Add(new Mensaje()
            {
                descripcion = _descripcion,
                valor = _valor
            });
        }

    }

}
