using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProductoImportado : Producto
    {
        public int Id { get; set; }
        public string PaisImportacion {get; set;}
        public DateTime FechaImportacion {get; set;}

        public int CodigoImportacion {get; set;}

    }
}
