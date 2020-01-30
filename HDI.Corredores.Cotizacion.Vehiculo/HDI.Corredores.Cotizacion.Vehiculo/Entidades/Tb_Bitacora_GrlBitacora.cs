using System;
using System.ComponentModel.DataAnnotations;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class Tb_Bitacora_GrlBitacora
    {
        [Key]
        public int Bit_ID { get; set; }

        public int Bit_PriVal { get; set; }

        public int Bit_Facility { get; set; }

        public int Bit_Severity { get; set; }

        public int Bit_SyslogVersion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Bit_CreationDate { get; set; }

        public string Bit_Hostname { get; set; }

        public string Bit_ApplicationName { get; set; }

        public string Bit_ProcessId { get; set; }

        public string Bit_MessageId { get; set; }

        public string Bit_StructuredData { get; set; }

        public string Bit_Message { get; set; }
    }
}