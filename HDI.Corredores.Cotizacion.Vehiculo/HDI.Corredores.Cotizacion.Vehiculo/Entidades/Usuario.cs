using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [DataContract(Namespace = "http://hdi.com/Uno.Servicios")]
    public class Usuario
    {
        [DataMember]
        public ValidacionUsuario.ValidacionEstatus EstatusUsuario;


        [DataMember]
        public int TipoUsuario { get; set; }
        [DataMember]
        public TiposUsuario TipoUser { get; set; }
        [DataMember]
        public string TdIdDesp { get; set; }
        [DataMember]
        public string SSO { get; set; }
        [DataMember]
        public string PreguntaContrasenia { get; set; }
        [DataMember]
        public int NumIntentosLogin { get; set; }
        [DataMember]
        public string NombreProveedor { get; set; }
        [DataMember]
        public string NombreCompleto { get; set; }
        [DataMember]
        public string Nip { get; set; }
        [DataMember]
        public bool IsReseted { get; set; }
        [DataMember]
        public bool IsDeclined { get; set; }
        [DataMember]
        public DateTime FechaUltimoLogueo { get; set; }
        [DataMember]
        public DateTime FechaUltimoDesbloqueo { get; set; }
        [DataMember]
        public DateTime FechaUltimoCambioContrasenia { get; set; }
        [DataMember]
        public DateTime FechaUltimaActividad { get; set; }
        [DataMember]
        public DateTime FechaCreacion { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool Disponible { get; set; }
        [DataMember]
        public string DetalleEstatus { get; set; }
        [DataMember]
        public bool Desbloqueado { get; set; }
        [DataMember]
        public string Contrasenia { get; set; }
        [DataMember]
        public bool Aprobado { get; set; }
        [DataMember]
        public string Agencia { get; set; }
        [DataMember]
        public bool Activo { get; set; }
        [DataMember]
        public string UsuarioLogin { get; set; }
        [DataMember]
        public List<Permiso> Permisos { get; set; }
    }
}
