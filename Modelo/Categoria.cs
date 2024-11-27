﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> Productos;

        public Categoria()
        {
            Productos = new List<Producto>();
        }

        public bool AgregarProducto(Producto nuevoProducto)
        {
            var productoRepetido = Productos.FirstOrDefault(p => p.Codigo == nuevoProducto.Codigo);
            if (productoRepetido == null)
            {
                Productos.Add(nuevoProducto);
                return true;
            }
            return false;
        }

        public bool EliminarProducto(Producto productoAEliminar)
        {
            var productoRepetido = Productos.FirstOrDefault(p => p.Codigo == productoAEliminar.Codigo);
            if (productoRepetido != null)
            {
                Productos.Remove(productoAEliminar);
                return true;
            }
            return false;
        }
    }
}
