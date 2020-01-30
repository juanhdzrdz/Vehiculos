#region Ensamblado UNO.Services.Emision.BusinessEntities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\Juan\Desktop\UNO\Proyectos Web\PublicServices-branch\Public.Services.Autos\Source\Business Logic\Public.Services.Autos.BusinessLogic\bin\Debug\UNO.Services.Emision.BusinessEntities.dll
#endregion

using System;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    //
    // Resumen:
    //     Contiene las condiciones del vehiculo
    public class CaracteristicaEspVehiculo : ICaracteristicaEspVehiculo
    {
        public string DescZonaCirculacion { get; set; }
        public string DescDescripcionRiesgoCarga { get; set; }
        public string IdDescripcionRiesgoCarga { get; set; }
        public string DescRemolque { get; set; }
        public string DescTonelaje { get; set; }
        public string DescServicio { get; set; }
        public string DescDescripcionRiesgo { get; set; }
        public string DescRiesgoCarga { get; set; }
        public string DescUso { get; set; }
        public int IdConductoCobro { get; set; }
        public int Tonelaje { get; set; }
        public int DescripcionRiesgo { get; set; }
        public int RiesgoCarga { get; set; }
        public int Remolque { get; set; }
        public int Servicio { get; set; }
        public int Uso { get; set; }
        public int LugarCirculacion { get; set; }
        public string EstadoCirculacion { get; set; }

    }
}