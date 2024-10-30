namespace Kevin2024.Windows.Formularios
{
    partial class frmBebidasAE
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtSabor = new TextBox();
            checkBox1 = new CheckBox();
            cboTamanio = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            nupPrecioCosto = new NumericUpDown();
            nupPrecioVenta = new NumericUpDown();
            nupStock = new NumericUpDown();
            nupNivelReposicion = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtCodigoBarras = new TextBox();
            label11 = new Label();
            cboCategorias = new ComboBox();
            cboMarca = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupNivelReposicion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Constantia", 17.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 41);
            label1.TabIndex = 0;
            label1.Text = "¡Nueva Bebida!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F);
            label2.Location = new Point(43, 64);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 1;
            label2.Text = "Marca: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F);
            label3.Location = new Point(43, 106);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 2;
            label3.Text = "Sabor: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F);
            label4.Location = new Point(43, 154);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "Tamaño:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F);
            label6.Location = new Point(43, 271);
            label6.Name = "label6";
            label6.Size = new Size(101, 19);
            label6.TabIndex = 3;
            label6.Text = "Precio Costo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F);
            label7.Location = new Point(43, 300);
            label7.Name = "label7";
            label7.Size = new Size(102, 19);
            label7.TabIndex = 3;
            label7.Text = "Precio Venta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F);
            label8.Location = new Point(43, 346);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 4;
            label8.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F);
            label9.Location = new Point(43, 391);
            label9.Name = "label9";
            label9.Size = new Size(156, 19);
            label9.TabIndex = 4;
            label9.Text = "Nivel De Reposición:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F);
            label10.Location = new Point(43, 426);
            label10.Name = "label10";
            label10.Size = new Size(90, 19);
            label10.TabIndex = 4;
            label10.Text = "Suspendido";
            // 
            // txtSabor
            // 
            txtSabor.Location = new Point(119, 106);
            txtSabor.Name = "txtSabor";
            txtSabor.Size = new Size(224, 23);
            txtSabor.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(139, 430);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboTamanio
            // 
            cboTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTamanio.FormattingEnabled = true;
            cboTamanio.Location = new Point(119, 150);
            cboTamanio.Name = "cboTamanio";
            cboTamanio.Size = new Size(224, 23);
            cboTamanio.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // nupPrecioCosto
            // 
            nupPrecioCosto.DecimalPlaces = 2;
            nupPrecioCosto.Location = new Point(160, 271);
            nupPrecioCosto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupPrecioCosto.Name = "nupPrecioCosto";
            nupPrecioCosto.Size = new Size(83, 23);
            nupPrecioCosto.TabIndex = 6;
            // 
            // nupPrecioVenta
            // 
            nupPrecioVenta.DecimalPlaces = 2;
            nupPrecioVenta.Location = new Point(160, 301);
            nupPrecioVenta.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupPrecioVenta.Name = "nupPrecioVenta";
            nupPrecioVenta.Size = new Size(83, 23);
            nupPrecioVenta.TabIndex = 7;
            // 
            // nupStock
            // 
            nupStock.Location = new Point(101, 346);
            nupStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupStock.Name = "nupStock";
            nupStock.Size = new Size(83, 23);
            nupStock.TabIndex = 8;
            // 
            // nupNivelReposicion
            // 
            nupNivelReposicion.Location = new Point(205, 392);
            nupNivelReposicion.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupNivelReposicion.Name = "nupNivelReposicion";
            nupNivelReposicion.Size = new Size(83, 23);
            nupNivelReposicion.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(26, 459);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(193, 54);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(252, 459);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 54);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F);
            label5.Location = new Point(43, 203);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 2;
            label5.Text = "Cog.Barras: ";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(139, 203);
            txtCodigoBarras.MaxLength = 13;
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(204, 23);
            txtCodigoBarras.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F);
            label11.Location = new Point(43, 243);
            label11.Name = "label11";
            label11.Size = new Size(81, 19);
            label11.TabIndex = 3;
            label11.Text = "Categoria:";
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(130, 242);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(224, 23);
            cboCategorias.TabIndex = 5;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(119, 64);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(224, 23);
            cboMarca.TabIndex = 1;
            // 
            // frmBebidasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 538);
            Controls.Add(cboMarca);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nupNivelReposicion);
            Controls.Add(nupStock);
            Controls.Add(nupPrecioVenta);
            Controls.Add(nupPrecioCosto);
            Controls.Add(cboCategorias);
            Controls.Add(cboTamanio);
            Controls.Add(checkBox1);
            Controls.Add(txtCodigoBarras);
            Controls.Add(txtSabor);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBebidasAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBebidasAE";
            Load += frmBebidasAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupNivelReposicion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtSabor;
        private CheckBox checkBox1;
        private ComboBox cboTamanio;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnAceptar;
        private NumericUpDown nupNivelReposicion;
        private NumericUpDown nupStock;
        private NumericUpDown nupPrecioVenta;
        private NumericUpDown nupPrecioCosto;
        private TextBox txtCodigoBarras;
        private Label label5;
        private ComboBox cboCategorias;
        private Label label11;
        private ComboBox cboMarca;
    }
}