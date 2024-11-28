using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
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
            var validarCategoria = context.Categorias.FirstOrDefault(c => c.Codigo == categoriaActualizada.Codigo);
            if (validarCategoria != null)
            {
                categoriaActualizada.Id = validarCategoria.Id;//Asigno a ategoria actualizada el mismo Id que la original
                context.Categorias.Remove(validarCategoria); //Elimino la categoria original
                context.Categorias.Add(categoriaActualizada); //Agrego la categoria actualizada con el Id de la categoria original
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EliminarCategoria(Categoria categoria)
        {
            var validarCategoria = context.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
            if (validarCategoria != null)
            {
                context.Categorias.Remove(validarCategoria);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Categoria> LeerCategorias()
        {
            return context.Categorias.ToList().AsReadOnly();
        }
    }
}
