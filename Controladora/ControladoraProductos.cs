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
        public bool CrearProducto(Producto producto, Categoria cat)
        {
            var validarProducto = context.Productos.FirstOrDefault(p=>p.Codigo == producto.Codigo);
            if (validarProducto == null)
            {
                context.Productos.Add(producto);
                cat.AgregarProducto(producto);
                context.Categorias.Update(cat);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CrearProducto(ProductoImportado producto, Categoria cat)
        {
            var validarProducto = context.ProductosImportados.FirstOrDefault(p => p.Codigo == producto.Codigo);
            if (validarProducto == null)
            {
                context.ProductosImportados.Add(producto);
                cat.AgregarProducto(producto);
                context.Categorias.Update(cat);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ModificarProducto(Producto productoActualizado, Categoria cat)
        {
            var validarProducto = context.Productos.FirstOrDefault(p => p.Codigo == productoActualizado.Codigo);
            if (validarProducto != null)
            {
                context.Productos.Update(productoActualizado);
                var busqueda = cat.Productos.FirstOrDefault(x => x.Codigo == cat.Codigo);
                cat.ModificarProducto(busqueda);
                context.Categorias.Update(cat);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public bool ModificarProducto(ProductoImportado productoActualizado, Categoria cat)
        {
            var validarProducto = context.ProductosImportados.FirstOrDefault(p => p.Codigo == productoActualizado.Codigo);
            if (validarProducto != null)
            {
                context.ProductosImportados.Update(productoActualizado);
                var busqueda = cat.Productos.FirstOrDefault(x => x.Codigo == cat.Codigo);
                cat.ModificarProducto(busqueda);
                context.Categorias.Update(cat);
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

        public bool EliminarProducto(ProductoImportado producto)
        {
            var validarProducto = context.ProductosImportados.FirstOrDefault(p => p.Codigo == producto.Codigo);
            if (validarProducto != null)
            {
                context.ProductosImportados.Remove(validarProducto);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            foreach (var item in context.Productos)
            {
                if(item is ProductoImportado)
                {

                }
                else
                {
                    lista.Add(item);
                }
            }
            return lista.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<ProductoImportado> ListarProductosImportados()
        {
            return context.ProductosImportados.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Categoria> ListarCategorias()
        {
            return context.Categorias.ToList().AsReadOnly();
        }
    }
}
