using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConductorNegocio
    {
        private ConductorDatos conductorDatos = new ConductorDatos();

        public Conductor ObtenerPorId(int id)
        {
            return conductorDatos.ObtenerPorId(id);
        }

        public string Registrar(Conductor conductor)
        {
            if (conductorDatos.ExisteDNI(conductor.DNI))
            {
                return "Ya existe un conductor registrado con ese DNI.";
            }

            return conductorDatos.RegistrarConductor(conductor);
        }

        public string Modificar(Conductor conductor)
        {
            if (conductorDatos.ExisteDNIEnOtroConductor(conductor.DNI, conductor.ConductorID))
            {
                return "Ya existe otro conductor con ese DNI.";
            }

            var conductorExistente = conductorDatos.ObtenerPorId(conductor.ConductorID);
            if (conductorExistente == null)
            {
                return "Conductor no encontrado.";
            }

            return conductorDatos.ModificarConductor(conductor);
        }

        public string Eliminar(int id)
        {
            return conductorDatos.EliminarConductor(id);
        }

        public List<Conductor> ListarTodosLosConductores()
        {
            return conductorDatos.ListarTodosLosConductores();
        }



    }
}
