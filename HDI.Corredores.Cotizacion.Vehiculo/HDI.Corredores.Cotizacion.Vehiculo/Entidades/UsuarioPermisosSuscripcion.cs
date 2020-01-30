namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    //
    // Resumen:
    //     contiene los datos del usuario autorizador, para usar sus permisos en la suscripcion
    public struct UsuarioPermisosSuscripcion
    {
        //
        // Resumen:
        //     Devuelve o Establece el Usuario
        public string Usuario { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Oficina
        public string Nombre { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece la Oficina
        public string Oficina { get; set; }
        //
        // Resumen:
        //     Devuelve o Establece el Tipo de Usuario
        public int TipoUsuario { get; set; }

    }
}