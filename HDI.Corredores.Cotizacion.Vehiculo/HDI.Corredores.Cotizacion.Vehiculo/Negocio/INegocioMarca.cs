using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public interface INegocioMarca
    {
        Marcas ObtenerMarcasPorNegocio(int idModelo, int idTipoVehiculo, string idNegocio);

        Marcas ObtenerMarcas(int idModelo, int idTipoVehiculo, string usuario);

    }
}
