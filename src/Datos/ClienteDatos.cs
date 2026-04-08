using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class ClienteDatos

    {
        public Cliente ObtenerPorId(int id)
        {
            using (var context = new db_EcoReciclaEntities())
            {
                return context.Cliente.Find(id);
            }
        }

        public bool ExisteRUCEnOtroCliente(string ruc, int clienteId)
        {
            using (var context = new db_EcoReciclaEntities())
            {
                return context.Cliente.Any(c => c.RUC == ruc && c.ClienteID != clienteId);
            }
        }
        public bool ExisteRUC(string ruc)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Cliente.Any(c => c.RUC == ruc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar existencia del RUC: " + ex.Message);
            }
        }

        public String RegistrarCliente(Cliente cliente)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())

                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();

                    return "Cliente registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar el cliente: " + ex.Message;
            }
        }

        public String ModificarCliente(Cliente cliente)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    var clienteOriginal = context.Cliente.Find(cliente.ClienteID);
                    if (clienteOriginal == null) return "Cliente no encontrado.";

                    clienteOriginal.Nombre = cliente.Nombre;
                    clienteOriginal.RUC = cliente.RUC;
                    clienteOriginal.Direccion = cliente.Direccion;
                    clienteOriginal.Telefono = cliente.Telefono;
                    clienteOriginal.Email = cliente.Email;

                    context.SaveChanges();
                    return "Cliente modificado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar el cliente: " + ex.Message;
            }
        }

        public String EliminarCliente(int id)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {

                    Cliente clienteTemp = context.Cliente.Find(id);
                    context.Cliente.Remove(clienteTemp);
                    context.SaveChanges();
                    return "Cliente eliminado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: El Cliente tiene órdenes de recojo pendientes. Debe eliminar las órdemes del cliente para poder eliminarlo ";
            }
        }

        public List<Cliente> ListarTodosLosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    clientes = context.Cliente.ToList();

                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
                throw new Exception("Error al listar los clientes: " + ex.Message);
            }
        }


    }
}
