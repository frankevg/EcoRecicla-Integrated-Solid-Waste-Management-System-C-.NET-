namespace TRABAJOPARCIAL
{
    partial class FormReportes
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
            this.dgvListadoReportes = new System.Windows.Forms.DataGridView();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.btnClienteConMásOrdenes = new System.Windows.Forms.Button();
            this.btnClientesReporte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoReportes)).BeginInit();
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoReportes
            // 
            this.dgvListadoReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoReportes.Location = new System.Drawing.Point(14, 166);
            this.dgvListadoReportes.Name = "dgvListadoReportes";
            this.dgvListadoReportes.Size = new System.Drawing.Size(542, 252);
            this.dgvListadoReportes.TabIndex = 18;
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.button1);
            this.gbOperaciones.Controls.Add(this.btnEliminarOrden);
            this.gbOperaciones.Controls.Add(this.btnClienteConMásOrdenes);
            this.gbOperaciones.Controls.Add(this.btnClientesReporte);
            this.gbOperaciones.Location = new System.Drawing.Point(14, 12);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(542, 148);
            this.gbOperaciones.TabIndex = 19;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.Location = new System.Drawing.Point(34, 80);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(484, 23);
            this.btnEliminarOrden.TabIndex = 9;
            this.btnEliminarOrden.Text = "Eliminar Orden";
            this.btnEliminarOrden.UseVisualStyleBackColor = true;
            // 
            // btnClienteConMásOrdenes
            // 
            this.btnClienteConMásOrdenes.Location = new System.Drawing.Point(34, 51);
            this.btnClienteConMásOrdenes.Name = "btnClienteConMásOrdenes";
            this.btnClienteConMásOrdenes.Size = new System.Drawing.Size(484, 23);
            this.btnClienteConMásOrdenes.TabIndex = 8;
            this.btnClienteConMásOrdenes.Text = "Cliente con más Órdenes";
            this.btnClienteConMásOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnClientesReporte
            // 
            this.btnClientesReporte.Location = new System.Drawing.Point(34, 22);
            this.btnClientesReporte.Name = "btnClientesReporte";
            this.btnClientesReporte.Size = new System.Drawing.Size(484, 23);
            this.btnClientesReporte.TabIndex = 7;
            this.btnClientesReporte.Text = "Reporte de Clientes";
            this.btnClientesReporte.UseVisualStyleBackColor = true;
            this.btnClientesReporte.Click += new System.EventHandler(this.btnClientesReporte_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eliminar Orden";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 430);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.dgvListadoReportes);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoReportes)).EndInit();
            this.gbOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoReportes;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminarOrden;
        private System.Windows.Forms.Button btnClienteConMásOrdenes;
        private System.Windows.Forms.Button btnClientesReporte;
    }
}