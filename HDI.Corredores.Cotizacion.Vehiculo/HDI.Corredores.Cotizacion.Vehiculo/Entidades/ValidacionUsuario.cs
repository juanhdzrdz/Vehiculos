using System;
using System.Runtime.Serialization;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    [DataContract(Namespace = "http://hdi.com/Uno.Servicios")]
    public static class ValidacionUsuario
    {
        [DataContract]
        [Flags]
        public enum ValidacionEstatus
        {
            SSOCorrupto = -7,
            SSOInactivo = -6,
            SSONoExiste = -5,
            UsuarioRechazado = -4,
            ContraseñaInvalida = -3,
            UsuarioBloqueado = -2,
            UsuarioNoAprobado = -1,
            UsuarioNoEncontrado = 0,
            UsuarioValido = 1
        }
    }
}
