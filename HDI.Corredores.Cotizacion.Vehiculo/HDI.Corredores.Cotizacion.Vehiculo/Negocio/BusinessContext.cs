using HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public class BusinessContext : IBusinessContext
    {
        private readonly ServiceConfiguration Configuration;
        private readonly IDataContext DataContext;

        public BusinessContext(IOptions<ServiceConfiguration> configuration, IDataContext dataContext)
        {
            Configuration = configuration.Value;
            DataContext = dataContext;
        }

        public string GetBusinessVariable()
        {
            return "Variable Negocio: " + Configuration.VariableNegocio;
        }

        public string GetDataVariable()
        {
            return DataContext.GetDatoVariables();
        }

        public List<Recibo> ReadAllRecibos()
        {
            return DataContext.GetAllRecibos();
        }

        public Recibo ReadReciboByNumRec(int numRec)
        {
            return DataContext.ReadReciboByNumRec(new Recibo { NumRec = numRec });
        }

        public Recibo ReadReciboByNumRec(Recibo recibo)
        {
            return DataContext.ReadReciboByNumRec(recibo);
        }

        public int CreateRecibo(Recibo recibo)
        {
            return DataContext.CreateRecibo(recibo);
        }

        public void UpdateRecibo(Recibo recibo)
        {
            DataContext.UpdateRecibo(recibo);
        }

        public void DeleteRecibo(Recibo recibo)
        {
            DataContext.DeleteRecibo(recibo);
        }

        public List<Tb_Bitacora_GrlBitacora> GetLogMessages()
        {
            return DataContext.GetLogMessages();
        }

        public Tb_Bitacora_GrlBitacora GetLogMessageByID(int id)
        {
            return DataContext.GetLogMessageByID(id);
        }
    }
}
