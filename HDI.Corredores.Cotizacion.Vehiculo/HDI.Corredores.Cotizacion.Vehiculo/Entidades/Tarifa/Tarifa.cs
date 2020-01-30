using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class Tarifa
    {
        public int TAR_TARIFAID { get; set; }
        public string TAR_DESCRIPCION { get; set; }
        public int TAR_VERSION { get; set; }
        public int VAN_VERSION { get; set; }
        public int VMOD_VERSION { get; set; }
        public int TAMI_VERSION { get; set; }
        public int TVAR_VERSION { get; set; }
        public int FZON_VERSION { get; set; }
        public int TVARV_VERSION { get; set; }
        public int ATFC_DerechoDePolizaAnual { get; set; }
        public int ATCFact_PlanPagos { get; set; }
    }
}
