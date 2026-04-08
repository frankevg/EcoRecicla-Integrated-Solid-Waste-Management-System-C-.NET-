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

namespace TRABAJOPARCIAL //presentacion
{
    public partial class FormVehiculos : Form
    {
        private VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();
        public FormVehiculos()
        {
            InitializeComponent();
            MostrarVehiculos(vehiculoNegocio.ListarTodosLosVehiculos());
            dgvListadoVehiculos.DataError += dgvListadoVehiculos_DataError;
        }
        private void dgvListadoVehiculos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }
        private void MostrarVehiculos(List<Vehiculo> vehiculos)
        {
            dgvListadoVehiculos.DataSource = null;
            if (vehiculos.Count != 0)
            {
                dgvListadoVehiculos.DataSource = vehiculos;
            }
        }
        private void LimpiarCampos()
        {
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            cboTipo.Text = "";
            txtCapacidad.Text = "";
        }
        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cboTipo.Text == "" || txtCapacidad.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            int capacidad;
            if (!int.TryParse(txtCapacidad.Text, out capacidad))
            {
                MessageBox.Show("La capacidad debe ser un número válido.");
                return;
            }

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.TipoVehiculo = cboTipo.Text;
            vehiculo.CapacidadTotal = capacidad;
            vehiculo.Disponible = true;

            string mensaje = vehiculoNegocio.Registrar(vehiculo);

            if (mensaje.StartsWith("Ya existe"))
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show(mensaje);
                MostrarVehiculos(vehiculoNegocio.ListarTodosLosVehiculos());
                LimpiarCampos();
            }
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            if (dgvListadoVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo para modificar.");
                return;
            }

            if (txtPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cboTipo.Text == "" || txtCapacidad.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtCapacidad.Text, out int capacidad))
            {
                MessageBox.Show("La capacidad debe ser un número válido.");
                return;
            }

            int id = Convert.ToInt32(dgvListadoVehiculos.CurrentRow.Cells["VehiculoID"].Value);

            Vehiculo vehiculoMod = new Vehiculo
            {
                VehiculoID = id,
                Placa = txtPlaca.Text.Trim(),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                TipoVehiculo = cboTipo.Text,
                CapacidadTotal = capacidad
            };

            string resultado = vehiculoNegocio.Modificar(vehiculoMod);

            if (resultado.StartsWith("Vehículo modificado"))
            {
                MessageBox.Show("Vehículo modificado exitosamente.");
                MostrarVehiculos(vehiculoNegocio.ListarTodosLosVehiculos());
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error: " + resultado);
            }
        }

      

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (dgvListadoVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este vehículo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvListadoVehiculos.CurrentRow.Cells["VehiculoID"].Value);
                string mensaje = vehiculoNegocio.EliminarVehiculo(id);
                MessageBox.Show(mensaje);
                MostrarVehiculos(vehiculoNegocio.ListarTodosLosVehiculos());
                LimpiarCampos();
            }
        }
    }
}
