using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        private Context context = new Context();
        public bool CrearProducto(Producto producto)
        {
            var validarProducto = context.Productos.FirstOrDefault(p=>p.Codigo == producto.Codigo);
            if (validarProducto == null)
            {
                context.Productos.Add(producto);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ModificarProducto(Producto productoActualizado)
        {
            var validarProducto = context.Productos.FirstOrDefault(p => p.Codigo == productoActualizado.Codigo);
            if (validarProducto != null)
            {
                context.Productos.Update(productoActualizado);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public bool EliminarProducto(Producto producto)
        {
            var validarProducto = context.Productos.FirstOrDefault(p => p.Codigo == producto.Codigo);
            if (validarProducto != null)
            {
                context.Productos.Remove(validarProducto);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
