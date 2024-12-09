namespace ComicsPOO.Windows
{
    partial class frmVentaAE
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
            components = new System.ComponentModel.Container();
            btnCancelar = new Button();
            btnOK = new Button();
            nudCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtTipoProducto = new TextBox();
            label6 = new Label();
            txtTotal = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 59);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(25, 187);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(102, 59);
            btnOK.TabIndex = 35;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(102, 122);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(98, 23);
            nudCantidad.TabIndex = 32;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(100, 91);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 29;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 61);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(360, 23);
            txtDescripcion.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 21;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 94);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 24;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 26;
            label1.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 97);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 24;
            label4.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(358, 94);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 35);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 26;
            label5.Text = "Tipo:";
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.Location = new Point(100, 32);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.ReadOnly = true;
            txtTipoProducto.Size = new Size(360, 23);
            txtTipoProducto.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 154);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 24;
            label6.Text = "Total a Pagar:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(100, 151);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 29;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmVentaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 274);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(nudCantidad);
            Controls.Add(txtStock);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecio);
            Controls.Add(txtTipoProducto);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(508, 313);
            MinimumSize = new Size(508, 313);
            Name = "frmVentaAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVenta";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private NumericUpDown nudCantidad;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtTipoProducto;
        private Label label6;
        private TextBox txtTotal;
        private ErrorProvider errorProvider1;
    }
}