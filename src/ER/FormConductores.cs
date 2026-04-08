using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace TRABAJOPARCIAL
{
    public partial class FormConductores : Form
    {
        private ConductorNegocio conductorNegocio = new ConductorNegocio();

        public FormConductores()
        {
            InitializeComponent();
            MostrarConductores(conductorNegocio.ListarTodosLosConductores());
            dgvListadoConductores.DataError += dgvListadoConductores_DataError; //hasta implemetar asigancion, sino sale cuadro de error
        }
        private void dgvListadoConductores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }
        private void MostrarConductores(List<Conductor> conductores)
        {
            dgvListadoConductores.DataSource = null;
            if (conductores.Count > 0)
            {
                dgvListadoConductores.DataSource = conductores;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            cboLicencia.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }


        private void btnRegistrarConductor_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDNI.Text == "" || cboLicencia.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios");
                return;
            }


            if (!long.TryParse(txtDNI.Text, out _))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }
            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos");
                return;
            }
            if (!long.TryParse(txtDNI.Text, out long DNI) || DNI <= 0)
            {
                MessageBox.Show("El DNI debe ser un número positivo.");
                return;
            }


            if (!int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El teléfono debe ser un número válido.");
                return;
            }
            if (txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 9 dígitos");
                return;
            }
            if (!int.TryParse(txtTelefono.Text, out int telefono) || telefono <= 0)
            {
                MessageBox.Show("El teléfono debe ser un número positivo.");
            }
            Conductor nuevoConductor = new Conductor()
            {
                Nombre = txtNombre.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Licencia = cboLicencia.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Activo = true
            };

            string mensaje = conductorNegocio.Registrar(nuevoConductor);
            MessageBox.Show(mensaje);

            if (mensaje.StartsWith("Conductor registrado"))
            {
                MostrarConductores(conductorNegocio.ListarTodosLosConductores());
                LimpiarCampos();
            }
        }

        private void btnModificarConductor_Click(object sender, EventArgs e)
        {
            if (dgvListadoConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un conductor para modificar.");
                return;
            }

            if (txtNombre.Text == "" || txtDNI.Text == "" || cboLicencia.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios");
                return;
            }

            if (!int.TryParse(dgvListadoConductores.CurrentRow.Cells["ConductorID"].Value.ToString(), out int id))
            {
                MessageBox.Show("ID de conductor inválido.");
                return;
            }
            


            Conductor conductorMod = new Conductor()
            {
                ConductorID = id,
                Nombre = txtNombre.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Licencia = cboLicencia.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Activo = true
            };

            string resultado = conductorNegocio.Modificar(conductorMod);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("Conductor modificado"))
            {
                MostrarConductores(conductorNegocio.ListarTodosLosConductores());
                LimpiarCampos();
            }
        }

        private void btnListarConductores_Click_1(object sender, EventArgs e)
        {
            if (dgvListadoConductores.SelectedRows.Count > 0)
            {
                var fila = dgvListadoConductores.CurrentRow;
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDNI.Text = fila.Cells["DNI"].Value.ToString();
                cboLicencia.Text = fila.Cells["Licencia"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                txtEmail.Text = fila.Cells["Email"].Value?.ToString() ?? "";
            }
        }

        private void btnEliminarConductor_Click(object sender, EventArgs e)
        {
            if (dgvListadoConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un conductor para eliminar.");
                return;
            }

            DialogResult res = MessageBox.Show("¿Está seguro que desea eliminar este conductor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvListadoConductores.CurrentRow.Cells["ConductorID"].Value);
                string mensaje = conductorNegocio.Eliminar(id);
                MessageBox.Show(mensaje);
                MostrarConductores(conductorNegocio.ListarTodosLosConductores());
                LimpiarCampos();
            }
        }

        private void cboLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
