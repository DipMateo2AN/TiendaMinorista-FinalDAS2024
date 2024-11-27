namespace Modelo
{
    public class Factura
    {
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
            var detalleRepetido = DetallesFactura.FirstOrDefault(d => d.Producto == nuevoDetalle.Producto);

            detalleRepetido.Cantidad += nuevoDetalle.Cantidad;
            return true;
        }

        public bool EliminarDetalleFactura(DetalleFactura detalleAEliminar)
        {

            return false;
        }


    }
}
