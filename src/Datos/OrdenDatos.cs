using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class OrdenDatos
    {
        public String RegistrarOrdenRecojo(OrdenRecojo ordenRecojo)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    context.OrdenRecojo.Add(ordenRecojo);
                    context.SaveChanges();
                    return "Orden de recojo registrada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar la orden de recojo: " + ex.Message;
            }
        }


        public String EliminarOrdenRecojo(int ordenId)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    var orden = context.OrdenRecojo.Find(ordenId);
                    if (orden != null)
                    {
                        context.OrdenRecojo.Remove(orden);
                        context.SaveChanges();
                        return "Orden de recojo eliminada correctamente.";
                    }
                    else
                    {
                        return "Orden de recojo no encontrada.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar la orden de recojo: " + ex.Message;
            }
        }

        public List<OrdenRecojo> ListarOrdenesRecojo()
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.OrdenRecojo
                           .Include("Cliente")
                           .Include("TipoResiduo") 
                           .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las órdenes de recojo: " + ex.Message);
            }
        }
    }
}
