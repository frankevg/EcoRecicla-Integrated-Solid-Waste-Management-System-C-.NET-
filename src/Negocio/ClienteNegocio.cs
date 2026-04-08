using Datos;
using System;
using System.Collections.Generic;


namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteDatos clienteDatos = new ClienteDatos();

        public bool Registrar(Cliente cliente)
        {
            if (clienteDatos.ExisteRUC(cliente.RUC))
            {
                return false; // Ya existe un cliente con ese RUC
            }
            clienteDatos.RegistrarCliente(cliente);
            return true; // Registro exitoso
        }


        public string ModificarCliente(Cliente cliente)
        {
            // Verifica si existe otro cliente con el mismo RUC
            if (clienteDatos.ExisteRUCEnOtroCliente(cliente.RUC, cliente.ClienteID))
            {
                return "Ya existe otro cliente con ese RUC.";
            }

            // Verifica si el cliente existe
            var clienteExistente = clienteDatos.ObtenerPorId(cliente.ClienteID);
            if (clienteExistente == null)
            {
                return "Cliente no encontrado.";
            }

            return clienteDatos.ModificarCliente(cliente);
        }
        public String EliminarCliente(int id)
        {
            return clienteDatos.EliminarCliente(id);
        }
        public List<Cliente> ListarTodosLosClientes()
        {
            return clienteDatos.ListarTodosLosClientes();
        }
    }
}
