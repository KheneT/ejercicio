using System;

public class Dispositivos
{
	public Dispositivos(nombre,descripción,precio,cantidadDisponible,fecha)
	{
		this.nombre = nombre;
		this.precio = precio;
		this.descripción = descripción;
		this.cantidadDisponible = cantidadDisponible;
		this.fecha = fecha;
	}



	private string nombre,descripción;
	private double precio;
	private int cantidadDisponible;
	private dateTime fecha = new dateTime();

	
}
