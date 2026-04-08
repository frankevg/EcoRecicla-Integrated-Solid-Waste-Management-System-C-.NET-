using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class AsignacionDatos
    {
        public Asignacion ObtenerPorId(int id)
        {
            using (var context = new db_EcoReciclaEntities())
            {
                return context.Asignacion.Find(id);
            }
        }

        public bool VehiculoAsignadoEnFecha(int vehiculoId, DateTime fecha)
        {
            var fechaInicio = fecha.Date;
            var fechaFin = fechaInicio.AddDays(1);

            using (var context = new db_EcoReciclaEntities())
            {
                return context.Asignacion.Any(a =>
                    a.VehiculoID == vehiculoId &&
                    a.FechaAsignacion >= fechaInicio &&
                    a.FechaAsignacion < fechaFin
                );
            }
        }

        public bool ConductorAsignadoEnFecha(int conductorId, DateTime fecha)
        {
            var fechaInicio = fecha.Date;
            var fechaFin = fechaInicio.AddDays(1);

            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Asignacion.Any(a =>
                        a.ConductorID == conductorId &&
                        a.FechaAsignacion >= fechaInicio &&
                        a.FechaAsignacion < fechaFin
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar asignación de conductor: " + ex.Message);
            }
        }

        public string RegistrarAsignacion(Asignacion asignacion)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    if (VehiculoAsignadoEnFecha(asignacion.VehiculoID.Value, asignacion.FechaAsignacion))
                        return "El vehículo ya está asignado para esta fecha.";

                    if (ConductorAsignadoEnFecha(asignacion.ConductorID.Value, asignacion.FechaAsignacion))
                        return "El conductor ya está asignado para esta fecha.";

                    context.Asignacion.Add(asignacion);
                    context.SaveChanges();

                    return "Asignación registrada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar la asignación: " + ex.Message;
            }
        }

        public string ModificarAsignacion(Asignacion asignacion)
        {
            var fechaInicio = asignacion.FechaAsignacion.Date;
            var fechaFin = fechaInicio.AddDays(1);

            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    var asignacionOriginal = context.Asignacion.Find(asignacion.AsignacionID);
                    if (asignacionOriginal == null) return "Asignación no encontrada.";

                    if (context.Asignacion.Any(a =>
                        a.VehiculoID == asignacion.VehiculoID &&
                        a.FechaAsignacion >= fechaInicio &&
                        a.FechaAsignacion < fechaFin &&
                        a.AsignacionID != asignacion.AsignacionID))
                        return "El vehículo ya está asignado para esta fecha en otra asignación.";

                    if (context.Asignacion.Any(a =>
                        a.ConductorID == asignacion.ConductorID &&
                        a.FechaAsignacion >= fechaInicio &&
                        a.FechaAsignacion < fechaFin &&
                        a.AsignacionID != asignacion.AsignacionID))
                        return "El conductor ya está asignado para esta fecha en otra asignación.";

                    asignacionOriginal.OrdenID = asignacion.OrdenID;
                    asignacionOriginal.VehiculoID = asignacion.VehiculoID;
                    asignacionOriginal.ConductorID = asignacion.ConductorID;
                    asignacionOriginal.FechaAsignacion = asignacion.FechaAsignacion;

                    context.SaveChanges();
                    return "Asignación modificada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar la asignación: " + ex.Message;
            }
        }

        public string EliminarAsignacion(int id)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    var asignacionTemp = context.Asignacion.Find(id);
                    if (asignacionTemp == null) return "Asignación no encontrada.";

                    context.Asignacion.Remove(asignacionTemp);
                    context.SaveChanges();

                    return "Asignación eliminada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar la asignación: " + ex.Message;
            }
        }

        public List<Asignacion> ListarTodasLasAsignaciones()
        {
            List<Asignacion> asignaciones = new List<Asignacion>();
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    asignaciones = context.Asignacion
                        .Include("Vehiculo")
                        .Include("Conductor")
                        .ToList();
                }
                return asignaciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las asignaciones: " + ex.Message);
            }
        }

        public List<Asignacion> ListarAsignacionesPorFecha(DateTime fecha)
        {
            var fechaInicio = fecha.Date;
            var fechaFin = fechaInicio.AddDays(1);

            List<Asignacion> asignaciones = new List<Asignacion>();
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    asignaciones = context.Asignacion
                        .Include("Vehiculo")
                        .Include("Conductor")
                        .Where(a => a.FechaAsignacion >= fechaInicio && a.FechaAsignacion < fechaFin)
                        .ToList();
                }
                return asignaciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar asignaciones por fecha: " + ex.Message);
            }
        }
    }
}
