using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos
{
    public class DataMarca : IDataMarca
    {
        #region Constantes

        #endregion

        #region Atributos
        private readonly ServiceConfiguration Configuracion;
        private readonly MarcaDAO _MarcaDao;        
        #endregion

        #region Propiedades

        #endregion

        public DataMarca(IOptions<ServiceConfiguration> configuracion)
        {
            Configuracion = configuracion.Value;
            _MarcaDao = new MarcaDAO(configuracion);
            
        }

        public DataTable RecuperarMarcas(int tipoVehiculoID, int anio, int versionModelo, string usuario)
        {
            return _MarcaDao.RecuperarMarcas(tipoVehiculoID, anio, versionModelo, usuario);
        }
    }
}
