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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes nuevoFormulario = new FormClientes();
            nuevoFormulario.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            FormOrdenesdeRecojo nuevoFormulario = new FormOrdenesdeRecojo();
            nuevoFormulario.Show();
        }

        private void btnConductores_Click(object sender, EventArgs e)
        {
            Form nuevoFormulario = new FormConductores();
            nuevoFormulario.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculos nuevoFormulario = new FormVehiculos();
            nuevoFormulario.Show();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            FormAsignaciones nuevoFormulario = new FormAsignaciones();
            nuevoFormulario.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes nuevoFormulario = new FormReportes();
            nuevoFormulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
