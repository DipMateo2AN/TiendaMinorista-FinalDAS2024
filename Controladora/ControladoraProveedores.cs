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
                proveedorActualizado.Id = validarProveedor.Id;//Asigno al proveedor actualizado el mismo Id que el original
                context.Proveedores.Remove(validarProveedor); //Elimino el proveedor original
                context.Proveedores.Add(proveedorActualizado); //Agrego el proveedor actualizado con el Id del proveedor original
                context.SaveChanges();
                return true;
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

        public ReadOnlyCollection<Proveedor> LeerProveedores()
        {
            return context.Proveedores.ToList().AsReadOnly();
        }
    }
}
