using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioAgente.Entidades
{
    public class Solicitud<T>
    {
        public string tipoObjeto { get { return Constantes.TipoObjecto.Solicitud; } }
        public string Peticion { get; set; }
        public T Objeto { get; set; }
    }
}
