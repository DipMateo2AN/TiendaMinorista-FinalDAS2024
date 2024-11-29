using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; }

        public Categoria()
        {
            Productos = new List<Producto>();
        }

        public List<Producto> ListarProductos()
        {
            return Productos.ToList();
        }

        public bool AgregarProducto(Producto nuevoProducto)
        {
            var productoRepetido = Productos.FirstOrDefault(p => p.Codigo == nuevoProducto.Codigo);
            if (productoRepetido == null)
            {
                Productos.Add(nuevoProducto);
                return true;
            }
            return false;
        }

        public bool ModificarProducto(Producto nuevoProducto)
        {
            var productoRepetido = Productos.FirstOrDefault(p => p.Codigo == nuevoProducto.Codigo);
            if (productoRepetido != null)
            {
                Productos.Remove(productoRepetido);
                Productos.Add(nuevoProducto);
                return true;
            }
            return false;
        }

        public bool QuitarProducto(Producto nuevoProducto)
        {
            var productoRepetido = Productos.FirstOrDefault(p => p.Codigo == nuevoProducto.Codigo);

            if (productoRepetido != null)
            {
                Productos.Remove(productoRepetido);
                return true;
            }

            return false;
        }

        public string NombreProductos// Para poder ver los grupos en la grilla
        {
            get => Productos != null && Productos.Count > 0 ? string.Join(" ❤️ ", Productos.Select(f => f.Nombre)) : "Sin productos";
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
