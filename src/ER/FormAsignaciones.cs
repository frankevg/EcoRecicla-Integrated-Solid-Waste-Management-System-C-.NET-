using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TRABAJOPARCIAL
{
    public partial class FormAsignaciones : Form
    {
        private int idSeleccionado = -1;
        public FormAsignaciones()
        {
            InitializeComponent();
        }

        private void FormAsignaciones_Load(object sender, EventArgs e)
        {
            cboVehiculo.DataSource = new VehiculoNegocio().ListarTodosLosVehiculos();
            cboVehiculo.DisplayMember = "Placa";
            cboVehiculo.ValueMember = "VehiculoID";

            cboConductor.DataSource = new ConductorNegocio().ListarTodosLosConductores();
            cboConductor.DisplayMember = "NombreCompleto";
            cboConductor.ValueMember = "ConductorID";

            CargarAsignaciones();
        }
        private void CargarAsignaciones()
        {
            var lista = new AsignacionNegocio().ListarTodas()
                .Select(a => new
                {
                    a.AsignacionID,
                    Vehiculo = a.Vehiculo.Placa,
                    Conductor = a.Conductor.Nombre,
                    Fecha = a.FechaAsignacion.ToShortDateString()
                }).ToList();

            dgvListadoAsignaciones.DataSource = lista;
        }
        private void btnRegistrarAsignacion_Click(object sender, EventArgs e)
        {
            Asignacion nueva = new Asignacion
            {
                VehiculoID = (int)cboVehiculo.SelectedValue,
                ConductorID = (int)cboConductor.SelectedValue,
                FechaAsignacion = dtpFecha.Value.Date
            };

            string resultado = new AsignacionNegocio().Registrar(nueva);
            MessageBox.Show(resultado);

            if (resultado.Contains("correctamente"))
            {
                CargarAsignaciones();
            }
        }

       
      

        private void btnModificarAsignacion_Click_1(object sender, EventArgs e)
        {
            {
                if (idSeleccionado == -1)
                {
                    MessageBox.Show("Seleccione una asignación para modificar.");
                    return;
                }

                Asignacion modificada = new Asignacion
                {
                    AsignacionID = idSeleccionado,
                    VehiculoID = (int)cboVehiculo.SelectedValue,
                    ConductorID = (int)cboConductor.SelectedValue,
                    FechaAsignacion = dtpFecha.Value.Date
                };

                string resultado = new AsignacionNegocio().Modificar(modificada);
                MessageBox.Show(resultado);

                if (resultado.Contains("correctamente"))
                {
                    CargarAsignaciones();
                    idSeleccionado = -1;
                }
            }
        }

        private void btnEliminarAsignacion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarAsignacion_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione una asignación para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta asignación?", "Confirmación", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                string resultado = new AsignacionNegocio().Eliminar(idSeleccionado);
                MessageBox.Show(resultado);

                if (resultado.Contains("correctamente"))
                {
                    CargarAsignaciones();
                    idSeleccionado = -1;
                }
            }

        }
        private void dgvListadoAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvListadoAsignaciones.Rows[e.RowIndex].Cells["AsignacionID"].Value);
                cboVehiculo.Text = dgvListadoAsignaciones.Rows[e.RowIndex].Cells["Vehiculo"].Value.ToString();
                cboConductor.Text = dgvListadoAsignaciones.Rows[e.RowIndex].Cells["Conductor"].Value.ToString();
                dtpFecha.Text = dgvListadoAsignaciones.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            }
        }
    }
}
