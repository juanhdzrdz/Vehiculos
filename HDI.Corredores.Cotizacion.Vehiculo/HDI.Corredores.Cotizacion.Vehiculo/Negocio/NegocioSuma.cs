using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy;
using HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using Microsoft.Extensions.Options;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio
{
    public class NegocioSuma : INegocioSuma
    {
        #region Propiedades
        private readonly ServiceConfiguration Configuracion;
        private readonly IDatosVehiculo DatosVehiculo;
        private readonly IServicioAgente ServicioAgente;
        private readonly INegocioSuma _NegocioSuma;
        #endregion

        #region Constructores
        public NegocioSuma(IOptions<ServiceConfiguration> configuracion, IDatosVehiculo datosvehiculo, IServicioAgente servicioAgente)
        {
            Configuracion = configuracion.Value;
            DatosVehiculo = datosvehiculo;
            ServicioAgente = servicioAgente;
        }
        #endregion

        public DataTable ObtenerTarifas(string agenteTaf)
        {
            if (agenteTaf.EsNoVacia())
                return this._NegocioSuma.ObtenerTarifas(agenteTaf);
            else
                return null;
        }

        public Usuario ObtenerUsuario(string usuario)
        {
            throw new NotImplementedException();
        }

        public ResponseObtenerSumaAsegurada ObtenerSumaAsegurada(RequestObtenerSumaAsegurada request)
        {
            //Se obtiene el valor factura del V2
            ResponseObtenerSumaAsegurada response = new ResponseObtenerSumaAsegurada();

            RequestObtenerSumaAsegurada requestSumas = new RequestObtenerSumaAsegurada();

            requestSumas.AgenteNIPs = request.AgenteNIPs;
            requestSumas.ClaveOficina = request.ClaveOficina;
            requestSumas.ClaveVehiculo = request.ClaveVehiculo;
            requestSumas.Modelo = request.Modelo;
            requestSumas.ModeloSpecified = true;
            requestSumas.TipoDocto = request.TipoDocto;

            List<SumasAseguradas> sumasAseguradas = new List<SumasAseguradas>();
            List<Entidades.Mensaje> errores = new List<Entidades.Mensaje>();
            Usuario usuarioRegistrado = ObtenerUsuario(requestSumas.AgenteNIPs);
            Agente agente = ObtenerAgenteXUsuario(usuarioRegistrado, errores);
            DataTable dtTarifas = ObtenerTarifas(agente.NIP);
            requestSumas.VmodVersionTarifa = int.Parse(dtTarifas.Rows[0]["VMOD_VERSION"].ToString());
            requestSumas.VmodVersionTarifaSpecified = true;
            requestSumas.ClaveOficina = agente.AgenciaID;
            DataTable resultados = ObtenerSumaAseguradas(request);


            response.SumaAseguradas = new SumasAseguradas();
            int i = 0;
            foreach (DataRow row in resultados.Rows)
            {
                SumasAseguradas valoresSumasAseguradas = new SumasAseguradas();
                valoresSumasAseguradas.DescripcionSumaAsegurada = row["DescripcionSumaAsegurada"].ToString();
                valoresSumasAseguradas.SumasAsegurada = decimal.Parse(row["SumaAsegurada"].ToString());
                response.SumaAseguradas = valoresSumasAseguradas;
                i++;
            }

            return response;
        }

        public DataTable ObtenerSumaAseguradas(RequestObtenerSumaAsegurada request)
        {
            DataTable tabla = null;

            string clave = "ObtenerSumasAsegurada|" + request.AgenteNIPs + request.ClaveOficina + request.ClaveVehiculo + request.Modelo + request.TipoDocto + request.VmodVersionTarifa;

            TimeSpan tiempoExpiracion = new TimeSpan(40, 10, 0);

            tabla = ObtenerSumaAseguradas(request);
            return tabla;

        }

        public Agente ObtenerAgenteXUsuario(Usuario usuario, List<ServicioVehiculo.Entidades.Mensaje> errores)
        {
            Agente agente = new Agente();
            try
            {
                if (usuario != null)
                {
                    agente = (Agente)ServicioAgente.ObtenerAgente(usuario.Nip, null);
                    if (agente == null)
                        errores.Add(CrearMensajeError(errores.Count + 1, "ObtenerAgenteXUsuario", "Agente no válido"));
                }
                else
                {
                    errores.Add(CrearMensajeError(errores.Count + 1, "ObtenerAgenteXUsuario", "Usuario no válido"));
                }

                return agente;
            }
            catch (Exception ex)
            {
                errores.Add(CrearMensajeError(errores.Count + 1, "ObtenerAgenteXUsuario", ex.Message));
                return agente;
            }
        }
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
