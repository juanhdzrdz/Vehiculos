using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [DataContract(Namespace = "http://hdi.com.mx/UNO.Entidades.Enums")]
    public enum TiposUsuario
    {
        Empleado = 5050,
        Agente = 5051,
        Despacho = 5052,
        Promotoria = 5066
    }
}
