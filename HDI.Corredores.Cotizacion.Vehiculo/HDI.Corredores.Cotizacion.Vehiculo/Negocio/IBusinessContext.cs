using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System.Collections.Generic;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public interface IBusinessContext
    {
        string GetBusinessVariable();
        string GetDataVariable();

        int CreateRecibo(Recibo recibo);
        List<Recibo> ReadAllRecibos();
        Recibo ReadReciboByNumRec(int numRec);
        Recibo ReadReciboByNumRec(Recibo recibo);
        void UpdateRecibo(Recibo recibo);
        void DeleteRecibo(Recibo recibo);

        List<Tb_Bitacora_GrlBitacora> GetLogMessages();
        Tb_Bitacora_GrlBitacora GetLogMessageByID(int id);
    }
}
