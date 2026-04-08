using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class VehiculoNegocio
    {
        private VehiculoDatos vehiculoDatos = new VehiculoDatos();

        public string Registrar(Vehiculo vehiculo)
        {
            if (vehiculoDatos.ExistePlaca(vehiculo.Placa))
            {
                return "Ya existe un vehículo registrado con esa placa.";
            }

            return vehiculoDatos.RegistrarVehiculo(vehiculo);
        }

        public string Modificar(Vehiculo vehiculo)
        {
            if (vehiculoDatos.ExistePlacaEnOtroVehiculo(vehiculo.Placa, vehiculo.VehiculoID))
            {
                return "Ya existe otro vehículo con esa placa.";
            }

            var vehiculoExistente = vehiculoDatos.ObtenerPorId(vehiculo.VehiculoID);
            if (vehiculoExistente == null)
            {
                return "Vehículo no encontrado.";
            }

            return vehiculoDatos.ModificarVehiculo(vehiculo);
        }

        public string EliminarVehiculo(int id)
        {
            return vehiculoDatos.EliminarVehiculo(id);
        }

        public List<Vehiculo> ListarTodosLosVehiculos()
        {
            return vehiculoDatos.ListarTodosLosVehiculos();
        }

        public Vehiculo ObtenerPorId(int id)
        {
            return vehiculoDatos.ObtenerPorId(id);
        }
    }


}
