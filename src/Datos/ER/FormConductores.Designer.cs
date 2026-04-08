namespace TRABAJOPARCIAL
{
    partial class FormConductores
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
            this.dgvListadoConductores = new System.Windows.Forms.DataGridView();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarConductor = new System.Windows.Forms.Button();
            this.btnModificarConductor = new System.Windows.Forms.Button();
            this.btnRegistrarConductor = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cboLicencia = new System.Windows.Forms.ComboBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoConductores)).BeginInit();
            this.gbOperaciones.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoConductores
            // 
            this.dgvListadoConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoConductores.Location = new System.Drawing.Point(15, 249);
            this.dgvListadoConductores.Name = "dgvListadoConductores";
            this.dgvListadoConductores.Size = new System.Drawing.Size(542, 168);
            this.dgvListadoConductores.TabIndex = 14;
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.btnEliminarConductor);
            this.gbOperaciones.Controls.Add(this.btnModificarConductor);
            this.gbOperaciones.Controls.Add(this.btnRegistrarConductor);
            this.gbOperaciones.Location = new System.Drawing.Point(362, 14);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(196, 219);
            this.gbOperaciones.TabIndex = 13;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            // 
            // btnEliminarConductor
            // 
            this.btnEliminarConductor.Location = new System.Drawing.Point(34, 135);
            this.btnEliminarConductor.Name = "btnEliminarConductor";
            this.btnEliminarConductor.Size = new System.Drawing.Size(142, 23);
            this.btnEliminarConductor.TabIndex = 10;
            this.btnEliminarConductor.Text = "Eliminar Conductor";
            this.btnEliminarConductor.UseVisualStyleBackColor = true;
            this.btnEliminarConductor.Click += new System.EventHandler(this.btnEliminarConductor_Click);
            // 
            // btnModificarConductor
            // 
            this.btnModificarConductor.Location = new System.Drawing.Point(34, 90);
            this.btnModificarConductor.Name = "btnModificarConductor";
            this.btnModificarConductor.Size = new System.Drawing.Size(142, 23);
            this.btnModificarConductor.TabIndex = 9;
            this.btnModificarConductor.Text = "Modificar Conductor";
            this.btnModificarConductor.UseVisualStyleBackColor = true;
            this.btnModificarConductor.Click += new System.EventHandler(this.btnModificarConductor_Click);
            // 
            // btnRegistrarConductor
            // 
            this.btnRegistrarConductor.Location = new System.Drawing.Point(34, 45);
            this.btnRegistrarConductor.Name = "btnRegistrarConductor";
            this.btnRegistrarConductor.Size = new System.Drawing.Size(142, 23);
            this.btnRegistrarConductor.TabIndex = 8;
            this.btnRegistrarConductor.Text = "Registrar Conductor";
            this.btnRegistrarConductor.UseVisualStyleBackColor = true;
            this.btnRegistrarConductor.Click += new System.EventHandler(this.btnRegistrarConductor_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cboLicencia);
            this.gbDatos.Controls.Add(this.lblLicencia);
            this.gbDatos.Controls.Add(this.txtEmail);
            this.gbDatos.Controls.Add(this.lblEmail);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtTelefono);
            this.gbDatos.Controls.Add(this.txtDNI);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.lblDNI);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(12, 14);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(333, 219);
            this.gbDatos.TabIndex = 12;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cboLicencia
            // 
            this.cboLicencia.FormattingEnabled = true;
            this.cboLicencia.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3"});
            this.cboLicencia.Location = new System.Drawing.Point(96, 90);
            this.cboLicencia.Name = "cboLicencia";
            this.cboLicencia.Size = new System.Drawing.Size(214, 21);
            this.cboLicencia.TabIndex = 4;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(19, 90);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(47, 13);
            this.lblLicencia.TabIndex = 7;
            this.lblLicencia.Text = "Licencia";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(96, 120);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(214, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 150);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(214, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(96, 60);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(214, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 150);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 120);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(19, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // FormConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 430);
            this.Controls.Add(this.dgvListadoConductores);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbDatos);
            this.Name = "FormConductores";
            this.Text = "Conductores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoConductores)).EndInit();
            this.gbOperaciones.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoConductores;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Button btnEliminarConductor;
        private System.Windows.Forms.Button btnModificarConductor;
        private System.Windows.Forms.Button btnRegistrarConductor;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboLicencia;
        private System.Windows.Forms.Label lblLicencia;
    }
}