using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class RequestDeterminaRiesgoCarga
    {
        private string idUsuario; 
        private int uso;
        private string cliNip;
        private int idPromocion; 
        private int idPaquete;
        
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Uso { get => uso; set => uso = value; }
        public string CliNip { get => cliNip; set => cliNip = value; }
        public int IdPromocion { get => idPromocion; set => idPromocion = value; }
        public int IdPaquete { get => idPaquete; set => idPaquete = value; }
        
    }
}
