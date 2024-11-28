using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategoria
    {
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
                categoriaActualizada.Id = validarCategoria.Id;//Asigno a la Categoria actualizada el mismo Id que la original
                context.Categorias.Remove(validarCategoria); //Elimino la Categoria original
                context.Categorias.Add(categoriaActualizada); //Agrego a la Categoria actualizada con el Id de la Categoria original
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EliminarCategorias(Categoria categoria)
        {
            var validarCategoria = context.Categorias.FirstOrDefault(p => p.Codigo == categoria.Codigo);
            if (validarCategoria != null)
            {
                context.Categorias.Remove(validarCategoria);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
