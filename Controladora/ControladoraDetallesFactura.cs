using Microsoft.EntityFrameworkCore;
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
            var factura = context.Facturas
        //.Include(f => f.DetallesFactura) // Carga la lista de detalles de la factura
        .FirstOrDefault(f => f.Id == detalle.Factura.Id);


            if (factura == null)
            {
                throw new Exception("La factura no existe en la base de datos.");
            }

            // Actualizamos los valores del detalle
            detalle.Producto = producto; // Asociamos el producto rastreado por EF
            detalle.Factura = factura;  // Asociamos la factura rastreada por EF
            var detalleExistente = factura.DetallesFactura.FirstOrDefault(d => d.Producto.Codigo == producto.Codigo);

            if (detalleExistente != null)
            {
                // Actualizamos el detalle existente
                detalleExistente.Cantidad += detalle.Cantidad;
                detalleExistente.Subtotal = detalleExistente.Cantidad * producto.Precio;

                context.DetalleFacturas.Update(detalleExistente); // Aseguramos que EF rastree los cambios
            }
            else
            {
                detalle.Subtotal = detalle.Producto.Precio * detalle.Cantidad;
                factura.AgregarDetalleFactura(detalle);
                // Agregamos el detalle al contexto
                context.DetalleFacturas.Add(detalle);
            }

            // Reducimos el stock del producto
            producto.AjustarStock(detalle.Cantidad);

            factura.Total = factura.DetallesFactura.Sum(d => d.Subtotal);//
            context.Facturas.Update(factura);

            // Guardamos los cambios
            context.SaveChanges();

            return detalle;
        }

        public List<DetalleFactura> ListarDetallesFactura(Factura factura)
        {
            // Recupera los detalles asociados a la factura desde la base de datos
            return context.DetalleFacturas
                .Where(df => df.Factura.Id == factura.Id)
                .Include(df => df.Producto)
                .Include(df => df.Factura)
                .ToList();
        }

        public List<DetalleFactura> ListarTodosLosDetalles()
        {
            return context.DetalleFacturas.ToList();
        }

        public void EliminarDetalle(DetalleFactura detalle)
        {
            var detalleFactura = context.DetalleFacturas.FirstOrDefault(x=>x.Id==detalle.Id);
            var factura = context.Facturas.FirstOrDefault(x=>x.Numero == detalleFactura.Factura.Numero);

            detalleFactura.Producto = null;
            detalleFactura.Factura = null;
            factura.Total -= detalleFactura.Subtotal;
            factura.EliminarDetalle(detalleFactura);


            context.DetalleFacturas.Remove(detalleFactura);
            context.Facturas.Update(factura);


            context.SaveChanges();
        }

    }
}