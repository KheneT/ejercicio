using System;

namespace dispositivo
{
	public class Smarthphone : Dispositivo, CrudInventario
	{
		public Smarthphone():base( nombre,  descripción,  precio,  cantidadDisponible,  fecha)
		{

		}


	}
}
