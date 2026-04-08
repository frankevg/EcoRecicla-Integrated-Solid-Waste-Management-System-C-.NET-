namespace TRABAJOPARCIAL
{
    partial class FormAsignaciones
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
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarAsignacion = new System.Windows.Forms.Button();
            this.btnModificarAsignacion = new System.Windows.Forms.Button();
            this.btnRegistrarAsignacion = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboConductor = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.dgvListadoAsignaciones = new System.Windows.Forms.DataGridView();
            this.gbOperaciones.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.btnEliminarAsignacion);
            this.gbOperaciones.Controls.Add(this.btnModificarAsignacion);
            this.gbOperaciones.Controls.Add(this.btnRegistrarAsignacion);
            this.gbOperaciones.Location = new System.Drawing.Point(383, 39);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(176, 166);
            this.gbOperaciones.TabIndex = 13;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            // 
            // btnEliminarAsignacion
            // 
            this.btnEliminarAsignacion.Location = new System.Drawing.Point(50, 120);
            this.btnEliminarAsignacion.Name = "btnEliminarAsignacion";
            this.btnEliminarAsignacion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAsignacion.TabIndex = 3;
            this.btnEliminarAsignacion.Text = "Eliminar";
            this.btnEliminarAsignacion.UseVisualStyleBackColor = true;
            this.btnEliminarAsignacion.Click += new System.EventHandler(this.btnEliminarAsignacion_Click_1);
            // 
            // btnModificarAsignacion
            // 
            this.btnModificarAsignacion.Location = new System.Drawing.Point(50, 80);
            this.btnModificarAsignacion.Name = "btnModificarAsignacion";
            this.btnModificarAsignacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAsignacion.TabIndex = 1;
            this.btnModificarAsignacion.Text = "Modificar";
            this.btnModificarAsignacion.UseVisualStyleBackColor = true;
            this.btnModificarAsignacion.Click += new System.EventHandler(this.btnModificarAsignacion_Click_1);
            // 
            // btnRegistrarAsignacion
            // 
            this.btnRegistrarAsignacion.Location = new System.Drawing.Point(50, 35);
            this.btnRegistrarAsignacion.Name = "btnRegistrarAsignacion";
            this.btnRegistrarAsignacion.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarAsignacion.TabIndex = 0;
            this.btnRegistrarAsignacion.Text = "Registrar";
            this.btnRegistrarAsignacion.UseVisualStyleBackColor = true;
            this.btnRegistrarAsignacion.Click += new System.EventHandler(this.btnRegistrarAsignacion_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblConductor);
            this.gbDatos.Controls.Add(this.cboVehiculo);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.cboConductor);
            this.gbDatos.Controls.Add(this.dtpFecha);
            this.gbDatos.Controls.Add(this.lblVehiculo);
            this.gbDatos.Location = new System.Drawing.Point(12, 39);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(325, 166);
            this.gbDatos.TabIndex = 12;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(17, 80);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(56, 13);
            this.lblConductor.TabIndex = 6;
            this.lblConductor.Text = "Conductor";
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Location = new System.Drawing.Point(110, 42);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cboVehiculo.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // cboConductor
            // 
            this.cboConductor.FormattingEnabled = true;
            this.cboConductor.Location = new System.Drawing.Point(110, 77);
            this.cboConductor.Name = "cboConductor";
            this.cboConductor.Size = new System.Drawing.Size(121, 21);
            this.cboConductor.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(110, 119);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(17, 45);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(48, 13);
            this.lblVehiculo.TabIndex = 5;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // dgvListadoAsignaciones
            // 
            this.dgvListadoAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAsignaciones.Location = new System.Drawing.Point(12, 234);
            this.dgvListadoAsignaciones.Name = "dgvListadoAsignaciones";
            this.dgvListadoAsignaciones.Size = new System.Drawing.Size(547, 158);
            this.dgvListadoAsignaciones.TabIndex = 11;
            // 
            // FormAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 430);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvListadoAsignaciones);
            this.Name = "FormAsignaciones";
            this.Text = "Asignaciones";
            this.gbOperaciones.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAsignaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Button btnEliminarAsignacion;
        private System.Windows.Forms.Button btnModificarAsignacion;
        private System.Windows.Forms.Button btnRegistrarAsignacion;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboConductor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.DataGridView dgvListadoAsignaciones;
    }
}