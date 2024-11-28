using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor:Identificación
    {
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

        public int VerificarStockDeProducto(Producto producto)
        {
            var buscarProducto = Productos.FirstOrDefault(p=>p.Codigo==producto.Codigo);
            if (buscarProducto != null)
            {
                return buscarProducto.Stock;
            }
            else
            {
                return 0;
            }
        }
    }
}
