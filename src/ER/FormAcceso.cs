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
    public partial class FormAcceso : Form
    {
        public FormAcceso()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FormPrincipal nuevoFormulario = new FormPrincipal();
            nuevoFormulario.Show();
        }

        private void btnOlvideContrasena_Click(object sender, EventArgs e)
        {

        }
    }
}
