using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.DAOs;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos
{
    public class DatosVehiculo : IDatosVehiculo
    {
        #region Constantes

        #endregion

        #region Atributos
        private readonly ServiceConfiguration Configuracion;
        private readonly VehiculoDAO vehiculoDAO;
        private readonly ModeloDAO _ModeloDAO;
        #endregion

        #region Propiedades

        #endregion

        public DatosVehiculo(IOptions<ServiceConfiguration> configuracion)
        {
            Configuracion = configuracion.Value;
            vehiculoDAO = new VehiculoDAO(configuracion);
            _ModeloDAO = new ModeloDAO(configuracion);
        }

        public Modelos CargaGeneral(ObtenerModelosRequest datos)
        {
            return _ModeloDAO.CargaGeneral(datos);
        }
    }
}
