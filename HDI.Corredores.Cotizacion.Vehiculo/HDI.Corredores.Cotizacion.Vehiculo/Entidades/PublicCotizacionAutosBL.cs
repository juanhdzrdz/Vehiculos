using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades.Constantes;


namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class PublicCotizacionAutosBL
    {

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

        public Versiones ObtenerVersionesPorNegocio(int idTipoVehiculo, int idMarca, string idTipo, int idModelo, string idNegocio)
        {
            Versiones response = null;
            DataTable dtVersiones = null;

            try
            {
                //Se obtienen las versiones de los vehículos, ya tomando en cuenta la primer tarífa.
                dtVersiones = ObtenerVersionesPorNegocioController(idTipoVehiculo, idMarca, idTipo, idModelo, idNegocio);

                //Convierte la tabla obtenida en el objeto que será devuelto.
                response = this.ConvierteDataTableAVersiones(dtVersiones);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dtVersiones = null;
            }

            return response;
        }

        private Versiones ConvierteDataTableAVersiones(DataTable dtVersiones)
        {
            Versiones versiones = null;
            Version version = null;
            try
            {
                //Valída que la tabla tenga información.
                if (dtVersiones != null && dtVersiones.Rows.Count > 0)
                {
                    versiones = new Versiones();
                    foreach (DataRow drVersion in dtVersiones.Rows)
                    {
                        version = new Version();
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
        public Versiones ObtenerVersiones(int idTipoVehiculo, int idMarca, string idTipo, int idModelo, string usuario)
        {
            CaracteristicasVehiculoPresenter presenter = null;
            string cadenaVersiones = string.Empty;
            DataTable dtVersiones = null;
            Versiones response = null;
            DataRow tarifa = null;
            try
            {
                //Obtiene la tarifa para el usuario firmado.
                tarifa = this.ObtenerPrimerTarifa(usuario);

                if (tarifa != null && tarifa[COLUMNA.TAR.ID] != null && tarifa[COLUMNA.TAR.ID].ToString().Trim() != string.Empty
                                   && Convert.ToInt32(tarifa[COLUMNA.TAR.ID]) > 0)
                {

                    //Se obtiene la cadena de versiones
                    cadenaVersiones = CotizacionLinea.ObtenerVersionesParaTarificacion(tarifa);

                    presenter = new CaracteristicasVehiculoPresenter();

                    //Se obtienen las versiones de los vehículos, ya tomando en cuenta la primer tarífa.
                    dtVersiones = presenter.RecuperarVersiones(idTipoVehiculo, idMarca, idTipo, idModelo, DateTime.Now, cadenaVersiones, usuario);

                    //Convierte la tabla obtenida en el objeto que será devuelto.
                    response = this.ConvierteDataTableAVersiones(dtVersiones);

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

        /// <summary>
        /// Obtiene el valor de la primera tarifa dependiendo del usuario.
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <param name="idTarifa">Identificador de la tarífa</param>
        /// <param name="idVersion">Identificador de la versión.</param>
        /// <param name="vmodVersion">Versión</param>
        private DataRow ObtenerPrimerTarifa(string usuario)
        {
            //UNOMembershipUser user = null;
            Usuario user = null;
            DataTable dtTarifas = null;
            DataRow drTarifa = null;
            try
            {
                //Se obtiene la información del usuario.
                user = ObtenerUsuarioPorID(usuario);// (UNOMembershipUser)SecurityServiceFunctions.GetUser(usuario, true);
                if (user != null)
                {
                    //Obtiene el catálogo de tarifas.
                    dtTarifas = EmisionServiceFunctions.ObtenerTarifas(user.Nip);

                    //Se valída que exista la información de tarifas.
                    if (dtTarifas == null || (dtTarifas != null && dtTarifas.Rows.Count == 0))
                        return null;

                    //Se tomá como válida la primer tarifa.
                    drTarifa = dtTarifas.Rows[0];
                }
                return drTarifa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                user = null;
                dtTarifas = null;
            }
        }

        public Usuario ObtenerUsuarioPorID(string id_usuario)
        {
            return ObtenerUsuarioPorID(id_usuario, 0);
        }

        internal Usuario ObtenerUsuarioPorID(string id_usuario, int idPromocionEspecial)
        {
            string clave = "Usuario-" + id_usuario + "-" + idPromocionEspecial;
            Usuario user = null;

            //ARQ 20141208 - Errores null referencia por cache - INICIO
            if (user == null)
            {
                throw new Exception("No existe usuario en la tabla de membership.");
            }
            //ARQ 20141208 - Errores null referencia por cache - FIN

            return user;
        }

        //public Agente ObtenerAgenteXUsuario(Usuario usuario, List<ServicioVehiculo.Entidades.Mensaje> errores)
        //{
        //    Agente agente = new Agente();
        //    try
        //    {
        //        if (usuario != null)
        //        {
        //            agente = (Agente)ServicioAgente.ObtenerAgente(usuario.Nip);
        //            if (agente == null)
        //                errores.Add(CrearMensajeError(errores.Count + 1, "ObtenerAgenteXUsuario", "Agente no válido"));
        //        }
        //        else
        //        {
        //            errores.Add(CrearMensajeError(errores.Count + 1, "ObtenerAgenteXUsuario", "Usuario no válido"));
        //        }

        //        return agente;
        //    }
        //    catch (Exception ex)
        //    {
        //        errores.Add(CrearMensajeError(errores.Count + 1, "ObtenerAgenteXUsuario", ex.Message));
        //        return agente;
        //    }
        //}

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
    }
}
