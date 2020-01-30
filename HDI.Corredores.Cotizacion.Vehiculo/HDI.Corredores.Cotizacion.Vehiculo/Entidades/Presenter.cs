namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public abstract class Presenter<TView>
    {
        public TView View { get; set; }

    }
}