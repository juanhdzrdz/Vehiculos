namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.Core
{
    public class SP
    {
        public struct Pruebas
        {
            public const string Usp_Uno_GrlPruebaReciboArq_ObtAll = "Usp_Uno_GrlPruebaReciboArq_ObtAll"; //Select All
            public const string Usp_Uno_GrlPruebaReciboArq_ObtByNumRec = "Usp_Uno_GrlPruebaReciboArq_ObtByNumRec"; //Select by NumRec
            public const string Usp_Uno_GrlPruebaReciboArq_Ins = "Usp_Uno_GrlPruebaReciboArq_Ins"; //Insert
            public const string Usp_Uno_GrlPruebaReciboArq_Act = "Usp_Uno_GrlPruebaReciboArq_Act"; //Update
            public const string Usp_Uno_GrlPruebaReciboArq_Eli = "Usp_Uno_GrlPruebaReciboArq_Eli"; //Delete
        }

        public struct Vehiculo
        {
            public const string CSTR_USP_AUT_EMI_VEHICULOCARAC= "USP_AUT_EMI_VEHICULOCARAC";
            public const string USP_AUT_EMI_GET_MARCAS = "USP_AUT_EMI_GET_MARCAS";
        }

        public struct ConfigAplicacion
        {
            public const string usp_uno_obtieneConfigAplicacion = "USP_UNO_ObtieneConfigAplicacion";
        }

        public struct GetDatosTarifa
        {
            public const string usp_aut_emi_vehiculoCarac = "USP_AUT_EMI_VEHICULOCARAC";
            public const string usp_aut_ObtenerDatosPol99 = "USP_AUT_ObtenerDatosPol99";
            public const string usp_aut_nte_obtenerV1 = "USP_AUT_NTE_ObtenerV1";
            public const string usp_aut_nte_obtenerV2 = "USP_AUT_NTE_ObtenerV2";
        }
    }
}
