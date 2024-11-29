using Microsoft.EntityFrameworkCore;
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
                producto.Categoria.AgregarProducto(producto);
                
                context.Categorias.Update(producto.Categoria);
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
            // Obtener el ID del producto
            var productoId = producto.Id;

            // 1. Eliminar manualmente las relaciones en la tabla intermedia CategoriaProducto
            var relaciones = context.Set<Dictionary<string, object>>("CategoriaProducto")
                .Where(cp => EF.Property<int>(cp, "ProductoId") == productoId)
                .ToList();

            if (relaciones.Any())
            {
                context.Set<Dictionary<string, object>>("CategoriaProducto").RemoveRange(relaciones);
                context.SaveChanges();
            }

            // 2. Verificar que se hayan eliminado todas las relaciones
            var relacionesRestantes = context.Set<Dictionary<string, object>>("CategoriaProducto")
                .Any(cp => EF.Property<int>(cp, "ProductoId") == productoId);

            if (relacionesRestantes)
            {
                throw new Exception("No se pudieron eliminar todas las relaciones del producto en la tabla intermedia.");
            }

            // 3. Eliminar el producto
            context.Productos.Remove(producto);

            // 4. Guardar cambios finales
            return context.SaveChanges() > 0;
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

        public ReadOnlyCollection<Producto> ListarProductosImportados()
        {
            List<Producto> lista = new List<Producto>();
            foreach (var item in context.Productos)
            {
                if (item is ProductoImportado)
                {
                    lista.Add(item);
                }
            }
            return lista.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Categoria> ListarCategorias()
        {
            return context.Categorias.ToList().AsReadOnly();
        }
    }
}
