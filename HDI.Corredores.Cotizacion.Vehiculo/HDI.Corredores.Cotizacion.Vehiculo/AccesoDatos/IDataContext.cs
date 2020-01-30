using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System.Collections.Generic;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos
{
    public interface IDataContext
    {
        string GetDatoVariables();

        List<Recibo> GetAllRecibos();
        Recibo ReadReciboByNumRec(Recibo recibo);
        int CreateRecibo(Recibo recibo);
        void UpdateRecibo(Recibo recibo);
        void DeleteRecibo(Recibo recibo);

        List<Tb_Bitacora_GrlBitacora> GetLogMessages();
        Tb_Bitacora_GrlBitacora GetLogMessageByID(int id);
    }
}
