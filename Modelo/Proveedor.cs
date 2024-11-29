using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }

        public List<Producto> Productos;

        public Proveedor()
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

        public bool EliminarProducto(Producto productoAEliminar)
        {
            var productoRepetido = Productos.FirstOrDefault(p => p.Codigo == productoAEliminar.Codigo);
            if (productoRepetido != null)
            {
                Productos.Remove(productoAEliminar);
                return true;
            }
            return false;
        }

        public string NombreProductos// Para poder ver los grupos en la grilla
        {
            get => Productos != null && Productos.Count > 0 ? string.Join(" ❤️ ", Productos.Select(f => f.Nombre)) : "Sin productos";
        }
    }
}
