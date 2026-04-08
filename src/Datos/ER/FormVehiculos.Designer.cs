namespace TRABAJOPARCIAL
{
    partial class FormVehiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListadoVehiculos = new System.Windows.Forms.DataGridView();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.btnRegistrarVehiculo = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVehiculos)).BeginInit();
            this.gbOperaciones.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoVehiculos
            // 
            this.dgvListadoVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoVehiculos.Location = new System.Drawing.Point(15, 222);
            this.dgvListadoVehiculos.Name = "dgvListadoVehiculos";
            this.dgvListadoVehiculos.Size = new System.Drawing.Size(542, 195);
            this.dgvListadoVehiculos.TabIndex = 14;
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.btnEliminarVehiculo);
            this.gbOperaciones.Controls.Add(this.btnModificarVehiculo);
            this.gbOperaciones.Controls.Add(this.btnRegistrarVehiculo);
            this.gbOperaciones.Location = new System.Drawing.Point(362, 14);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(196, 193);
            this.gbOperaciones.TabIndex = 13;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(34, 135);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(142, 23);
            this.btnEliminarVehiculo.TabIndex = 9;
            this.btnEliminarVehiculo.Text = "Eliminar Vehículo";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Location = new System.Drawing.Point(34, 90);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(142, 23);
            this.btnModificarVehiculo.TabIndex = 8;
            this.btnModificarVehiculo.Text = "Modificar Vehículo";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // btnRegistrarVehiculo
            // 
            this.btnRegistrarVehiculo.Location = new System.Drawing.Point(34, 45);
            this.btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            this.btnRegistrarVehiculo.Size = new System.Drawing.Size(142, 23);
            this.btnRegistrarVehiculo.TabIndex = 7;
            this.btnRegistrarVehiculo.Text = "Registrar Vehículo";
            this.btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistrarVehiculo.Click += new System.EventHandler(this.btnRegistrarVehiculo_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cboTipo);
            this.gbDatos.Controls.Add(this.lblToneladas);
            this.gbDatos.Controls.Add(this.txtCapacidad);
            this.gbDatos.Controls.Add(this.lblCapacidad);
            this.gbDatos.Controls.Add(this.txtModelo);
            this.gbDatos.Controls.Add(this.txtMarca);
            this.gbDatos.Controls.Add(this.txtPlaca);
            this.gbDatos.Controls.Add(this.lblTipo);
            this.gbDatos.Controls.Add(this.lblModelo);
            this.gbDatos.Controls.Add(this.lblMarca);
            this.gbDatos.Controls.Add(this.lblPlaca);
            this.gbDatos.Location = new System.Drawing.Point(12, 14);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(333, 193);
            this.gbDatos.TabIndex = 12;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3"});
            this.cboTipo.Location = new System.Drawing.Point(96, 120);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(214, 21);
            this.cboTipo.TabIndex = 5;
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(190, 153);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(57, 13);
            this.lblToneladas.TabIndex = 7;
            this.lblToneladas.Text = "Toneladas";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(96, 150);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(88, 20);
            this.txtCapacidad.TabIndex = 6;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(19, 150);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 0;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(96, 90);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(214, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(96, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(214, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(96, 30);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(214, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 120);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(19, 90);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(19, 60);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(19, 30);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 430);
            this.Controls.Add(this.dgvListadoVehiculos);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbDatos);
            this.Name = "FormVehiculos";
            this.Text = "Vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVehiculos)).EndInit();
            this.gbOperaciones.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoVehiculos;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.Button btnRegistrarVehiculo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}