namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public interface IUCCaracteristicasVehiculoView
    {


        CotizacionLinea CotizacionEnLinea
        {
            get;
        }

        bool EsCotizadorLinea
        {
            get;
        }

        int VersionModeloTarifa
        {
            get;
        }
    }
}