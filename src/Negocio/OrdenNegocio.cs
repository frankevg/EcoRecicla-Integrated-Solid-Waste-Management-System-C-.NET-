using Datos;
using System;
using System.Collections.Generic;
namespace Negocio
{
    public class OrdenNegocio
    {
        private OrdenDatos ordenDatos = new OrdenDatos();

        public string RegistrarOrdenRecojo(OrdenRecojo ordenRecojo)
        {
            return ordenDatos.RegistrarOrdenRecojo(ordenRecojo); // ✔ Llama correctamente al método en la capa Datos
        }


        public String EliminarOrdenRecojo(int ordenId)
        {
            return ordenDatos.EliminarOrdenRecojo(ordenId); // ✔ Llama correctamente al método en la capa Datos
        }


        public List<OrdenRecojo> ListarOrdenesRecojo()
        {

            return ordenDatos.ListarOrdenesRecojo();
        }


    }
}

