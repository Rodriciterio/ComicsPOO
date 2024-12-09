namespace ComicsPOO.Windows
{
    partial class frmVentas
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
            panelSuperior = new Panel();
            cboTipos = new ComboBox();
            label1 = new Label();
            panelInferior = new Panel();
            btnCerrar = new Button();
            txtTotal = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label2 = new Label();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(cboTipos);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(949, 100);
            panelSuperior.TabIndex = 0;
            // 
            // cboTipos
            // 
            cboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipos.FormattingEnabled = true;
            cboTipos.Location = new Point(80, 23);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(121, 23);
            cboTipos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipos:";
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnCerrar);
            panelInferior.Controls.Add(txtTotal);
            panelInferior.Controls.Add(label3);
            panelInferior.Controls.Add(txtCantidad);
            panelInferior.Controls.Add(label2);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 443);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(949, 100);
            panelInferior.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(852, 19);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 69);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(273, 19);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 22);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Total:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(87, 19);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 100);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(949, 343);
            panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNro, colFecha, colDescripcion, colPrecio, colCantidad, colTotal });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(949, 343);
            dgvDatos.TabIndex = 0;
            // 
            // colNro
            // 
            colNro.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colNro.HeaderText = "Vta. Nro.";
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            colNro.Width = 78;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 543);
            Controls.Add(panelGrilla);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Name = "frmVentas";
            Text = "frmVentas";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelInferior;
        private Panel panelGrilla;
        private ComboBox cboTipos;
        private Label label1;
        private Button btnCerrar;
        private TextBox txtTotal;
        private Label label3;
        private TextBox txtCantidad;
        private Label label2;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colTotal;
    }
}