using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class HorarioDisponibleNegocio
    {
        private HorarioDisponiblesDatos horarioDisponiblesDatos = new HorarioDisponiblesDatos();
        public List<Turno> ListarHorariosDisponibles()
        {

            {
                return horarioDisponiblesDatos.ListarHorariosDisponibles();
            }

        }
    }
}
