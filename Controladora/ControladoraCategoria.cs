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
    public class ControladoraCategoria
    {
        //private static readonly Lazy<ControladoraCategoria> instancia = new Lazy<ControladoraCategoria>(() => new ControladoraCategoria());
        //public static ControladoraCategoria Instancia => instancia.Value;

        private Context context = new Context();
        public bool CrearCategoria(Categoria categoria)
        {
            var validarCategoria = context.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
            if (validarCategoria == null)
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ModificarCategoria(Categoria categoriaActualizada)
        {
            var validarCategoria = context.Categorias.FirstOrDefault(p => p.Codigo == categoriaActualizada.Codigo);
            if (validarCategoria != null)
            {
               context.Categorias.Update(categoriaActualizada);
               return context.SaveChanges() > 0;
            }
            return false;
        }

        public List<Categoria> ListarCategorias()
        {
            return context.Categorias.ToList();
        }

        public List<Producto> ListarProductos()
        {
            return context.Productos.ToList();
        }

    }
}
