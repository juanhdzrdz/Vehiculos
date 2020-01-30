using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Marca;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Modelo;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Comun;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy;
using HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.API.Controllers;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Constantes;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public class NegocioVehiculo : INegocioVehiculo
    {
        #region Constantes
        private Versiones ConvierteDataTableAVersiones(DataTable dtVersiones)
        {
            Versiones versiones = null;
            ServicioVehiculo.Entidades.Version version = null;
            try
            {
                //Valída que la tabla tenga información.
                if (dtVersiones != null && dtVersiones.Rows.Count > 0)
                {
                    versiones = new Versiones();
                    foreach (DataRow drVersion in dtVersiones.Rows)
                    {
                        version = new ServicioVehiculo.Entidades.Version();
                        version.Clave = Convert.ToString(drVersion[COLUMNA.CAM.VERSION]);
                        version.Descripcion = Convert.ToString(drVersion[COLUMNA.CAM.VERSION]);
                        versiones.Add(version);
                    }
                }

                return versiones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                version = null;
            }
        }

        #endregion
        public ServicioVehiculo.Entidades.Mensaje CrearMensajeError(int idMensaje, String valor, String descripcion)
        {
            try
            {
                return new ServicioVehiculo.Entidades.Mensaje { IdMensaje = idMensaje, descripcion = descripcion, valor = valor };
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
        #region Atributos
        private readonly ServiceConfiguration Configuracion;
        private readonly IDatosVehiculo DatosVehiculo;
        private readonly IServicioConfiguracionNT ServicioConfiguracionNT;
        private readonly INegocioMarca _NegocioMarca;
        private readonly INegocioSuma _NegocioSuma;

        ServicioVehiculo.EventosIntegracion.Comun.Funciones comun = new ServicioVehiculo.EventosIntegracion.Comun.Funciones();

        #endregion

        #region Propiedades

        #endregion

        #region Constructores
        public NegocioVehiculo(IOptions<ServiceConfiguration> configuracion, IDatosVehiculo datosvehiculo, IServicioConfiguracionNT servicioConfiguracionNT, INegocioMarca negocioMarca)
        {
            Configuracion = configuracion.Value;
            DatosVehiculo = datosvehiculo;
            ServicioConfiguracionNT = servicioConfiguracionNT;
            _NegocioMarca = negocioMarca;
        }
        #endregion

        #region Metodos

        public ResponseDeterminaRiesgoCarga DeterminaRiesgoCarga(RequestDeterminaRiesgoCarga request)
        {
            ResponseDeterminaRiesgoCarga response = new ResponseDeterminaRiesgoCarga();
            

            int riesgoCarga = CLAVE.RIESGOCARGA.NO_APLICA;
            string[] configuracionesRiesgoCargaTipoA;

            try
            {
                configuracionesRiesgoCargaTipoA = ServicioConfiguracionNT.ObtenerConfigAplicacion("ConfiguracionRiesgoCargaTipoA").ToString().Split(';'); //Functions.ObtenerAppSetting("ConfiguracionRiesgoCargaTipoA").Split(';');

                foreach (string configuracion in configuracionesRiesgoCargaTipoA)
                {
                    string[] configuracionRiesgoCargaTipoA = configuracion.Split(',');

                    if (request.CliNip == configuracionRiesgoCargaTipoA[0].ToString())
                        if (configuracionRiesgoCargaTipoA.Contains(request.IdPaquete.ToString()) && (request.Uso == 4584 || request.Uso == 0))
                        {
                            riesgoCarga = CLAVE.RIESGOCARGA.TIPO_A;
                            //comun.AgregaMensaje(response.Mensajes, "Se establece riesgo de carga TIPO A", string.Empty, 0);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                //comun.AgregaMensaje(response.Mensajes, ex.Message.ToString(), ex.StackTrace.ToString(), 0);
            }
            response.IdRiesgoCarga = riesgoCarga;

            return response;
        }

        public ObtenerMarcasResponse ObtenerMarcas(ObtenerMarcasRequest request)
        {
            ObtenerMarcasResponse response = new ObtenerMarcasResponse();
            if (request.IdNegocio!=null &&request.IdNegocio.Trim()!=String.Empty && request.IdNegocio.Length > 1)
            {
                response.ListaMarcas = _NegocioMarca.ObtenerMarcasPorNegocio(request.IdModelo, request.IdTipoVehiculo, request.IdNegocio);
            }
            else
            {
                response.ListaMarcas = _NegocioMarca.ObtenerMarcas(request.IdModelo, request.IdTipoVehiculo, request.usuario);
            }

            if (response.ListaMarcas == null)
            {
                response.ListaMarcas = new Marcas();
            }

            return response;
        }

        public ObtenerModelosResponse ObtenerModelos(ObtenerModelosRequest request)
        {
            ObtenerModelosResponse response = new ObtenerModelosResponse();
            response.ListaModelos = DatosVehiculo.CargaGeneral(request);
            return response;
        }

        public ResponseObtenerVersiones ObtenerVersiones(RequestObtenerVersiones request)
        {

            ResponseObtenerVersiones response = new ResponseObtenerVersiones();
            CaracteristicasVehiculoPresenter presenter = null;
            string cadenaVersiones = string.Empty;
            DataTable dtVersiones = null;
            DataRow tarifa = null;
            try
            {

                if (tarifa != null && tarifa[COLUMNA.TAR.ID] != null && tarifa[COLUMNA.TAR.ID].ToString().Trim() != string.Empty
                                   && Convert.ToInt32(tarifa[COLUMNA.TAR.ID]) > 0)
                {

                    //Se obtiene la cadena de versiones
                    cadenaVersiones = CotizacionLinea.ObtenerVersionesParaTarificacion(tarifa);

                    presenter = new CaracteristicasVehiculoPresenter();

                    //Se obtienen las versiones de los vehículos, ya tomando en cuenta la primer tarífa.
                    dtVersiones = presenter.RecuperarVersiones(request);


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dtVersiones = null;
                presenter = null;
                tarifa = null;
            }

            return response;
        }

        public DataTable ObtenerVersionesPorNegocioController(int idTipoVehiculo, int idMarca, string idTipo, int idModelo, string idNegocio)
        {
            CotizadorEnLineaPresenter presenter = null;
            CaracteristicasVehiculoPresenter caracPresenter = null;
            DataTable dtVersiones = null;
            DataTable configuracionNegocio = null;
            DataRow drConfiguracion = null;
            string cadenaVersiones = string.Empty;

            try
            {
                //Inicializa la información y objetos usados.
                presenter = new CotizadorEnLineaPresenter();

                configuracionNegocio = presenter.ObtenerConfiguracionNegocio(idNegocio, "");
                drConfiguracion = configuracionNegocio.Rows[0];

                if (drConfiguracion != null && drConfiguracion["Tar_TarifaId"] != null && drConfiguracion["Tar_TarifaId"].ToString().Trim() != string.Empty
                                   && Convert.ToInt32(drConfiguracion["Tar_TarifaId"]) > 0
                                   && drConfiguracion["Tar_Version"] != null && drConfiguracion["Tar_Version"].ToString().Trim() != string.Empty
                                   && Convert.ToInt32(drConfiguracion["Tar_Version"]) >= 0
                                   && drConfiguracion["cli_nip"].ToString().Trim() != string.Empty

                   )
                {
                    DataTable tarifa = presenter.ObtenerTarifa(drConfiguracion["cli_nip"].ToString().Trim(), Convert.ToInt32(drConfiguracion["Tar_TarifaId"]), Convert.ToInt32(drConfiguracion["Tar_Version"]), null);

                    if (tarifa.Rows.Count > 0)
                    {
                        //Se obtiene la cadena de versiones
                        cadenaVersiones = CotizacionLinea.ObtenerVersionesParaTarificacion(tarifa.Rows[0]);

                        caracPresenter = new CaracteristicasVehiculoPresenter();

                        //Se obtienen las versiones de los vehículos, ya tomando en cuenta la primer tarífa.
                        dtVersiones = caracPresenter.RecuperarVersiones(idTipoVehiculo, idMarca, idTipo, idModelo, DateTime.Now, cadenaVersiones, "");
                    }
                }

                return dtVersiones;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                presenter = null;
                caracPresenter = null;
                dtVersiones = null;
            }
        }

        

        #endregion
    }
}
