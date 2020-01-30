//using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;

using AdoNetCore.AseClient;
using Enterprise.Data.AccessCore.Connection;
using Hdi.Arquitectura.LibreriaEmpresarial.NetCore.AccesoDatos;
using System;
using System.Data;
//using Microsoft.Extensions.Options;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos.Core
{
    public class SybaseEngine : Engine, IDisposable
    {

        public static string ConnectionString { get; set; }

        #region Constructor

        internal SybaseEngine(string cadenaConexion)
            : base(cadenaConexion)
        {
        }

        #endregion Constructor

        #region Public Override Methods

        public override IDataParameter CreateParameter(string parameterName, object value, ParameterDirection direction)
        {
            bool containSymbol = parameterName.StartsWith("@");
            AseParameter parameter = new AseParameter(containSymbol ? parameterName : "@" + parameterName, value);
            parameter.Direction = direction;

            return parameter;
        }

        protected override void FillDataSet(DataSet dataSet, string tableName)
        {
            ((AseDataAdapter)this._dataAdapter).Fill(dataSet, tableName);
        }

        protected override void InitializeDataAdapter(string query)
        {
            this._dataAdapter = new AseDataAdapter(query, (AseConnection)this._connection);
            ((AseDataAdapter)this._dataAdapter).SelectCommand = (AseCommand)this._command;
        }

        protected override void InitializeEngine()
        {
            if (this.UseEnterpriseConnection)
            {
                this._connection = ((AseConnection)new EnterpriseConnection<AseConnection>(this._connectionString, string.Empty)); //Todo SetUser
            }
            else
            {
                this._connection = new AseConnection(this._connectionString);
            }

            this._command = this._connection.CreateCommand();
            this._command.CommandTimeout = this.CommandTimeout;
        }

        /// <summary>
        /// Bulkcopy method use a DataTable to insert in database the entire collection of rows, Datatable must contains datatable name, this datatable name is relation to table in database
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        protected override bool BulkCopy(DataTable dataTable)
        {
            throw new System.NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                    this.Disconnect();
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.


                this._command = null;
                this._connection = null;
                this._connectionString = null;
                this._dataAdapter = null;
                this._transaction = null;

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~SybaseEngine() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #endregion Public Override Methods
    }
}
