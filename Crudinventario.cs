using System;

namespace dispositivo
{
    public abstract class CrudInventario
    {   
        protected List<Dispositivos> productos = new List<Dispositivos>();

        public void AgregarProducto(Dispositivo producto)
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

        public abstract List<Dispositivo> BuscarPorNombre(string nombre);

        public abstract List<Dispositivo> BuscarPorPrecio(double precioMinimo, double precioMaximo);

        
    }   
 
}
