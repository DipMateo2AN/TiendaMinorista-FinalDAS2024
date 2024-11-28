using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProveedores
    {
        private Context context = new Context();
        public bool CrearProveedor(Proveedor proveedor)
        {
            var validarProveedor = context.Proveedores.FirstOrDefault(p => p.Codigo == proveedor.Codigo);
            if (validarProveedor == null)
            {
                context.Proveedores.Add(proveedor);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ModificarProveedor(Proveedor proveedorActualizado)
        {
            var validarProveedor = context.Proveedores.FirstOrDefault(p => p.Codigo == proveedorActualizado.Codigo);
            if (validarProveedor != null)
            {
                context.Proveedores.Update(proveedorActualizado);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public bool EliminarProveedor(Proveedor proveedor)
        {
            var validarProveedor = context.Proveedores.FirstOrDefault(p => p.Codigo == proveedor.Codigo);
            if (validarProveedor != null)
            {
                context.Proveedores.Remove(validarProveedor);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Proveedor> ListarProveedores()
        {
            return context.Proveedores.ToList().AsReadOnly();
        }
    }
}
