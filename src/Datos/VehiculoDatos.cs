using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VehiculoDatos
    {
        public Vehiculo ObtenerPorId(int id)
        {
            using (var context = new db_EcoReciclaEntities())
            {
                return context.Vehiculo.Find(id);
            }
        }

        public bool ExistePlaca(string placa)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Vehiculo.Any(v => v.Placa == placa);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar existencia de la placa: " + ex.Message);
            }
        }

        public bool ExistePlacaEnOtroVehiculo(string placa, int vehiculoId)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Vehiculo.Any(v => v.Placa == placa && v.VehiculoID != vehiculoId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar placa en otros vehículos: " + ex.Message);
            }
        }

        public string RegistrarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    if (ExistePlaca(vehiculo.Placa))
                        return "Error: La placa ya está registrada.";

                    context.Vehiculo.Add(vehiculo);
                    context.SaveChanges();
                    return "Vehículo registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar el vehículo: " + ex.Message;
            }
        }

        public string ModificarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    var vehiculoOriginal = context.Vehiculo.Find(vehiculo.VehiculoID);
                    if (vehiculoOriginal == null) return "Vehículo no encontrado.";

                    if (ExistePlacaEnOtroVehiculo(vehiculo.Placa, vehiculo.VehiculoID))
                        return "Error: La placa ya está registrada en otro vehículo.";

                    vehiculoOriginal.Placa = vehiculo.Placa;
                    vehiculoOriginal.Marca = vehiculo.Marca;
                    vehiculoOriginal.Modelo = vehiculo.Modelo;
                    vehiculoOriginal.TipoVehiculo = vehiculo.TipoVehiculo;
                    vehiculoOriginal.CapacidadTotal = vehiculo.CapacidadTotal;
                    vehiculoOriginal.Disponible = vehiculo.Disponible;

                    context.SaveChanges();
                    return "Vehículo modificado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar el vehículo: " + ex.Message;
            }
        }


        public string EliminarVehiculo(int id)
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    Vehiculo vehiculoTemp = context.Vehiculo.Find(id);
                    if (vehiculoTemp == null) return "Vehículo no encontrado.";

                    context.Vehiculo.Remove(vehiculoTemp);
                    context.SaveChanges();
                    return "Vehículo eliminado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el vehículo: " + ex.Message;
            }
        }

        public List<Vehiculo> ListarTodosLosVehiculos()
        {
            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Vehiculo.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los vehículos: " + ex.Message);
            }
        }
    }
}
