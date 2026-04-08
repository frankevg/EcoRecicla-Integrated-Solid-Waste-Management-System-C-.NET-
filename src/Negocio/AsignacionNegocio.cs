using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class AsignacionNegocio
    {
        private AsignacionDatos dataAsignacion = new AsignacionDatos();

        public string Registrar(Asignacion asignacion)
        {
            return dataAsignacion.RegistrarAsignacion(asignacion);
        }

        public string Modificar(Asignacion asignacion)
        {
            return dataAsignacion.ModificarAsignacion(asignacion);
        }

        public string Eliminar(int id)
        {
            return dataAsignacion.EliminarAsignacion(id);
        }

        public List<Asignacion> ListarTodas()
        {
            return dataAsignacion.ListarTodasLasAsignaciones();
        }

        public Asignacion ObtenerPorId(int id)
        {
            return dataAsignacion.ObtenerPorId(id);
        }

        public List<Asignacion> ListarPorFecha(DateTime fecha)
        {
            return dataAsignacion.ListarAsignacionesPorFecha(fecha);
        }
    }
}
