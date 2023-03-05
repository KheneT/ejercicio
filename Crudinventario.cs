using System;

namespace dispositivo
{
    public abstract class CrudInventario
    {   
        protected List<Dispositivo> productos = new List<Dispositivo>();

        public virtual void AgregarProducto(Dispositivo producto)
        {
            Dispositivo.Add(producto);
        }

        public virtual void ActualizarProducto(Producto producto)
        {
            var index = Dispositivo.FindIndex(p => p.Nombre == producto.Nombre);
            if (index != -1)
            {
                Dispositivo[index] = producto;
            }
        }

        public virtual void EliminarProducto(Dispositivo producto)
        {
            productos.Remove(producto);
        }

        public abstract List<Dispositivo> BuscarPorNombre(string nombre)
        {
            return productos.FindAll(p => p.Nombre == nombre);
        }

        public abstract List<Dispositivo> BuscarPorPrecio(double precioMinimo, double precioMaximo)
        {
            return productos.FindAll(p => p.precio >= precioMinimo & p.precio <= precioMaximo);
        }

        
    }   
 
}
