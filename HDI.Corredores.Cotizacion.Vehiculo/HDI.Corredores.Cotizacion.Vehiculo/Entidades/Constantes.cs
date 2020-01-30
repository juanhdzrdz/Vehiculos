using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public class Constantes
    {

        //
        // Resumen:
        //     TIPO_TARIFAS
        public struct TIPO_TARIFAS
        {
            public const string TAR = "TAR";

            public const string VAN = "VAN";

            public const string VMOD = "VMOD";

            public const string TAMI = "TAMI";

            public const string TVAR = "TVAR";

            public const string FZON = "FZON";

            public const string TVARV = "TVARV";
        }

        public struct LINEANEGOCIO
        {
            public const string AUTOS_RESIDENTES = "AUTR";
        }

        public struct ValoresSP
        {
            public const int CBYT_SP_RECUPERAR = 4;
            public const int CBYT_SP_BUSCAR = 5;
        }

        public struct Codigo
        {
            public const int Ok = 1;
            public const int Error = 0;
        }

        public struct Mensaje
        {
            public const string Correcto = "OK";
            public const string Error = "ERROR";
        }

        public struct TipoObjecto
        {
            public const string Respuesta = "RESPUESTA";
            public const string Solicitud = "SOLICITUD";
        }

        public struct TiposUsuario
        {
            public const int Empleado = 5050;
            public const int Agente = 5051;
            public const int Despacho = 5052;
            public const int Promotoria = 5066;
        }

        public struct CLAVE
        {
            #region "RIESGOCARGA"
            /// <summary>
            /// Constantes de riesgo de la carga
            /// </summary>
            public struct RIESGOCARGA
            {
                /// <summary>
                /// Riesgo de la Carga  - No aplica (5425)
                /// </summary>
                public const int NO_APLICA = 5425;
                /// <summary>
                /// Riesgo de carga tipo A - Mercancía con reducido grado de peligrosidad en su transporte
                /// </summary>
                public const int TIPO_A = 4607;
            }
            #endregion

            #region "TIPODOCUMENTO"
            public struct TIPODOCUMENTO
            {
                /// <summary>
                /// Poliza (02)
                /// </summary>
                public const string POLIZA = "02";
                /// <summary>
                /// Base (9999)
                /// </summary>
                public const string DOCUMENTO_9999 = "9999";
                /// <summary>
                /// Documento cancela solcitud (33)
                /// </summary>
                public const string CANCELA_SOLICITUD = "33";
                /// <summary>
                /// Documento de Rehabilitacion de Solcitud (37)
                /// </summary>
                public const string REHABILITACION_SOLICITUD = "37";
                /// <summary>
                /// Documento de Renovación  (35)
                /// </summary>
                public const string RENOVACION = "35";
                /// <summary>
                /// documento de alta de CIS en cotizacion
                /// </summary>
                public const string ALTA_DE_CIS_COTIZACION = "09";
                /// <summary>
                /// documento de alta de CIS en OT (6532)
                /// </summary>
                public const int ALTA_DE_CIS_OT = 6532;
                /// <summary>
                /// Documento de Poliza OT (2972)
                /// </summary>
                public const int POLIZA_OT = 2972;
                /// <summary>
                /// Documento de Poliza OT (53)
                /// </summary>
                public const string CAMBIO_DE_CONDICIONES = "53";
            }
            #endregion
        }

        public struct ServiciosExternos
        {
            public const string obtenerConfigAplicacion = "ObtenerConfigAplicacion";
            public const string obtenerAgente = "ObtenerAgente";
        }

        //
        // Resumen:
        //     Contiene los Nombres de Columnas Utilizados
        public struct COLUMNA
        {
            //
            // Resumen:
            //     Nombre de la Columna "DIC_NOM_CONTROL"
            public const string CLIENTNAME = "DIC_NOM_CONTROL";

            //
            // Resumen:
            //     FACTURACION
            public struct FACTURACION
            {
                //
                // Resumen:
                //     canalVenta = "canalVenta"
                public const string canalVenta = "canalVenta";
                //
                // Resumen:
                //     porcentajeFinanciamiento = "porcentajeFinanciamiento"
                public const string porcentajeFinanciamiento = "porcentajeFinanciamiento";
                //
                // Resumen:
                //     titularCuenta = "titularCuenta"
                public const string titularCuenta = "titularCuenta";
                //
                // Resumen:
                //     venceTarjeta = "venceTarjeta"
                public const string venceTarjeta = "venceTarjeta";
                //
                // Resumen:
                //     plaza = "plaza"
                public const string plaza = "plaza";
                //
                // Resumen:
                //     sucursal = "sucursal"
                public const string sucursal = "sucursal";
                //
                // Resumen:
                //     nivelCobro = "nivelCobro"
                public const string nivelCobro = "nivelCobro";
                //
                // Resumen:
                //     nivelCobroID = "nivelCobroID"
                public const string nivelCobroID = "nivelCobroID";
                //
                // Resumen:
                //     samFormaPago = "samFormaPago"
                public const string samFormaPago = "samFormaPago";
                //
                // Resumen:
                //     samFormaPagoID = "samFormaPagoID"
                public const string samFormaPagoID = "samFormaPagoID";
                //
                // Resumen:
                //     samAsegurado = "samAsegurado
                public const string samAsegurado = "samAsegurado";
                //
                // Resumen:
                //     samAseguradoID = "samAseguradoID"
                public const string samAseguradoID = "samAseguradoID";
                //
                // Resumen:
                //     samEmpresa = "samEmpresa"
                public const string samEmpresa = "samEmpresa";
                //
                // Resumen:
                //     samEmpresaID = "samEmpresaID"
                public const string samEmpresaID = "samEmpresaID";
                //
                // Resumen:
                //     numeroCuenta = "numeroCuenta"
                public const string numeroCuenta = "numeroCuenta";
                //
                // Resumen:
                //     mesesSinInteresesID = "mesesSinInteresesID"
                public const string mesesSinInteresesID = "mesesSinInteresesID";
                //
                // Resumen:
                //     tarjetaID = "tarjetaID"
                public const string tarjetaID = "tarjetaID";
                //
                // Resumen:
                //     tarjetahabiente = "titularCuenta"
                public const string tarjetahabiente = "titularCuenta";
                //
                // Resumen:
                //     tipoCuentaID = "tipoCuentaID"
                public const string tipoCuentaID = "tipoCuentaID";
                //
                // Resumen:
                //     tipoCuenta = "tipoCuenta"
                public const string tipoCuenta = "tipoCuenta";
                //
                // Resumen:
                //     bancoID = "bancoID"
                public const string bancoID = "bancoID";
                //
                // Resumen:
                //     banco = "banco"
                public const string banco = "banco";
                //
                // Resumen:
                //     planPagoID = "planPagoID"
                public const string planPagoID = "planPagoID";
                //
                // Resumen:
                //     planPago = "planPago"
                public const string planPago = "planPago";
                //
                // Resumen:
                //     conductoCobroID = "conductoCobroID"
                public const string conductoCobroID = "conductoCobroID";
                //
                // Resumen:
                //     conductoCobro = "conductoCobro"
                public const string conductoCobro = "conductoCobro";
                //
                // Resumen:
                //     monedaID = "monedaID"
                public const string monedaID = "monedaID";
                //
                // Resumen:
                //     moneda = "moneda"
                public const string moneda = "moneda";
                //
                // Resumen:
                //     formaPagoID = "formaPagoID"
                public const string formaPagoID = "formaPagoID";
                //
                // Resumen:
                //     formaPago = "formaPago"
                public const string formaPago = "formaPago";
                //
                // Resumen:
                //     canalVentaID = "canalVentaID"
                public const string canalVentaID = "canalVentaID";
                //
                // Resumen:
                //     tarjeta = "tarjeta"
                public const string tarjeta = "tarjeta";
                //
                // Resumen:
                //     mesesSinIntereses = "mesesSinIntereses"
                public const string mesesSinIntereses = "mesesSinIntereses";
            }
            //
            // Resumen:
            //     Contiene los campos utilizados en la tabla de polizas con estatus en tramite
            public struct DATOSPOLIZA
            {
                //
                // Resumen:
                //     Tabla DATOS POLIZA COLUMNA ID ENDOSO
                public const string ID = "CPOL_ID_POLIZA";
                //
                // Resumen:
                //     Tabla DATOS POLIZA COLUMNA FECHA CAPTURA
                public const string FECHACAPTURA = "CPOL_FEC_CAPTURA";
                //
                // Resumen:
                //     Tabla DATOS POLIZA COLUMNA FECHA TIPO DOCUMENTO
                public const string TIPODOCUMENTO = "CPOL_TIP_DOC";
            }
            //
            // Resumen:
            //     Contiene los campos utilizados en la tabla de estado y ciudad
            public struct ESTADOCIUDAD
            {
                //
                // Resumen:
                //     Tabla de Estado/Ciudad - Columna clave ( CLAVE )
                public const string ID = "CLAVE";
                //
                // Resumen:
                //     Tabla de Estado/Ciudad - Columna Descripcion de Estado ( ESTADO )
                public const string ESTADODESC = "ESTADO";
                //
                // Resumen:
                //     Tabla de Estado/Ciudad - Columna Descripcion de Municipio ( MUNICIPIO )
                public const string CIUDADDESC = "MUNICIPIO";
            }
            //
            // Resumen:
            //     columnas de Descuento y Recargo
            public struct DESCREC
            {
                //
                // Resumen:
                //     Tabla de Descuentos por cobertura - Descuento maximo (MAXIMOPORDESCUENTO)
                public const string DESCUENTO_MAXIMO = "MAXIMOPORCDESCUENTO";
                //
                // Resumen:
                //     Tabla de Descuentos por cobertura - Recargo maximo (MAXIMOPORRECARGO)
                public const string RECARGO_MAXIMO = "MAXIMOPORCRECARGO";
            }
            //
            // Resumen:
            //     Con tiene las Columnas de Periodo Pago
            public struct PERIODOPAGO
            {
                //
                // Resumen:
                //     Tabla Periodo Pago - Descripción (EFP_DESCRIPCIONFORPAG)
                public const string DESCRIPCION = "EFP_DESCRIPCIONFORPAG";
                //
                // Resumen:
                //     Tabla Periodo Pago - Id (EFP_FORMAPAGOID)
                public const string ID = "EFP_FORMAPAGOID";
                //
                // Resumen:
                //     Tabla Periodo Pago - [Id] + [DESCRIPCION] --> (EFP_DESCRIPCIONFORPAG_COMP)
                public const string IDDESCRIPCION = "EFP_DESCRIPCIONFORPAG_COMP";
                //
                // Resumen:
                //     Tabla Periodo Pago - Número de Recibos del Periodo (EFP_TOTALPERIODOS)
                public const string TOTAL_PERIODOS = "EFP_TOTALPERIODOS";
                //
                // Resumen:
                //     Tabla Periodo Pago - Número de Recibos Reales considerando recibos de .1 centavo
                //     (NumeroRecibos)
                public const string NUMERO_RECIBOS = "NumeroRecibos";
            }
            //
            // Resumen:
            //     Contiene los nombres de las columnas de la tabla de deducibles
            public struct DRC
            {
                //
                // Resumen:
                //     Tabla Deducible - Columna Id Deducible ()
                public const string ID = "";
                //
                // Resumen:
                //     Tabla Deducible - Columna Valor Deducible (DRC_VALOR)
                public const string VALOR = "DRC_VALOR";
                //
                // Resumen:
                //     Tabla Deducible - Columna Valor Factor (DRC_FACTOR)
                public const string FACTOR = "DRC_FACTOR";
            }
            //
            // Resumen:
            //     Columna de DESC
            public struct DESC
            {
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna de Descripción de suma asegurada, utilizada
                //     para visualizar la descripcion de suma asegurada de la cobertura. (DESC_SUMA_ASEGURADA)
                public const string SUMA_ASEGURADA = "DESC_SUMA_ASEGURADA";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna de Descripcion Deducible, utilizada para visualizar
                //     la descripcion del deducible.
                public const string DEDUCIBLE = "DESC_DEDUCIBLE";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna de Descripcion Deducible, utilizada para visualizar
                //     la descripcion de la prima
                public const string PRIMA_NETA = "DESC_PRIMA_NETA";
            }
            //
            // Resumen:
            //     Contiene las Columnas de la tabla de Reglas de Cobertura
            public struct RCOB
            {
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Id Regla Cobertura (RCOB_ID_RCOB)
                public const string ID_REGLACOBERTURA = "RCOB_ID_RCOB";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Id Regla Cobertura (RCOB_APLICA_DETALLE)
                public const string APLICA_DETALLE = "RCOB_APLICA_DETALLE";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Suma Asegurada Minima (RCOB_SA_MIN)
                public const string SUMA_ASEGURADA_MINIMA = "RCOB_SA_MIN";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Suma Asegurada Maxima (RCOB_SA_MAX)
                public const string SUMA_ASEGURADA_MAXIMA = "RCOB_SA_MAX";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Incremento (RCOB_INCREMENTO)
                public const string SUMA_ASEGURADA_INCREMENTO = "RCOB_INCREMENTO";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Antiguedad (RCOB_ANTIGUEDADXCOB)
                public const string ANTIGUEDAD = "RCOB_ANTIGUEDADXCOB";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Deducible Default (RCOB_VM_DEDUC_DEFAULT)
                public const string DEDUCIBLE_DEFAULT = "RCOB_VM_DEDUC_DEFAULT";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Deducible Max (RCOB_VM_DEDUC_MAX)
                public const string DEDUCIBLE_MAX = "RCOB_VM_DEDUC_MAX";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Deducible Min (RCOB_VM_DEDUC_MIN)
                public const string DEDUCIBLE_MIN = "RCOB_VM_DEDUC_MIN";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Deducible Max (DEDUCIBLE_MAX_AUTORIZADOR)
                public const string DEDUCIBLE_MAX_AUTORIZADOR = "DEDUCIBLE_MAX_AUTORIZADOR";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Deducible Min (RCOB_VM_DEDUC_MIN)
                public const string DEDUCIBLE_MIN_AUTORIZADOR = "DEDUCIBLE_MIN_AUTORIZADOR";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Aplica Detalle (RCOB_APLICA_DETALLE)
                public const string DETALLE_APLICA = "RCOB_APLICA_DETALLE";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Aplica Detalle (RCOB_POS_IMPRESION)
                public const string POSICION_IMPRESION = "RCOB_POS_IMPRESION";
                //
                // Resumen:
                //     Tabla Regla de Cobertrua - Columna que contiene la lista de deducibles en los
                //     cotizadores (RCOB_DEDUC_COTIZADORES).
                public const string DEDUCIBLES_COTIZADORES = "RCOB_DEDUC_COTIZADORES";
            }
            //
            public struct MOD
            {
                //
                // Resumen:
                //     Tabla de Paquete - Columna Id del Paquete (MOD_ID_MODAL)
                public const string IDPAQUETE = "MOD_ID_MODAL";
                //
                // Resumen:
                //     Tabla de Paquete - Columna Descripción del Paquete (MOD_DESCR)
                public const string PAQUETE = "MOD_DESCR";
                //
                // Resumen:
                //     Tabla de Paquete - Id paquete de alborado
                public const string IDPAQUETEALBORADA = "MOD_CODPAQALB";
                //
                // Resumen:
                //     Tabla de Paquete - Id del Paquete Grupo
                public const string IDPAQUETEGRUPO = "TAB_AGRPMODAL";
                //
                // Resumen:
                //     Tabla de Paquete - DerechoPoliza
                public const string DERECHO_POLIZA = "MOD_DERECHO_POLIZA";
            }
            //
            // Resumen:
            //     Columnas de Coberturas
            public struct COB
            {
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna IdCobertura (COB_ID_COB)
                public const string IDCOBERTURA = "COB_ID_COB";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Descripcion de la Cobertura (COB_DESCRIP)
                public const string COBERTURA = "COB_DESCRIP";
                //
                // Resumen:
                //     Tabla Regla de cobertura - Columna de Descripcion Abreviada (COBERTURA_ABREVIADO)
                public const string COBERTURA_ABREVIADO = "COB_DESC_CORTA";
                //
                // Resumen:
                //     Columna de Tipo de Cobertura (TAB_TIPCOBER)
                public const string TIPO_COBERTURA = "TAB_TIPCOBER";
                //
                // Resumen:
                //     Columna de Grupo suma asegurada especifica si la suma asegurada es 1 admite valor
                //     comercial. (COB_GRUPO_SUM_ASG)
                public const string GRUPO_SUMA_ASEGURADA = "COB_GRUPO_SUM_ASG";
                //
                // Resumen:
                //     Colmna para especifica si la columna es visible (COB_VISIBLE)
                public const string VISIBLE = "COB_VISIBLE";
                //
                // Resumen:
                //     Columna para especifica el maximo de años que acepta la cobertura. (COB_MAX_ANTIGUEDAD)
                public const string MAX_ANTIGUEDAD = "COB_MAX_ANTIGUEDAD";
            }
            //
            // Resumen:
            //     Columnas generales, las cuales no tiene prefijo
            public struct GENERAL
            {
                //
                // Resumen:
                //     Clave
                public const string CLAVE = "Clave";
                //
                // Resumen:
                //     Tabla de Reglas de cobertura - Columna de Valor Monetario de Descuento y Recargo
                //     (DescRec)
                public const string AJUSTE = "DescRec";
                //
                // Resumen:
                //     Tabla Regla de cobertura - Columna (FINAN)
                public const string FINANCIAMIENTO = "FINAN";
                //
                // Resumen:
                //     Tabla Regla de cobertura - Columna "COMISXFINAN"
                public const string COMISION_POR_FINANCIAMIENTO = "COMISXFINAN";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna CES Comisión (CES_COMIS)
                public const string CES_COMIS = "CES_COMIS";
                //
                // Resumen:
                //     Detalle de Cobertura (AuxiliarDetalleCobertura)
                public const string AUXILIAR_DETALLE_COBERTURA = "AuxiliarDetalleCobertura";
                //
                // Resumen:
                //     Deducible de Cobertura (AuxiliarDeducibleCobertura)
                public const string AUXILIAR_DEDUCIBLE_COBERTURA = "AuxiliarDeducibleCobertura";
                //
                // Resumen:
                //     Proveedor de Asistencia (AuxiliarProveedorAsistencia)
                public const string AUXILIAR_PROVEEDOR_ASISTENCIA = "AuxiliarProveedorAsistencia";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Detalle (Detalle)
                public const string DETALLE = "Detalle";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Comisión Total (COMISION_TOTAL)
                public const string COMISION_TOTAL = "COMISION_TOTAL";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna deducibles maximo autorizador (DEDUCIBLES_FIJOS_AUTORIZADOR)
                public const string DEDUCIBLES_FIJOS_AUTORIZADOR = "DEDUCIBLES_FIJOS_AUTORIZADOR";
                //
                // Resumen:
                //     Utilizada de manera general para especificar los deducibles fijos - (DEDUCIBLES_FIJOS)
                public const string DEDUCIBLES_FIJOS = "DEDUCIBLES_FIJOS";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Tipo uma Asegurada (TIPO_SUMA_ASEG)
                public const string TIPO_SUMA_ASEGURADA = "TIPO_SUMA_ASEG";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Prima Comisión (COMISXPRIMA)
                public const string PRIMA_COMISION = "COMISXPRIMA";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Prima Ajustada (PRIMAAJUSTADA)
                public const string PRIMA_AJUSTADA = "PRIMAAJUSTADA";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Prima Anual (PrimaAnual)
                public const string PRIMA_ANUAL = "PrimaAnual";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna PrimaNeta (PrimaNeta)
                public const string PRIMA_NETA = "PrimaNeta";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Suma Asegurada Abierta (SumaAseguradaAbierta)
                public const string SUMA_ASEGURADA_ABIERTA = "SumaAseguradaAbierta";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Suma Asegurada (SumaAsegurada)
                public const string SUMA_ASEGURADA = "SumaAsegurada";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna situacion general (OBLIGATORIA_OPCIONAL)
                public const string OBLIGATORIA_OPCIONAL = "OBLIGATORIA_OPCIONAL";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna situacion general (SITUACION_GENERAL)
                public const string SITUACION_GENERAL = "SITUACION_GENERAL";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Obligatoria (OBLIGATORIA)
                public const string OBLIGATORIA = "OBLIGATORIA";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Obligatoria (OPCIONAL)
                public const string OPCIONAL = "OPCIONAL";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna IdConfiguracion (IdConfiguracion)
                public const string IDCONFIGURACION = "IdConfiguracion";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Calculada (Calculada)
                public const string CALCULADA = "Calculada";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Seleccionar (Seleccion)
                public const string SELECCION = "Seleccion";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Seleccionar (Elegir)
                public const string ELEGIR = "Elegir";
                //
                // Resumen:
                //     Tabla Regla de Cobertura - Columna Comision
                public const string COMISION = "Comision";
                //
                // Resumen:
                //     Columna Estatus OT
                public const string ESTATUS_OT = "ESTATUS_OT";
                //
                // Resumen:
                //     Fecha de insercion de la cobertura a una cotizacion o poliza.
                public const string CXC_FechaAlta = "CXC_FechaAlta";
            }
            //
            // Resumen:
            //     Contiene los campos de Paquete Forma de Pago
            public struct PAQUETEFORMAPAGO
            {
                //
                // Resumen:
                //     Tabla Paquete forma Pago - Columna FORMA_PAGO
                public const string DESCRIPCION = "FORMA_PAGO";
                //
                // Resumen:
                //     Tabla Paquete forma Pago - Columna FORMA_PAGO_ID
                public const string PAGO_ID = "FORMA_PAGO_ID";
                //
                // Resumen:
                //     Tabla Paquete forma Pago - Columna FORMA_PAGO_ID
                public const string NUMERO_RECIBOS = "EFP_TOTALPERIODOS";
            }
            //
            // Resumen:
            //     Columnas utilizadas en Forma de Pago
            public struct FORMAPAGO
            {
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna "DESCRIPCION"
                public const string DESCRIPCION = "DESCRIPCION";
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna "FORMAS DE PAGO"
                public const string PAGO_ID = "FORMAS DE PAGO";
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna de Lista de paquetes "FPGD_PAQUETES"
                public const string PAQUETES = "FPGD_PAQUETES";
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna de tope de descuento "FPGD_TOPE_DESCUENTO"
                public const string TOPE_DESCUENTO = "FPGD_TOPE_DESCUENTO";
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna de Lista de conductos de cobro "FPGD_CONDUCTOS_COBRO"
                public const string CONDUCTOS_COBRO = "FPGD_CONDUCTOS_COBRO";
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna que indica si es forma de pago de promosión
                public const string PROMOSION = "FPGD_PROMOSION";
                //
                // Resumen:
                //     Tabla Forma de Pago - Columna de Lista de bancos que aplican a Tarjeta de credito
                //     "FPGD_BANCOS"
                public const string BANCOS = "FPGD_BANCOS";
            }
            //
            // Resumen:
            //     Columnas de RAMO
            public struct RAM
            {
                //
                // Resumen:
                //     Columna Clave de Ramo "RAM_CVE_RAMO"
                public const string CLAVERAMO = "RAM_CVE_RAMO";
                //
                // Resumen:
                //     Columna Clave de SubRamo "RAM_CVE_SUBRAMO"
                public const string CLAVESUBRAMO = "RAM_CVE_SUBRAMO";
            }
            //
            public struct VMOD
            {
                //
                // Resumen:
                //     Columna Anio "VMOD_ANIO"
                public const string ANIO = "VMOD_ANIO";
                //
                // Resumen:
                //     Columna Anio "VMOD_ANIO"
                public const string ANIO_COPY = "VMOD_ANIOCopy";
            }
            //
            // Resumen:
            //     Columnas de CXC
            public struct CXC
            {
                //
                // Resumen:
                //     Columna de Clave de proveedor de Asistencia (CXC_PROVCA)
                public const string PROVEDOR_ASISTENCIA = "CXC_PROVCA";
                //
                // Resumen:
                //     Columna de Factor Deducible (CXC_QT_DEDUCIBLE)
                public const string DEDUCIBLE_FACTOR = "CXC_QT_DEDUCIBLE";
                //
                // Resumen:
                //     Columna de Valor Monetario de Suma Asegurada (CXC_VM_SUM_ASEG)
                public const string SUMA_ASEGURADA = "CXC_VM_SUM_ASEG";
                //
                // Resumen:
                //     Columna de Valor de Prima Anual (CXC_VM_PRIMA_ANUAL)
                public const string PRIMA_ANUAL = "CXC_VM_PRIMA_ANUAL";
                //
                // Resumen:
                //     Columna del valor Monetario de Prima Neta (CXC_VM_PRIMA_NETA)
                public const string PRIMA_NETA = "CXC_VM_PRIMA_NETA";
                //
                // Resumen:
                //     Columna de valor monetario de Prima Ajustada (PRIMA_AJUSTADA)
                public const string PRIMA_AJUSTADA = "PRIMA_AJUSTADA";
                //
                // Resumen:
                //     Columna de Valor monetario de Cesión de Comisión (CXC_VM_CES_COMIS)
                public const string CESION_COMISION = "CXC_VM_CES_COMIS";
                //
                // Resumen:
                //     Columna de Factor de Comision (CXC_QT_COMISION)
                public const string COMISION_FACTOR = "CXC_QT_COMISION";
                //
                // Resumen:
                //     Columna de Valor Monetario de Ajuste (CXC_VM_AJUSTE2)
                public const string AJUSTE = "CXC_VM_AJUSTE2";
                //
                // Resumen:
                //     Columna de Valor monetario de la comisión por la Prima (CXC_VM_COMXPRIMA)
                public const string COMISION_PRIMA = "CXC_VM_COMXPRIMA";
                //
                // Resumen:
                //     Columna de Valor Monetario de la Comisión del Financiamiento (CXC_VM_COMXFINAN)
                public const string COMISION_POR_FINANCIAMIENTO = "CXC_VM_COMXFINAN";
                //
                // Resumen:
                //     Columna de Valor Monetario de Financiamiento (CXC_VM_FINAN)
                public const string FINANCIAMIENTO = "CXC_VM_FINAN";
                //
                // Resumen:
                //     Columna de Factor de No Siniestralidad (CXC_QT_AJUSTE1)
                public const string PORCENTAJE_NO_SINIESTRALIDAD = "CXC_QT_AJUSTE1";
                //
                // Resumen:
                //     Columna de Factor de Descuento de Comisión (CPOL_Q_CES_COMIS)
                public const string PORCENTAJE_DESCUENTO_COMISION = "CPOL_Q_CES_COMIS";
                //
                // Resumen:
                //     Columna de Factor de Comisión (CXC_QT_COMISION)
                public const string PORCENTAJE_CONVENCION = "CXC_QT_COMISION";
            }
            //
            // Resumen:
            //     Contiene todas las columnas con el prefijo CAM
            public struct CAM
            {
                //
                // Resumen:
                //     Columna de Descripción del Tipo (CAM_DESCRIPCIONTIPO)
                public const string DESCRIPCION_TIPO = "CAM_DESCRIPCIONTIPO";
                //
                // Resumen:
                //     Columna de Descripción de la Versión (CAM_VERSION)
                public const string VERSION = "CAM_VERSION";
                //
                // Resumen:
                //     Columna de Descripción de la Versión (CAM_VERSION)
                public const string SECUENCIA = "CAM_SECUENCIA";
                //
                // Resumen:
                //     Columna de Catalogo de Fabricante (CAM_CATALOGOFABRICANTE)
                public const string CATALOGO_FABRICANTE = "CAM_CATALOGOFABRICANTE";
                //
                // Resumen:
                //     Columna de Numero de Ocupantes (CAM_NUMEROOCUPANTES)
                public const string NUMERO_OCUPANTES = "CAM_NUMEROOCUPANTES";
            }
            //
            public struct CSOL
            {
                //
                // Resumen:
                //     Columna de FOLIO DE OT (CSOL_FOLIOOTID)
                public const string FOLIO_OT = "CSOL_FOLIOOTID";
            }
            //
            public struct CPOL
            {
                //
                // Resumen:
                //     Columna de Identificación de Poliza (WEB, Digitalizacion, ot) -- (CPOL_IDENT_POL)
                public const string IDENTIFICACION_POLIZA = "CPOL_IDENT_POL";
                //
                // Resumen:
                //     Columna de Poliza Anterior (CPOL_POLIZA_ANT)
                public const string NUMERO_POLIZA_ANTERIOR = "CPOL_POLIZA_ANT";
                //
                // Resumen:
                //     Columna de Usuario (CPOL_USER)
                public const string USER = "CPOL_USER";
                //
                // Resumen:
                //     Columna de Id de Poliza (CPOL_ID_POLIZA)
                public const string NUMERO_POLIZA = "CPOL_ID_POLIZA";
                //
                // Resumen:
                //     Columna de Número de Documento (CPOL_NUM_DOC)
                public const string NUMERO_DOCUMENTO = "CPOL_NUM_DOC";
                //
                // Resumen:
                //     Columna de Número de Documento (CPOL_ID_COTIZ)
                public const string NUMERO_COTIZACION = "CPOL_ID_COTIZ";
                //
                // Resumen:
                //     Columna de tipo de documento = (CPOL_TIP_DOC)
                public const string TIPO_DOCUMENTO = "CPOL_TIP_DOC";
            }
            //
            // Resumen:
            //     Contiene todas las columnas con el prefijo TAB
            public struct TAB
            {
                //
                // Resumen:
                //     Columna de Armadora del vehiculo TAB_ARMADORA
                public const string ARMADORA = "TAB_ARMADORA";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPSUMASEG"
                public const string TIPOS_SUMAS_SEGURADAS = "TAB_TIPSUMASEG";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_LINEA_NEG"
                public const string LINEA_NEGOCIO = "TAB_LINEA_NEG";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPO_SA"
                public const string TIPO_SUMA_ASEGURADA = "TAB_TIPO_SA";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPO_RCOB", para obtener el tipo de regla de cobertura
                public const string TIPO_REGLA_COBERTURA = "TAB_TIPO_RCOB";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPCOBER", para obtener el tipo de cobertura
                public const string TIPO_COBERTURA = "TAB_TIPCOBER";
                //
                // Resumen:
                //     Nombre de la Columna de "TAB_ID"
                public const string ID = "TAB_ID";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_DESCRIPCION"
                public const string DESCRIPCION = "TAB_DESCRIPCION";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_DESCRIP"
                public const string DESCRIP = "TAB_DESCRIP";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPOVEHICULO"
                public const string TIPOVEHICULO = "TAB_TIPOVEHICULO";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPO_CLAUS"
                public const string TIPO = "TAB_TIPO";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPO_CLAUS"
                public const string TIPOCLAUSULA = "TAB_TIPO_CLAUS";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_TIPOTRANSMISION"
                public const string TIPOTRANSMISION = "TAB_TIPOTRANSMISION";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_CODIGOTONELAJE"
                public const string CODIGOTONELAJE = "TAB_CODIGOTONELAJE";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_MARCA"
                public const string MARCA = "TAB_MARCA";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_MARCA"
                public const string MARCA_ID = "TAB_MARCA_ID";
                //
                // Resumen:
                //     (TAB_PADRE_ID)
                public const string PADRE_ID = "TAB_PADRE_ID";
                //
                // Resumen:
                //     Nombre Columna de Parentesco (TAB_PARENTESCO)
                public const string PARENTESCO = "TAB_PARENTESCO";
                //
                // Resumen:
                //     Columna de Identificador o Referencia de PErsona (TAB_IDENTIFICADOR), utilizado
                //     en la tabla de periodos de SAMM
                public const string IDENTIFICADOR = "TAB_IDENTIFICADOR";
                //
                // Resumen:
                //     Columna de Estatus de Empresa (TAB_STATUSEMPRESA)
                public const string ESTATUS_EMPRESA = "TAB_STATUSEMPRESA";
                //
                // Resumen:
                //     Columna de Estatus de Forma de Pago (TAB_STATUSFORPAG)
                public const string ESTATUS_FORMAPAGO = "TAB_STATUSFORPAG";
                //
                // Resumen:
                //     Nombre de Columna de Estatus (TAB_STATUS)
                public const string STATUS = "TAB_STATUS";
                //
                // Resumen:
                //     Nombre de Columna de Estatus (TAB_ESTATUS)
                public const string ESTATUS = "TAB_ESTATUS";
                //
                // Resumen:
                //     Nombre de Columna de Estatus (TAB_ESTATUSSUSC)
                public const string ESTATUS_SUSC = "TAB_ESTATUSSUSC";
                //
                // Resumen:
                //     Nombre de Columna de la clave forma de pago (TAB_FMA_PAGO)
                public const string FORMA_PAGO = "TAB_FMA_PAGO";
                //
                // Resumen:
                //     nombre de columna de Canal de Venta. (TAB_CANALVENTA)
                public const string CANAL_VENTA = "TAB_CANALVENTA";
                //
                // Resumen:
                //     Nombre de la Colimna de Id de la zona (TAB_ZONAID)
                public const string ZONA_ID = "TAB_ZONAID";
                //
                // Resumen:
                //     Columna de Fabricante (TAB_FABRICANTE)
                public const string FABRICANTE = "TAB_FABRICANTE";
                //
                // Resumen:
                //     Nombre de la columna "TAB_CONDUCTOCOBRO"
                public const string CONDUCTO_COBRO = "TAB_CONDUCTOCOBRO";
                //
                // Resumen:
                //     Nombre de la Columna "TAB_ORIGENOT"
                public const string ORGIGEN_OT = "TAB_ORIGENOT";
            }
            //
            // Resumen:
            //     Estructuras de la tabla de zonas de ciruclacion
            public struct ZON
            {
                //
                // Resumen:
                //     Columna de Descripción de la Zona de Circulación (ZON_DESCRIPCION)
                public const string DESCRIPCION = "ZON_DESCRIPCION";
            }
            //
            // Resumen:
            //     Contiene todas las columnas con el prefijo DTAB
            public struct DTAB
            {
                //
                // Resumen:
                //     Nombre de la Columna "DTAB_DESCRIPCION"
                public const string DESCRIPCION = "DTAB_DESCRIPCION";
                //
                // Resumen:
                //     Nombre de la Columna de "DTAB_ID"
                public const string ID = "DTAB_ID";
                //
                // Resumen:
                //     Clave Auxiliar1 "DTAB_AUXILIAR1"
                public const string AUXILIAR1 = "DTAB_AUXILIAR1";
                //
                // Resumen:
                //     Nombre de la Columna "DTAB_AUXILIAR2"
                public const string AUXILIAR2 = "DTAB_AUXILIAR2";
                //
                // Resumen:
                //     Clave Orden
                public const string ORDEN = "DTAB_ORDEN";
            }
            //
            public struct SUSC
            {
                //
                // Resumen:
                //     Campo Clave de suscripción (ESUS_EXCEPCIONSUSCRIPID)
                public const string ID = "ESUS_EXCEPCIONSUSCRIPID";
                //
                // Resumen:
                //     Campo de Descripcion de Excepciones(ESUS_DESCRIP)
                public const string DESCRIPCION_ESUS = "ESUS_DESCRIP";
                //
                // Resumen:
                //     Campo de Descripción de la Suscripción (SUSC_DESCRIP)
                public const string DESCRIPCION = "SUSC_DESCRIP";
                //
                // Resumen:
                //     Campo de Justificación de la Suscripción (SUSC_JUSTIFICACION)
                public const string JUSTIFICACION = "SUSC_JUSTIFICACION";
                //
                // Resumen:
                //     Campo de Referencia de la Suscripción (SUSC_REFERENCIA)
                public const string REFERENCIA = "SUSC_REFERENCIA";
                //
                // Resumen:
                //     Campo de Valor Solicitado en la Suscripción (SUSC_VALORSOL)
                public const string VALOR_SOLICITADO = "SUSC_VALORSOL";
            }
            //
            // Resumen:
            //     Columnas con el Prefijo de TVAR
            public struct TVAR
            {
                //
                // Resumen:
                //     Campo Descripción del prefijo TVAR ( TVAR_DESCRIPCION )
                public const string DESCRIPCION = "TVAR_DESCRIPCION";
                //
                // Resumen:
                //     Campo VClave del Prefijo TVAR ( TVARV_CLAVE )
                public const string VCLAVE = "TVARV_CLAVE";
            }
            //
            // Resumen:
            //     Columnas con el Prefijo de TVAR
            public struct TAR
            {
                //
                // Resumen:
                //     Campo Descripción del prefijo TVAR ( TAR_DESCRIPCION )
                public const string DESCRIPCION = "TAR_DESCRIPCION";
                //
                // Resumen:
                //     Campo VClave del Prefijo TVAR ( TAR_TARIFAID )
                public const string ID = "TAR_TARIFAID";
            }
            //
            // Resumen:
            //     Campos con el prefijo EMP (empresa)
            public struct EMP
            {
                //
                // Resumen:
                //     Campo Descripcion de la Empresa ( EMP_DESEMPRESA )
                public const string DESCRIPCION = "EMP_DESEMPRESA";
                //
                // Resumen:
                //     Campo ID de la Empresa ( EMP_EMPRESAID )
                public const string ID = "EMP_EMPRESAID";
                //
                // Resumen:
                //     Campo de Logo de la empresa
                public const string LOGO = "EMP_LOGO";
                //
                // Resumen:
                //     Campo de Descripción compuesta (EMP_DESEMPRESA_COMP)
                public const string IDDESCRIPCION = "EMP_DESEMPRESA_COMP";
            }
            //
            // Resumen:
            //     Campos de Beneficiario por Cobertura
            public struct BXC
            {
                //
                // Resumen:
                //     Columna de concecutivo del beneficiario (BXC_CONSECUTIVO)
                public const string CONSECUTIVO = "BXC_CONSECUTIVO";
                //
                // Resumen:
                //     Columna de nombre del beneficiario (BXC_NOMBREBENEFICIARIO)
                public const string BENEFICIARIO = "BXC_NOMBREBENEFICIARIO";
                //
                // Resumen:
                //     Columna de nombre de Porcentaje de Participación (BXC_PORCPARTICIPACION)
                public const string PARTICIPACION = "BXC_PORCPARTICIPACION";
                //
                // Resumen:
                //     Columna de nombre de Tipo de Beneficiario (BXC_TIPOBENEFICIARIO)
                public const string TIPO = "BXC_TIPOBENEFICIARIO";
            }
            //
            // Resumen:
            //     Columnas de tipo CLA
            public struct CLA
            {
                //
                // Resumen:
                //     Columna de Clave de Clausula (CLA_ID_CLAUSULA)
                public const string IDCLAUSULA = "CLA_ID_CLAUSULA";
                //
                // Resumen:
                //     Columna de texto de la Clausula (CLA_TEXTO)
                public const string TEXTO = "CLA_TEXTO";
                //
                // Resumen:
                //     Columna de la Descripción de la Clausula
                public const string DESCRIPCION = "CLA_DESCRIP";
                //
                // Resumen:
                //     Columna de Estatus
                public const string ESTATUS = "Estatus";
            }
            //
            // Resumen:
            //     Columnas para la impresión de la cotización.
            public struct COTIZACION
            {
                //
                public const string IDCOTIZACION = "IdCotizacion";
                //
                public const string RECIBOS = "Recibos";
                //
                public const string PRIMERA_EXHIBICION = "PrimeraExhibicion";
                //
                public const string AGENTE = "Agente";
                //
                public const string TOTAL_PAGAR = "TotalPagar";
                //
                public const string IVA = "IVA";
                //
                public const string DERECHO_POLIZA = "DerechoPoliza";
                //
                public const string RECARGO = "Recargo";
                //
                public const string PRIMANETA = "PrimaNeta";
                //
                public const string PAQUETE = "Paquete";
                //
                public const string CIRCULACION = "Circulacion";
                //
                public const string USO = "Uso";
                //
                public const string MODELO = "Modelo";
                //
                public const string VERSION = "Version";
                //
                public const string TIPO = "Tipo";
                //
                public const string MARCA = "Marca";
                //
                public const string PRODUCTO = "Producto";
                //
                public const string FECHACOTIZACION = "FechaCotizacion";
                //
                public const string FORMAPAGO = "FormaPago";
                //
                public const string CONDUCTOPAGO = "ConductoPago";
                //
                public const string VIGENCIA = "Vengencia";
                //
                public const string SUMAASEGURADA = "SumaAsegurada";
                //
                public const string MONEDA = "Moneda";
                //
                public const string TELEFONOOFICINA = "TelefonoOficina";
                //
                public const string TELEFONOCASA = "TelefonoCasa";
                //
                public const string DIRECCION = "Direccion";
                //
                public const string IDENTIFICADOR = "Identificador";
                //
                public const string SOLICITANTE = "Solicitante";
                //
                public const string MODALIDAD = "Modalidad";
                //
                public const string RAMO = "ramo";
                //
                public const string IMPORTE_SUBSECUENTES = "ImporteSubsecuentes";
                //
                public const string CLAVE_AMIS = "ClaveAMIS";
            }
            //
            // Resumen:
            //     Contiene los campos de Paquete Producto Especial
            public struct PRODUCTOESPECIAL
            {
                //
                // Resumen:
                //     PRDESP_ID = "PrdEsp_Id"
                public const string PRDESP_ID = "PrdEsp_Id";
                //
                // Resumen:
                //     MESES_VIGENCIA_POLIZA = "PrdEsp_MesesVigenciaPol"
                public const string MESES_VIGENCIA_POLIZA = "PrdEsp_MesesVigenciaPol";
                //
                // Resumen:
                //     MODELO_MAXIMO = "PrdEsp_ModeloMax"
                public const string MODELO_MAXIMO = "PrdEsp_ModeloMax";
                //
                // Resumen:
                //     MODELO_MINIMO = "PrdEsp_ModeloMin"
                public const string MODELO_MINIMO = "PrdEsp_ModeloMin";
                //
                // Resumen:
                //     NIVEL_COBRO = "PrdEsp_NivelCobro"
                public const string NIVEL_COBRO = "PrdEsp_NivelCobro";
                //
                // Resumen:
                //     DIFERIR_DERECHOS = "PrdEsp_DiferirDerechos"
                public const string DIFERIR_DERECHOS = "PrdEsp_DiferirDerechos";
                //
                // Resumen:
                //     BENEFICIARIO_APEMAT = "PrdEsp_BenPrefApeMat"
                public const string BENEFICIARIO_APEMAT = "PrdEsp_BenPrefApeMat";
                //
                // Resumen:
                //     MESES_VIGENCIA_CIS = "PrdEsp_MesesVigenciaCis"
                public const string MESES_VIGENCIA_CIS = "PrdEsp_MesesVigenciaCis";
                //
                // Resumen:
                //     BENEFICIARIO_APEPAT = "PrdEsp_BenPrefApePat"
                public const string BENEFICIARIO_APEPAT = "PrdEsp_BenPrefApePat";
                //
                // Resumen:
                //     DERECHO_POLIZA = "PrdEsp_VmDerechoPol"
                public const string DERECHO_POLIZA = "PrdEsp_VmDerechoPol";
                //
                // Resumen:
                //     DESCRIPCION_PRODESP = "PrdEsp_Descripcion"
                public const string DESCRIPCION_PRODESP = "PrdEsp_Descripcion";
                //
                // Resumen:
                //     FORMA_PAGO_ID = "Tab_FormaPagoId"
                public const string FORMA_PAGO_ID = "Tab_FormaPagoId";
                //
                // Resumen:
                //     CLI_NUM_ID = "Cli_Num_Id"
                public const string CLI_NUM_ID = "Cli_Num_Id";
                //
                // Resumen:
                //     CLI_TIPO_ID = "Cli_Tipo_Id"
                public const string CLI_TIPO_ID = "Cli_Tipo_Id";
                //
                // Resumen:
                //     MOD_ID_MODAL = "MOD_ID_MODAL"
                public const string MOD_ID_MODAL = "MOD_ID_MODAL";
                //
                // Resumen:
                //     BENEFICIARIO_NOMBRE = "PrdEsp_BenPrefNombre"
                public const string BENEFICIARIO_NOMBRE = "PrdEsp_BenPrefNombre";
                //
                // Resumen:
                //     PORCENTAJE_IVA = "PrdEsp_PcjIva"
                public const string PORCENTAJE_IVA = "PrdEsp_PcjIva";
            }
            //
            // Resumen:
            //     //27-05-2015- Se agregan campos necesarios para el guardado de modulos.
            public struct RCOBM
            {
                //
                // Resumen:
                //     Elegir
                public const string Elegir = "Elegir";
                //
                // Resumen:
                //     REGISTRO
                public const string REGISTRO = "REGISTRO";
                //
                // Resumen:
                //     RCOB_ID_AUXILIAR
                public const string RCOB_ID_AUXILIAR = "RCOB_ID_AUXILIAR";
                //
                // Resumen:
                //     CXC_FACULTATIVO
                public const string CXC_FACULTATIVO = "CXC_FACULTATIVO";
                //
                // Resumen:
                //     CXC_SA_ACUM_ANT
                public const string CXC_SA_ACUM_ANT = "CXC_SA_ACUM_ANT";
                //
                // Resumen:
                //     CXC_PROVCA
                public const string CXC_PROVCA = "CXC_PROVCA";
                //
                // Resumen:
                //     DESC_PRIMA_NETA
                public const string DESC_PRIMA_NETA = "DESC_PRIMA_NETA";
                //
                // Resumen:
                //     DESC_DEDUCIBLE
                public const string DESC_DEDUCIBLE = "DESC_DEDUCIBLE";
                //
                // Resumen:
                //     DESC_SUMA_ASEGURADA
                public const string DESC_SUMA_ASEGURADA = "DESC_SUMA_ASEGURADA";
                //
                // Resumen:
                //     DEDUCIBLE_MIN_AUTORIZADOR
                public const string DEDUCIBLE_MIN_AUTORIZADOR = "DEDUCIBLE_MIN_AUTORIZADOR";
                //
                // Resumen:
                //     DEDUCIBLE_MAX_AUTORIZADOR
                public const string DEDUCIBLE_MAX_AUTORIZADOR = "DEDUCIBLE_MAX_AUTORIZADOR";
                //
                // Resumen:
                //     DEDUCIBLES_FIJOS_AUTORIZADOR
                public const string DEDUCIBLES_FIJOS_AUTORIZADOR = "DEDUCIBLES_FIJOS_AUTORIZADOR";
                //
                // Resumen:
                //     DEDUCIBLES_FIJOS
                public const string DEDUCIBLES_FIJOS = "DEDUCIBLES_FIJOS";
                //
                // Resumen:
                //     ST
                public const string ST = "ST";
                //
                // Resumen:
                //     RCOB_ID_RCOB_EQUIV
                public const string RCOB_ID_RCOB_EQUIV = "RCOB_ID_RCOB_EQUIV";
                //
                // Resumen:
                //     DTAB_ORDEN
                public const string DTAB_ORDEN = "DTAB_ORDEN";
                //
                // Resumen:
                //     DEDUCIBLE_NUM
                public const string DEDUCIBLE_NUM = "DEDUCIBLE_NUM";
                //
                // Resumen:
                //     TIPO_SUMA_ASEG
                public const string TIPO_SUMA_ASEG = "TIPO_SUMA_ASEG";
                //
                // Resumen:
                //     COASEGURO
                public const string COASEGURO = "COASEGURO";
                //
                // Resumen:
                //     SA
                public const string SA = "SA";
                //
                // Resumen:
                //     PrimaNeta
                public const string PrimaNeta = "PrimaNeta";
                //
                // Resumen:
                //     PrimaAnual
                public const string PrimaAnual = "PrimaAnual";
                //
                // Resumen:
                //     PRIMAAJUSTADA
                public const string PRIMAAJUSTADA = "PRIMAAJUSTADA";
                //
                // Resumen:
                //     Cuota
                public const string Cuota = "Cuota";
                //
                // Resumen:
                //     CXC_QT_AJUSTE
                public const string CXC_QT_AJUSTE = "CXC_QT_AJUSTE";
                //
                // Resumen:
                //     COMISION_TOTAL
                public const string COMISION_TOTAL = "COMISION_TOTAL";
                //
                // Resumen:
                //     COMISXFINAN
                public const string COMISXFINAN = "COMISXFINAN";
                //
                // Resumen:
                //     FINAN
                public const string FINAN = "FINAN";
                //
                // Resumen:
                //     COMISXPRIMA
                public const string COMISXPRIMA = "COMISXPRIMA";
                //
                // Resumen:
                //     DescRec
                public const string DescRec = "DescRec";
                //
                // Resumen:
                //     CES_COMIS
                public const string CES_COMIS = "CES_COMIS";
                //
                // Resumen:
                //     Comision
                public const string Comision = "Comision";
                //
                // Resumen:
                //     QT_COMISION
                public const string QT_COMISION = "QT_COMISION";
                //
                // Resumen:
                //     NROW
                public const string NROW = "NROW";
                //
                // Resumen:
                //     ANUAL
                public const string ANUAL = "ANUAL";
                //
                // Resumen:
                //     OBLIGATORIO
                public const string OBLIGATORIO = "OBLIGATORIO";
                //
                // Resumen:
                //     RCOB_VM_DEDUC_MIN
                public const string RCOB_VM_DEDUC_MIN = "RCOB_VM_DEDUC_MIN";
                //
                // Resumen:
                //     RCOB_VM_DEDUC_MAX
                public const string RCOB_VM_DEDUC_MAX = "RCOB_VM_DEDUC_MAX";
                //
                // Resumen:
                //     RCOB_VM_DEDUC_DEFAULT
                public const string RCOB_VM_DEDUC_DEFAULT = "RCOB_VM_DEDUC_DEFAULT";
                //
                // Resumen:
                //     RCOB_APLICAIVA
                public const string RCOB_APLICAIVA = "RCOB_APLICAIVA";
                //
                // Resumen:
                //     OBLIGATORIA
                public const string OBLIGATORIA = "OBLIGATORIA";
                //
                // Resumen:
                //     RCOB_SA
                public const string RCOB_SA = "RCOB_SA";
                //
                // Resumen:
                //     SumaAsegurada
                public const string SumaAsegurada = "SumaAsegurada";
                //
                // Resumen:
                //     RAM_DESCRIP
                public const string RAM_DESCRIP = "RAM_DESCRIP";
                //
                // Resumen:
                //     RAM_CVE_SUBRAMO
                public const string RAM_CVE_SUBRAMO = "RAM_CVE_SUBRAMO";
                //
                // Resumen:
                //     RAM_CVE_RAMO
                public const string RAM_CVE_RAMO = "RAM_CVE_RAMO";
                //
                // Resumen:
                //     COB_GRUPO_SUM_ASG
                public const string COB_GRUPO_SUM_ASG = "COB_GRUPO_SUM_ASG";
                //
                // Resumen:
                //     COB_VISIBLE
                public const string COB_VISIBLE = "COB_VISIBLE";
                //
                // Resumen:
                //     TAB_TIPCOBER
                public const string TAB_TIPCOBER = "TAB_TIPCOBER";
                //
                // Resumen:
                //     TAB_TIPO_COB
                public const string TAB_TIPO_COB = "TAB_TIPO_COB";
                //
                // Resumen:
                //     COB_DESCRIP
                public const string COB_DESCRIP = "COB_DESCRIP";
                //
                // Resumen:
                //     COB_ID_COB
                public const string COB_ID_COB = "COB_ID_COB";
                //
                // Resumen:
                //     RCOB_ID_RCOB
                public const string RCOB_ID_RCOB = "RCOB_ID_RCOB";
                //
                // Resumen:
                //     Modulo_Id
                public const string Modulo_Id = "Modulo_Id";
                //
                // Resumen:
                //     RCOB_PN_FIJA
                public const string RCOB_PN_FIJA = "RCOB_PN_FIJA";
                //
                // Resumen:
                //     Deducible
                public const string Deducible = "Deducible";
                //
                // Resumen:
                //     RCOB_APL_RECARGO
                public const string RCOB_APL_RECARGO = "RCOB_APL_RECARGO";
                //
                // Resumen:
                //     RCOB_APL_DESCUENTO
                public const string RCOB_APL_DESCUENTO = "RCOB_APL_DESCUENTO";
                //
                // Resumen:
                //     RCOB_ANTIGUEDADXCOB
                public const string RCOB_ANTIGUEDADXCOB = "RCOB_ANTIGUEDADXCOB";
                //
                // Resumen:
                //     RCOB_INCREMENTO
                public const string RCOB_INCREMENTO = "RCOB_INCREMENTO";
                //
                // Resumen:
                //     RCOB_TARIFICA
                public const string RCOB_TARIFICA = "RCOB_TARIFICA";
                //
                // Resumen:
                //     CXC_QT_DEDUCIBLE
                public const string CXC_QT_DEDUCIBLE = "CXC_QT_DEDUCIBLE";
                //
                public const string RCOB_ACUM_SA_REASEG = "RCOB_ACUM_SA_REASEG";
                //
                // Resumen:
                //     RCOB_POS_IMPRESION
                public const string RCOB_POS_IMPRESION = "RCOB_POS_IMPRESION";
                //
                // Resumen:
                //     RCOB_DEDUC_COTIZADORES
                public const string RCOB_DEDUC_COTIZADORES = "RCOB_DEDUC_COTIZADORES";
                //
                // Resumen:
                //     Calculada
                public const string Calculada = "Calculada";
                //
                // Resumen:
                //     RCOB_TOPE_SA
                public const string RCOB_TOPE_SA = "RCOB_TOPE_SA";
                //
                // Resumen:
                //     RCOB_COB_DEPEND_SA_MIN
                public const string RCOB_COB_DEPEND_SA_MIN = "RCOB_COB_DEPEND_SA_MIN";
                //
                // Resumen:
                //     RCOB_SA_MAX
                public const string RCOB_SA_MAX = "RCOB_SA_MAX";
                //
                // Resumen:
                //     RCOB_SA_MIN
                public const string RCOB_SA_MIN = "RCOB_SA_MIN";
                //
                // Resumen:
                //     TAB_TIPO_RCOB
                public const string TAB_TIPO_RCOB = "TAB_TIPO_RCOB";
                //
                // Resumen:
                //     TAB_SECCION
                public const string TAB_SECCION = "TAB_SECCION";
                //
                // Resumen:
                //     TAB_TIPO_SA
                public const string TAB_TIPO_SA = "TAB_TIPO_SA";
                //
                // Resumen:
                //     RCOB_APLICA_DETALLE
                public const string RCOB_APLICA_DETALLE = "RCOB_APLICA_DETALLE";
                //
                // Resumen:
                //     RCOB_COB_DEPEND_SA_MAX
                public const string RCOB_COB_DEPEND_SA_MAX = "RCOB_COB_DEPEND_SA_MAX";
                //
                // Resumen:
                //     HABILITADO
                public const string HABILITADO = "HABILITADO";
            }
        }

        #region "NUMERO"
        /// <summary>
        /// contiene valores númericos
        /// </summary>
        public struct NUMERO
        {
            /// <summary>
            /// NUMERO - MENOS UNO
            /// </summary>
            public const int MENOS_UNO = -1;
            /// <summary>
            /// NUMERO - CERO ( 0 )
            /// </summary>
            public const int CERO = 0;
            /// <summary>
            /// NUMERO - UNO ( 1 )
            /// </summary>
            public const int UNO = 1;
            /// <summary>
            /// NUMERO - DOS ( 2 )
            /// </summary>
            public const int DOS = 2;
            /// <summary>
            /// NUMERO - TRES ( 3 )
            /// </summary>
            public const int TRES = 3;
            /// <summary>
            /// NUMERO - CUATRO ( 4 )
            /// </summary>
            public const int CUATRO = 4;
            /// <summary>
            /// NUMERO - CINCO ( 5 )
            /// </summary>
            public const int CINCO = 5;
            /// <summary>
            /// NUMERO - SEIS ( 6 )
            /// </summary>
            public const int SEIS = 6;
            /// <summary>
            /// NUMERO - SIETE ( 7 )
            /// </summary>
            public const int SIETE = 7;
            /// <summary>
            /// NUMERO - CINCO ( 10 )
            /// </summary>
            public const int DIEZ = 10;
            /// <summary>
            /// Número - ONCE ( 11 )
            /// </summary>
            public const int ONCE = 11;
            /// <summary>
            /// NUMERO - DOCE ( 12 )
            /// </summary>
            public const int DOCE = 12;
            /// <summary>
            ///  NUMERO - DIECISEIS ( 16 )
            /// </summary>
            public const int DIECISEIS = 16;
            /// <summary>
            ///  NUMERO - DIECIOCHO ( 18 )
            /// </summary>
            public const int DIECIOCHO = 18;
            /// <summary>
            ///  NUMERO - DIECIOCHO ( 19 )
            /// </summary>
            public const int DIECINUEVE = 19;
            /// <summary>
            ///  NUMERO - VEINTE( 20 )
            /// </summary>
            public const int VEINTE = 20;
            /// <summary>
            ///  NUMERO - VEINTICINCO ( 25 )
            /// </summary>
            public const int VEINTICINCO = 25;
            /// <summary>
            /// NUMERO - CUARENTA ( 40 )
            /// </summary>
            public const int CUARENTA = 40;

            /// <summary>
            /// NUMERO - OCHENTA ( 80 )
            /// </summary>
            public const int OCHENTA = 80;

            /// <summary>
            /// NUMERO - CIEN ( 100 )
            /// </summary>
            public const int CIEN = 100;

            // [mgodinez. 20130924. I. Requerimiento: MultiCotizacion para corredor Lorant.]
            /// <summary>
            /// NUMERO - CIENTO DIEZ ( 110 )
            /// </summary>
            public const int CIENTO_DIEZ = 110;
            // [mgodinez. 20130924. F. Requerimiento: MultiCotizacion para corredor Lorant.]

        }
        #endregion
    }
}
