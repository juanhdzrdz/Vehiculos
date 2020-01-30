#region Ensamblado UNO.Services.Emision.BusinessEntities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\Juan\Desktop\UNO\Proyectos Web\PublicServices-branch\Public.Services.Autos\Source\Business Logic\Public.Services.Autos.BusinessLogic\bin\Debug\UNO.Services.Emision.BusinessEntities.dll
#endregion

using System;
using System.Data;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    //
    // Resumen:
    //     Contiene el resumen de los datos de la cotización
    public class ResumenCotizacion 
    {

        //
        // Resumen:
        //     Devuelve o Establece el Modelo
        public int Modelo { get; set; }
        //
        // Resumen:
        //     Devuelve la Información del Vehiculo
        public string InfoVehiculo { get; }
        //
        // Resumen:
        //     Devuelve las Caractetisticas especiales del Vehiculo
        public CaracteristicaEspVehiculo Especiales { get; set; }
        //
        // Resumen:
        //     Devuelve la Descripción Completa del Vehiculo
        public string DescripcionCompletaVehiculo { get; }
        //
        // Resumen:
        //     Devuelve o Establece el Modelo anterior asignado
        public int ModeloAnt { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Tipo de Vehiculo Anterior
        public int TipoVehiculoAnt { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la descripción del riego de la carga
        public string DescDescripcionRiesgoCarga { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Id de la descripción de la Carga
        public string IdDescripcionRiesgoCarga { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripción del vehiculo
        public string DescDescripcion { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripción de Versión
        public string DescVersion { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripción de Tipo
        public string DescTipo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripción de Marca
        public string DescMarca { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripción de tipo de vehiculo
        public string DescTipoVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la cantidad de Pasajeros
        public int Pasajeros { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave de la Transmision
        public int Transmision { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave de la version
        public string Version { get; set; }
        //
        // Resumen:
        //     Devuelve la información del vehiculo resumida
        public string InfoVehiculoCorta { get; }
        //
        // Resumen:
        //     Devuelve o Establece si cambio el tipo de vehiculo
        public bool CambioTipoVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si cambio el modelo del vehiculo
        public bool CambioModelo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave de la Circulacion
        public int LugarCirculacion { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece las Placas
        public string Placa { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Numero de Serie del Motor
        public string NumSerieMotor { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Numero de Serie del Vehiculo
        public string NumSerieVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave de las Placas
        public string Placas { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave del Numero de Motor
        public string NumMotor { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripcion del remolque
        public string DescRemolque { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripcion del tonelaje
        public string DescTonelaje { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave del Tipo
        public string Tipo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripcion del servicio
        public string DescServicio { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripcion del uso
        public string DescUso { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripcion de la Zona Ciruclacion
        public string DescZonaCirculacion { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave tonelaje
        public int Tonelaje { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave Riego de la Carga
        public int RiesgoCarga { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave del remolque
        public int Remolque { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave del Servicio
        public int Servicio { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la clave del Uso
        public int Uso { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Descripcion del riego por la carga
        public string DescRiesgoCarga { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Marca
        public int Marca { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Engomado del vehiculo
        public string AnexoEngomado { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Clave del Fabricante
        public int IdFabricante { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Equipo Especial, para Robo Total
        public decimal SumaAseguradaEERT { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Equipo Especial, para Daños Materiales
        public decimal SumaAseguradaEEDM { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Adaptaciones y Converciones, para Robo
        //     Total
        public decimal SumaAseguradaACRT { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Adaptaciones y Converciones, para Daños
        //     Materiales
        public decimal SumaAseguradaACDM { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Responsabilidad Civil
        public decimal SumaAseguradaRC { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Gastos Medicos
        public decimal SumaAseguradaGM { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si
        public bool MasDiezPorciento { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Forma de PAgo
        public string FormaPago { get; set; }
        //
        public string SumaAseguradaV { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Suma Asegurada de Daños por la Carga
        public decimal SumaAseguradaDPC { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Tipo de ajuste
        public int AjusteTipo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Ajuste
        public decimal Ajuste { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece los deducibles de Daños Materiales y Robo Total
        public string DeduciblesDMyRT { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece las Coberturas Opcionales
        public string CoberturasOpcionales { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si cuanta con la cobertura de accidentes al conductor
        public bool CoberturaAccidenteConductor { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Nombre del Paquete
        public string Paquete { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Texto de Tipo de Suma Asegurada
        public string TipoSumaAsegurada { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el color
        public string Color { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Prima Neta
        public decimal PrimaNeta { get; set; }
        //
        // Resumen:
        //     Decuelve o Establece el Derecho de Poliza
        public decimal DerechoPoliza { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Tipo de Vehiculo
        public int TipoVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Clave del vehiculo
        public string ClaveVehiculo { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si se contiene la información minima requerida
        public bool InformacionCorrecta { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece si existen los datos minimos para calculo
        public bool InformacionCalculoCorrecta { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Recargo por Pago Fraccionado
        public decimal RecargoPagoFracc { get; set; }
        //
        public DataTable ReglasCoberturasPaquete { get; set; }
        //
        // Resumen:
        //     monto del primer pago
        public decimal MontoPrimerPago { get; set; }
        //
        // Resumen:
        //     monto del pago subsecuente
        public decimal MontoPagosSubsecuentes { get; set; }
        //
        // Resumen:
        //     Numero de Pagos Subsecuentes
        public int NumeroPagosSubsecuentes { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece Número de Pagos
        public int NumeroPagos { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Monto del IVA
        public decimal MontoIVA { get; set; }
        //
        // Resumen:
        //     Decuelve o Establece el valor del Impuesto de Valor Agregado
        public decimal ValorIVA { get; set; }
        //
        // Resumen:
        //     Decuelve o Establece el Derecho de Poliza
        public decimal TotalPago { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Fecha de Cotizacion
        public string FechaCotizacion { get; set; }

    }
}