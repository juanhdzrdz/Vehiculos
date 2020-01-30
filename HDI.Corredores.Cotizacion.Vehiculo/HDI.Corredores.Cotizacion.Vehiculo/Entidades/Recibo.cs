using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class Recibo
    {
        public int NumRec { get; set; }
        public string Oficina { get; set; }
        public string Cotizacion { get; set; }
        public string Folio { get; set; }
        public decimal PrimaNeta { get; set; }
    }
}
