namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public interface ICaracteristicaEspVehiculo
    {
        string DescRemolque { get; set; }
        string DescRiesgoCarga { get; set; }
        string DescServicio { get; set; }
        string DescTonelaje { get; set; }
        string DescUso { get; set; }
        string DescZonaCirculacion { get; set; }
        int LugarCirculacion { get; set; }
        int Remolque { get; set; }
        int RiesgoCarga { get; set; }
        int Servicio { get; set; }
        int Tonelaje { get; set; }
        int Uso { get; set; }
        string IdDescripcionRiesgoCarga { get; set; }
        string DescDescripcionRiesgoCarga { get; set; }
    }
}