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
            var facturaDuplicada = context.Facturas.FirstOrDefault(x=>x.Numero == factura.Numero);
            if (facturaDuplicada == null)
            {
                factura.Numero = context.Facturas.Count() + 1; //Asigno el numero de la factura segun la cantidad de facturas que existan
                foreach (DetalleFactura d in factura.DetallesFactura) //Recorro los detalles de la factura
                {
                    factura.Total += d.Subtotal; //Acumulo los subtotales de los detalles en el total de la factura
                }
                context.Facturas.Add(factura);
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
            var facturaEncontrada = context.Facturas
            .Include(f => f.DetallesFactura)
            .FirstOrDefault(f => f.Id == factura.Id);

            var detallesFactura = facturaEncontrada?.DetallesFactura.ToList();

            return detallesFactura.ToList();

        }

    }
}