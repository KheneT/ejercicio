using System;

namespace dispositivo
{

	public class Dispositivos
	{

		Inventario objInventario = new Inventario();


		public Dispositivos(String nombre, String descripción, doublee precio, int cantidadDisponible, DateTime fecha)
		{
			this.nombre = nombre;
			this.precio = precio;
			this.descripción = descripción;
			this.cantidadDisponible = cantidadDisponible;
			this.fecha = fecha;
		}

		public string getNombre()
		{
			return nombre;
		}

		public string getDescripción()
		{
			return descripción;
		}

		public double getPrecio()
		{
			return precio;
		}

		public int getCantidadDisponible()
		{
			return CantidadDisponible;
		}

		public dateTime getFecha()
		{
			return fecha;
		}

		public void setNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public void setDescripción(string descripción)
		{
			this.descripción = descripción;
		}

		public void setPrecio(string precio)
		{
			this.precio = precio;
		}

		public void setCantidadDisponible(int cantidadDisponible)
		{
			this.cantidadDisponible = cantidadDisponible;
		}

		public void setFecha(dateTime fecha)
		{
			this.fecha = fecha;
		}



		private string nombre, descripción;
		private double precio;
		private int cantidadDisponible;
		private dateTime fecha = new dateTime();

	}
}
