using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraDetallesDeFactura
    {
        private Context context = new Context();

        public DetalleFactura CrearDetalleFactura(DetalleFactura detalle)
        {
            var buscarProducto = context.Productos.FirstOrDefault(p=>p.Codigo == detalle.Producto.Codigo);//Buscamos el producto en la DB
            if (buscarProducto.Stock > detalle.Cantidad) //Si el stock del producto es mayor a la cantidad requerida se puede crear el detalle
            {
                detalle.Subtotal = buscarProducto.Precio * detalle.Cantidad; //Calculamos el subtotal del detalle
                return detalle; //retornamos el detalle completo con su subtotal
            }
            else
            {
                return null;
            }
        }
    }
}