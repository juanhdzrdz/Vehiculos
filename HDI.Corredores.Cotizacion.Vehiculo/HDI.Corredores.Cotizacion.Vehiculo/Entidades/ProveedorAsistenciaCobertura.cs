using System;
using System.Collections.Generic;
using System.Data;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class ProveedorAsistenciaCobertura
    {
        public int IdCobertura { get; set; }
        public string Agencia { get; set; }
        public DateTime Fecha { get; set; }
        public DataTable ProveedoresAsistencia { get; set; }
    }
}