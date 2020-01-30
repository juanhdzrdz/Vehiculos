using System;
using System.Collections.Generic;
using System.Text;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Entidades
{
    public partial class Mensaje
    {
		private string descripcionField;
		private string valorField;
		private int idMensaje;

		public string descripcion
		{
			get { return descripcionField; }
			set { descripcionField = value; }
		}

		public string valor
		{
			get { return valorField; }
			set { valorField = value; }
		}

		public int IdMensaje
		{
			get { return idMensaje; }
			set { idMensaje = value; }
		}
	}
}
