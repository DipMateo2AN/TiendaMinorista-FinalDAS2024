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
            //var buscarProducto = context.Productos.FirstOrDefault(p => p.Codigo == detalle.Producto.Codigo);//Buscamos el producto en la DB
            //if (buscarProducto.Stock > detalle.Cantidad) //Si el stock del producto es mayor a la cantidad requerida se puede crear el detalle
            //{
            //    detalle.Subtotal = buscarProducto.Precio * detalle.Cantidad; //Calculamos el subtotal del detalle
            //    context.DetalleFacturas.Add(detalle);
            //    context.SaveChanges();
            //    return detalle; //retornamos el detalle completo con su subtotal
            //}
            //else
            //{
            //    return null;
            //}

            // Buscamos el producto en la base de datos (y lo asociamos al contexto actual)
            var producto = context.Productos.FirstOrDefault(p => p.Codigo == detalle.Producto.Codigo);

            if (producto == null)
            {
                throw new Exception("El producto no existe en la base de datos.");
            }

            if (producto.Stock < detalle.Cantidad)
            {
                throw new Exception("El stock del producto no es suficiente.");
            }

            // Asociamos la factura al contexto
            var factura = context.Facturas.FirstOrDefault(f => f.Id == detalle.Factura.Id);

            if (factura == null)
            {
                throw new Exception("La factura no existe en la base de datos.");
            }

            // Actualizamos los valores del detalle
            detalle.Producto = producto; // Asociamos el producto rastreado por EF
            detalle.Factura = factura;  // Asociamos la factura rastreada por EF
            detalle.Subtotal = producto.Precio * detalle.Cantidad;

            // Reducimos el stock del producto
            producto.Stock -= detalle.Cantidad;

            factura.AgregarDetalleFactura(detalle);
            // Agregamos el detalle al contexto
            context.DetalleFacturas.Add(detalle);
            context.Facturas.Update(factura);

            // Guardamos los cambios
            context.SaveChanges();

            return detalle;
        }
    }
}