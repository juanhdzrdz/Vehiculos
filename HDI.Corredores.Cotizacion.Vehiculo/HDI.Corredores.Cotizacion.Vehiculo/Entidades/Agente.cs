using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    //
    // Resumen:
    //     Contiene la información General del Agente
    public class Agente
    {

        //
        // Resumen:
        //     Devuelve o Establece el NIP del Agente
        public string NIP { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el RFC
        public string RFC { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el nombre del agente
        public string Nombre { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Id de la Agencia
        public string AgenciaID { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Nombre de la Agencia
        public string Agencia { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el tipo de agente
        public string Tipo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si el IVA es Modificable
        public bool IsSeleccionIVA { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la zona se Ciculacion de Vehiculos Residentes
        public int ZonaCirculacionVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la zona se Ciculacion de Vehiculos Residentes
        public int ZonaCirculacionCamiones { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Tipo de Cedula
        public string TipoCedula { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si Aplica IVA Fronterizo
        public bool AplicaIVAFronterizo { get; set; }
        //
        // Resumen:
        //     Devuelve o establece el tipo de agente
        public string TipoAgente { get; set; }

    }
}
