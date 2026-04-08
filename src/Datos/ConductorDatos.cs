using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConductorDatos
    {
        public Conductor ObtenerPorId(int id)
        {
            using (var context = new db_EcoReciclaEntities())
            {
                return context.Conductor.Find(id);
            }
        }

        public bool ExisteDNI(string dni)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Conductor.Any(c => c.DNI == dni);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar existencia del DNI: " + ex.Message);
            }
        }

        public bool ExisteDNIEnOtroConductor(string dni, int conductorId)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Conductor.Any(c => c.DNI == dni && c.ConductorID != conductorId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar DNI en otros conductores: " + ex.Message);
            }
        }

        public string RegistrarConductor(Conductor conductor)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    context.Conductor.Add(conductor);
                    context.SaveChanges();
                    return "Conductor registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar el conductor: " + ex.Message;
            }
        }

        public string ModificarConductor(Conductor conductor)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    var conductorOriginal = context.Conductor.Find(conductor.ConductorID);
                    if (conductorOriginal == null) return "Conductor no encontrado.";

                    conductorOriginal.Nombre = conductor.Nombre;
                    conductorOriginal.DNI = conductor.DNI;
                    conductorOriginal.Licencia = conductor.Licencia;
                    conductorOriginal.Direccion = conductor.Direccion;
                    conductorOriginal.Telefono = conductor.Telefono;
                    conductorOriginal.Email = conductor.Email;
                    conductorOriginal.Estado = conductor.Estado;
                    conductorOriginal.Activo = conductor.Activo;

                    context.SaveChanges();
                    return "Conductor modificado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar el conductor: " + ex.Message;
            }
        }

        public string EliminarConductor(int id)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    Conductor conductorTemp = context.Conductor.Find(id);
                    if (conductorTemp == null) return "Conductor no encontrado.";

                    context.Conductor.Remove(conductorTemp);
                    context.SaveChanges();
                    return "Conductor eliminado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el conductor: " + ex.Message;
            }
        }

        public List<Conductor> ListarTodosLosConductores()
        {
            List<Conductor> conductores = new List<Conductor>();
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    conductores = context.Conductor.ToList();
                }
                return conductores;
            }
            catch (Exception ex)
            {
                return conductores;
                throw new Exception("Error al listar los conductores: " + ex.Message);
            }
        }
    }
}

