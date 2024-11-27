namespace Modelo
{
    public class Factura
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Total { get; set; }

        public List<DetalleFactura> DetallesFactura;

        public Factura()
        {
            DetallesFactura = new List<DetalleFactura>();
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

        public bool EliminarDetalleFactura(DetalleFactura nuevoDetalle)
        {
            var detalleRepetido = DetallesFactura.FirstOrDefault(d => d.Producto.Codigo == nuevoDetalle.Producto.Codigo);
            if (detalleRepetido != null)
            {
                DetallesFactura.Remove(nuevoDetalle);
            }
            return false;
        }

    }
}
