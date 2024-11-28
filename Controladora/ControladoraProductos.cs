using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                productoActualizado.Id = validarProducto.Id;//Asigno al producto actualizado el mismo Id que el original
                context.Productos.Remove(validarProducto); //Elimino el producto original
                context.Productos.Add(productoActualizado); //Agrego el producto actualizado con el Id del producto original
                context.SaveChanges();
                return true;
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

        public ReadOnlyCollection<Producto> LeerProductos()
        {
            return context.Productos.ToList().AsReadOnly();
        }
    }
}
