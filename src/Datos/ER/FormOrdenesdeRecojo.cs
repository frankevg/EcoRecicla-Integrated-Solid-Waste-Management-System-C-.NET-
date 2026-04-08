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
    public partial class FormOrdenesdeRecojo : Form
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private TipoResiduoNegocio tipoResiduoNegocio = new TipoResiduoNegocio();
        private HorarioDisponibleNegocio turnoNegocio = new HorarioDisponibleNegocio();
        private OrdenNegocio ordenNegocio = new OrdenNegocio();
        private AsignacionNegocio asignacionNegocio = new AsignacionNegocio();
        private ConductorNegocio conductorNegocio = new ConductorNegocio();
        private VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();



        public FormOrdenesdeRecojo()
        {
            InitializeComponent();
            MostrarClientes(clienteNegocio.ListarTodosLosClientes());
            MostrarTiposdeResiduos(tipoResiduoNegocio.ListarTodosLosTiposDeResiduo());
            MostrarHorarios(turnoNegocio.ListarHorariosDisponibles());
            MostrarOrdenes(ordenNegocio.ListarOrdenesRecojo());

        }
        private void MostrarClientes(List<Cliente> clientes)
        {
            cboCliente.DataSource = null;

            if (clientes.Count > 0)
            {
                cboCliente.DataSource = clientes;
                cboCliente.DisplayMember = "Nombre";
                cboCliente.ValueMember = "ClienteID";
            }
        }
        private void MostrarTiposdeResiduos(List<TipoResiduo> tipos)
        {
            cboTipo.DataSource = null;
            if (tipos.Count > 0)
            {
                cboTipo.DataSource = tipos;
                cboTipo.DisplayMember = "Nombre";
                cboTipo.ValueMember = "TipoResiduoID";
            }
        }
        private void MostrarHorarios(List<Turno> horarios)
        {
            cboHorario.DataSource = null;
            if (horarios.Count > 0)
            {
                cboHorario.DataSource = horarios;
                cboHorario.DisplayMember = "HorarioInicio";
                cboHorario.ValueMember = "TurnoID";
            }
        }

        private void MostrarOrdenes(List<OrdenRecojo> ordenes)
        {
            dgvListadoOrdenes.DataSource = null;
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

                dgvListadoOrdenes.DataSource = datos;
            }
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            if (cboCliente.Text == "" || dtpFecha.Text == "" || cboHorario.Text == "" || cboTipo.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            // Validamos que la cantidad sea un numero
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número válido.");
                return;
            }
           
            // Creamos el Objeto Orden
            OrdenRecojo orden = new OrdenRecojo
            {
                ClienteID = (int)cboCliente.SelectedValue, // Obtenemos el ID del cliente seleccionado
                FechaSolicitud = DateTime.Now, // Fecha de solicitud es la fecha actual
                FechaRecojo = dtpFecha.Value,
                Horario = cboHorario.Text,

                TipoResiduoID = (int)cboTipo.SelectedValue, // Relación correcta
                Cantidad = cantidad,
            };

            ordenNegocio.RegistrarOrdenRecojo(orden);

            MessageBox.Show("Orden registrada exitosamente.");
          


            MostrarOrdenes(ordenNegocio.ListarOrdenesRecojo());
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada en el DataGridView
            if (dgvListadoOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para eliminar.");
                return;
            }
            //confirmamos la eliminacion de la orden
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la orden seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes) 
                {

                int ordenId = (int)dgvListadoOrdenes.SelectedRows[0].Cells["OrdenID"].Value; // Obtenemos el ID de la orden seleccionada
                string mensaje = ordenNegocio.EliminarOrdenRecojo(ordenId); // Llamamos al método de negocio para eliminar la orden
                
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarOrdenes(ordenNegocio.ListarOrdenesRecojo()); // Refrescamos la lista de órdenes
                }
             
            }
        }


    }
}
