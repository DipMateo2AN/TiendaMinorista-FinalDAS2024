using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraClientes
    {
        private Context context = new Context();
        public bool CrearCliente(Cliente cliente)
        {
            var validarCliente = context.Clientes.FirstOrDefault(c => c.Codigo == cliente.Codigo);
            if (validarCliente == null)
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ModificarCliente(Cliente clienteActualizado)
        {
            var validarCliente = context.Clientes.FirstOrDefault(c => c.Codigo == clienteActualizado.Codigo);
            if (validarCliente != null)
            {
                context.Clientes.Update(clienteActualizado);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public bool EliminarCliente(Cliente cliente)
        {
            var validarCliente = context.Clientes.FirstOrDefault(c => c.Codigo == cliente.Codigo);
            if (validarCliente != null)
            {
                context.Clientes.Remove(validarCliente);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Cliente> ListarClientes()
        {
            return context.Clientes.ToList().AsReadOnly();
        }
    }
}
