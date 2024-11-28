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

        public void CrearFactura(Factura factura)
        {
            factura.Numero = context.Facturas.Count() + 1; //Asigno el numero de la factura segun la cantidad de facturas que existan
            foreach (DetalleFactura d in factura.DetallesFactura) //Recorro los detalles de la factura
            {
                factura.Total += d.Subtotal; //Acumulo los subtotales de los detalles en el total de la factura
            }
            context.Facturas.Add(factura);
            context.SaveChanges();
        }
    }
}