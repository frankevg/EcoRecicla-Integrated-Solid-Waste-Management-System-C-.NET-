using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class TipoResiduoDatos
    {
        public List<TipoResiduo> ListarTodosLosTiposDeResiduo()
        {

            try
            {
                using (var context = new db_EcoReciclaEntities())

                {
                    return context.TipoResiduo.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los tipos de residuo: " + ex.Message);
            }
        }
    }
}
