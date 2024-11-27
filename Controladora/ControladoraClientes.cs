using Modelo;
using System;
using System.Collections.Generic;
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
                clienteActualizado.Id = validarCliente.Id;//Asigno al cliente actualizado el mismo Id que el original
                context.Clientes.Remove(validarCliente); //Elimino el cliente original
                context.Clientes.Add(clienteActualizado); //Agrego el cliente actualizado con el Id del cliente original
                context.SaveChanges();
                return true;
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
    }
}
