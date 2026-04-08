using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class HorarioDisponiblesDatos

    {
        public List<Turno> ListarHorariosDisponibles()

        {

            try
            {
                using (var context = new db_EcoReciclaEntities())
                {
                    return context.Turno
                                  .OrderBy(t => t.HorarioInicio)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los horarios disponibles: " + ex.Message);
            }
        }
    }
}
