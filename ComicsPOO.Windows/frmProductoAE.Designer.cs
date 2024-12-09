namespace ComicsPOO.Windows
{
    partial class frmProductoAE
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
            cboTipo = new ComboBox();
            nudStock = new NumericUpDown();
            txtPrecio = new TextBox();
            txtAutor = new TextBox();
            txtDescripcion = new TextBox();
            label3 = new Label();
            lblTipo = new Label();
            label2 = new Label();
            lblAutor = new Label();
            gbTipo = new GroupBox();
            rbtFigurita = new RadioButton();
            rbtComic = new RadioButton();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblAltura = new Label();
            txtAltura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(369, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 59);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(38, 269);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(102, 59);
            btnOK.TabIndex = 20;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(111, 192);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 18;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(113, 128);
            nudStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(98, 23);
            nudStock.TabIndex = 17;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 97);
            txtPrecio.MaxLength = 5;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 14;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(111, 160);
            txtAutor.MaxLength = 50;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(360, 23);
            txtAutor.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(111, 67);
            txtDescripcion.MaxLength = 30;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(360, 23);
            txtDescripcion.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Stock:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(33, 191);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Precio:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(33, 163);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 10;
            lblAutor.Text = "Autor:";
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(rbtFigurita);
            gbTipo.Controls.Add(rbtComic);
            gbTipo.Location = new Point(35, 12);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(224, 44);
            gbTipo.TabIndex = 12;
            gbTipo.TabStop = false;
            gbTipo.Text = " Tipo ";
            // 
            // rbtFigurita
            // 
            rbtFigurita.AutoSize = true;
            rbtFigurita.Location = new Point(113, 19);
            rbtFigurita.Name = "rbtFigurita";
            rbtFigurita.Size = new Size(65, 19);
            rbtFigurita.TabIndex = 0;
            rbtFigurita.Text = "Figurita";
            rbtFigurita.UseVisualStyleBackColor = true;
            // 
            // rbtComic
            // 
            rbtComic.AutoSize = true;
            rbtComic.Checked = true;
            rbtComic.Location = new Point(12, 19);
            rbtComic.Name = "rbtComic";
            rbtComic.Size = new Size(60, 19);
            rbtComic.TabIndex = 0;
            rbtComic.TabStop = true;
            rbtComic.Text = "Comic";
            rbtComic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 11;
            label1.Text = "Descripción:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(291, 102);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 7;
            lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(369, 99);
            txtAltura.MaxLength = 5;
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 13;
            // 
            // frmProductoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 341);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboTipo);
            Controls.Add(nudStock);
            Controls.Add(txtAltura);
            Controls.Add(txtPrecio);
            Controls.Add(txtAutor);
            Controls.Add(txtDescripcion);
            Controls.Add(lblAltura);
            Controls.Add(label3);
            Controls.Add(lblTipo);
            Controls.Add(label2);
            Controls.Add(lblAutor);
            Controls.Add(gbTipo);
            Controls.Add(label1);
            Name = "frmProductoAE";
            Text = "frmProductoAE";
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private ComboBox cboTipo;
        private NumericUpDown nudStock;
        private TextBox txtPrecio;
        private TextBox txtAutor;
        private TextBox txtDescripcion;
        private Label label3;
        private Label lblTipo;
        private Label label2;
        private Label lblAutor;
        private GroupBox gbTipo;
        private RadioButton rbtFigurita;
        private RadioButton rbtComic;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox txtAltura;
        private Label lblAltura;
    }
}