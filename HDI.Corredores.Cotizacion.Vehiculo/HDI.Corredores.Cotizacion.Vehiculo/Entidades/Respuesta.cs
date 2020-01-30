using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class Respuesta<T>
    {
        public string tipoObjeto { get { return Constantes.TipoObjecto.Respuesta; } }
        public string Accion { get; set; }
        public int Codigo { get; set; }
        public String Mensaje { get; set; }
        public T Objeto { get; set; }
    }
}
