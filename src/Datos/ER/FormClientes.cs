using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace TRABAJOPARCIAL
{
    public partial class FormClientes : Form
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();


        public FormClientes()
        {
            InitializeComponent();
            MostrarCLientes(clienteNegocio.ListarTodosLosClientes());
        }
        private void MostrarCLientes(List<Datos.Cliente> clientes)
        {
            dgvListadoClientes.DataSource = null;
            if (clientes.Count > 0)
            {
                var datos = clientes.Select(c => new
                {
                    c.ClienteID,
                    c.Nombre,
                    c.RUC,
                    c.Direccion,
                    c.Telefono,
                    c.Email
                }).ToList();

                dgvListadoClientes.DataSource = datos;
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtRUC.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!long.TryParse(txtRUC.Text, out _))
            {
                MessageBox.Show("El RUC debe ser un número válido.");
                return;
            }
            if (txtRUC.Text.Length != 11)
            {
                MessageBox.Show("El RUC debe tener exactamente 11 dígitos numéricos");
                return;
            }
            if (!long.TryParse(txtRUC.Text, out long ruc) || ruc <= 0)
            {
                MessageBox.Show("El RUC debe ser un número positivo.");
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

            Datos.Cliente cliente = new Datos.Cliente
            {
                Nombre = txtNombre.Text,
                RUC = txtRUC.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Estado = true
            };
            bool registrado = clienteNegocio.Registrar(cliente);

            if (!registrado)
            {
                MessageBox.Show("Ya existe un cliente con ese RUC.");
            }
            else
            {
                MessageBox.Show("Cliente registrado exitosamente.");
                MostrarCLientes(clienteNegocio.ListarTodosLosClientes());
            }

        }


        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            // Confirmación antes de modificar
            DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar los datos de los clientes?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            bool huboErrores = false;

            foreach (DataGridViewRow row in dgvListadoClientes.Rows)
            {
                if (row.IsNewRow) continue;

                if (!int.TryParse(row.Cells["ClienteID"].Value?.ToString(), out int id)) continue;

                var cliente = new Cliente
                {
                    ClienteID = id,
                    Nombre = row.Cells["Nombre"].Value?.ToString(),
                    RUC = row.Cells["RUC"].Value?.ToString(),
                    Direccion = row.Cells["Direccion"].Value?.ToString(),
                    Telefono = row.Cells["Telefono"].Value?.ToString(),
                    Email = row.Cells["Email"].Value?.ToString(),
                };

                string resultadoModificacion = clienteNegocio.ModificarCliente(cliente);
                if (!resultadoModificacion.StartsWith("Cliente modificado"))
                {
                    MessageBox.Show($"Error al modificar cliente ID {id}: {resultadoModificacion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    huboErrores = true;
                }
            }

            if (!huboErrores)
            {
                MessageBox.Show("Cambios guardados correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refrescar la lista
            MostrarCLientes(clienteNegocio.ListarTodosLosClientes());
        }




        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //validamos la seleccion de clientes
            if (dgvListadoClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                return;
            }

            //Confirmamos la eliminacion
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvListadoClientes.CurrentRow.Cells["ClienteID"].Value);

                string mensaje = clienteNegocio.EliminarCliente(id);

                MessageBox.Show(mensaje);
                MostrarCLientes(clienteNegocio.ListarTodosLosClientes());
            }
        }

    }
}
