namespace Modelo
{
    public class Factura
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Total { get; set; }

        public List<DetalleFactura> DetallesFactura;

        public Factura()
        {
            DetallesFactura = new List<DetalleFactura>();
        }

        public List<DetalleFactura> ListarDetallesFacturas()
        {
            return DetallesFactura.ToList();
        }

        public bool AgregarDetalleFactura(DetalleFactura nuevoDetalle)
        {
            var detalleRepetido = DetallesFactura.FirstOrDefault(d => d.Producto.Codigo == nuevoDetalle.Producto.Codigo);
            if (detalleRepetido == null)
            {
                DetallesFactura.Add(nuevoDetalle);

            }
            else detalleRepetido.Cantidad += nuevoDetalle.Cantidad;
            return true;
        }


        public bool ModificarDetalleFactura(DetalleFactura nuevoDetalle)
        {
            var detalleRepetido = DetallesFactura.FirstOrDefault(d => d.Producto.Codigo == nuevoDetalle.Producto.Codigo);
            if (detalleRepetido != null)
            {
                DetallesFactura.Remove(detalleRepetido);
                DetallesFactura.Add(nuevoDetalle);
            }
            return false;
        }

        public override string ToString()
        {
            return Numero.ToString();
        }

    }
}
