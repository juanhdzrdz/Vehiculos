using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos
{
    public class DataContext : IDataContext
    {
        private readonly ServiceConfiguration Configuration;
        private readonly RecibosDAO RecibosDAO;
        private readonly LogDbContext LogDbContext;

        public DataContext(IOptions<ServiceConfiguration> configuration, LogDbContext dbContext)
        {
            Configuration = configuration.Value;
            LogDbContext = dbContext;
            RecibosDAO = new RecibosDAO(configuration);
        }

        public string GetDatoVariables()
        {
            return "Variable de Datos: " + Configuration.VariableDatos;
        }

        public List<Recibo> GetAllRecibos()
        {
            return RecibosDAO.GetAllRecibos();
        }

        public Recibo ReadReciboByNumRec(Recibo recibo)
        {
            return RecibosDAO.GetReciboByNumRec(recibo);
        }

        public int CreateRecibo(Recibo recibo)
        {
            return RecibosDAO.CreateRecibo(recibo);
        }

        public void UpdateRecibo(Recibo recibo)
        {
            RecibosDAO.UpdateRecibo(recibo);
        }

        public void DeleteRecibo(Recibo recibo)
        {
            RecibosDAO.DeleteRecibo(recibo);
        }

        public Tb_Bitacora_GrlBitacora GetLogMessageByID(int id)
        {
            return LogDbContext.Tb_Bitacora_GrlBitacora.Where(w => w.Bit_ID == id).First();
        }

        public List<Tb_Bitacora_GrlBitacora> GetLogMessages()
        {
            return LogDbContext.Tb_Bitacora_GrlBitacora.ToList();
        }
    }
}
