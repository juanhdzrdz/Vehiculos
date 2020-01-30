namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    //
    public interface IAgente
    {
        //
        // Resumen:
        //     Devuelve o Establece el Id de la Agencia
        string AgenciaID { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si el IVA es Modificable
        bool IsSeleccionIVA { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el NIP del Agente
        string NIP { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el nombre del agente
        string Nombre { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el RFC
        string RFC { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el tipo de agente
        string Tipo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la zona se Ciculacion de Vehiculos Residentes
        int ZonaCirculacionVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la zona se Ciculacion de Vehiculos Residentes
        int ZonaCirculacionCamiones { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Tipo de Cedula
        string TipoCedula { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si Aplica IVA Fronterizo
        bool AplicaIVAFronterizo { get; set; }

        //
        // Resumen:
        //     Inicializa la clase con la información proporcionada en la interfaz
        void Inicializa(IAgente agente);
    }
}