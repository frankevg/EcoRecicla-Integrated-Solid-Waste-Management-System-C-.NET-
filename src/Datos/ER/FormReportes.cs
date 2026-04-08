using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJOPARCIAL
{
    public partial class FormReportes : Form
    {
        private OrdenNegocio ordenNegocio = new OrdenNegocio();
        public FormReportes()
        {
            InitializeComponent();
            MostrarOrdenes(ordenNegocio.ListarOrdenesRecojo());
        }

        private void MostrarOrdenes(List<OrdenRecojo> ordenes)
        {
            dgvListadoReportes.DataSource = null;
            if (ordenes.Count > 0)
            {
                var datos = ordenes.Select(o => new
                {
                    OrdenID = o.OrdenID,
                    Cliente = o.Cliente?.Nombre,  // Aquí mostramos el nombre del cliente
                    o.FechaSolicitud,
                    o.FechaRecojo,
                    o.Horario,
                    Direccion = o.Cliente?.Direccion,
                    TipoResiduo = o.TipoResiduo?.Nombre, // Aquí mostramos el nombre del tipo de residuo
                    o.Cantidad,
                    // Agrega más campos si los necesitas, como TipoResiduo, Cantidad, etc.
                }).ToList();

                dgvListadoReportes.DataSource = datos;
            }
        }
        private void btnClientesReporte_Click(object sender, EventArgs e)
        {
            MostrarOrdenes(ordenNegocio.ListarOrdenesRecojo());
        }
    }
}
