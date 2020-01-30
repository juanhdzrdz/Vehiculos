using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos
{
    public interface IDataMarca
    {
        DataTable RecuperarMarcas(int tipoVehiculoID, int anio, int versionModelo, string usuario);
    }
}
