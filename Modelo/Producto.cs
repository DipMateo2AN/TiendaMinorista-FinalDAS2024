using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Categoria Categoria { get; set; }

        //////////////////Metodos////////////////

        public int AjustarStock(int cantidad)
        {

            // Ajusta el stock sumando o restando la cantidad especificada
            Stock += cantidad;

            // Si el stock es negativo, lo ajustamos definimos en 0
            if (Stock < 0)
            {
                Stock = 0;
            }

            return Stock;

        }

        public decimal AplicarDescuentos(decimal porcentajeDescuento)
        {
            // Calcula el descuento
            decimal descuento = Precio * (porcentajeDescuento / 100);

            // Aplica el descuento al precio
            Precio -= descuento;

            // Devuelve el nuevo precio
            return Precio;
        }

        public override string ToString()
        {
            return Nombre;
        }

        public void QuitarCategoria()
        {
            Categoria = null;
        }

        /////////////////////////////////////////
    }
}
