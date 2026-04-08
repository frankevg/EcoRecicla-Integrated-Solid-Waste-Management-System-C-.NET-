using Datos;
using System.Collections.Generic;
namespace Negocio
{
    public class TipoResiduoNegocio
    {
        private TipoResiduoDatos tipoResiduoDatos = new TipoResiduoDatos();
        public List<TipoResiduo> ListarTodosLosTiposDeResiduo()
        {

            {
                return tipoResiduoDatos.ListarTodosLosTiposDeResiduo();
            }

        }
    }
}
