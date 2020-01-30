using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using Microsoft.EntityFrameworkCore;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos
{
    public class LogDbContext : DbContext
    {
        public LogDbContext(DbContextOptions<LogDbContext> options)
            : base(options)
        {

        }

        public DbSet<Tb_Bitacora_GrlBitacora> Tb_Bitacora_GrlBitacora { get; set; }
    }
}