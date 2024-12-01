using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraFacturas
    {
        private Context context = new Context();

        public bool CrearFactura(Factura factura)
        {
            var facturaDuplicada = context.Facturas.FirstOrDefault(x => x.Numero == factura.Numero);
            if (facturaDuplicada == null)
            {
                context.Facturas.Add(factura);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AgregarDetalle(DetalleFactura detalle)
        {
            var factura = context.Facturas.FirstOrDefault(x=>x.Numero == detalle.Factura.Numero);
            if (factura != null)
            {
                factura.AgregarDetalleFactura(detalle);
                context.DetalleFacturas.Add(detalle);
                context.Facturas.Update(factura);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Cliente> ListarClientes()
        {
            return context.Clientes.ToList();
        }
        public List<Producto> ListarProductos()
        {
            return context.Productos.ToList();
        }
        public List<Factura> ListarFacturas()
        {
            return context.Facturas.ToList();
        }

        public List<DetalleFactura> ListarDetallesFactura(Factura factura)
        {
            List<DetalleFactura> detallesFactura= new List<DetalleFactura>();
            foreach (var d in context.DetalleFacturas)
            {
                if(d.Factura.Numero == factura.Numero)
                {
                    detallesFactura.Add(d);
                }
            }
            return detallesFactura;
        }
    }
}