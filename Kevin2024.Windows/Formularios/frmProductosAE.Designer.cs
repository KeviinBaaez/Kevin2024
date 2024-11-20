namespace Kevin2024.Windows.Formularios
{
    partial class frmProductosAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosAE));
            cboMarca = new ComboBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            nupNivelReposicion = new NumericUpDown();
            nupStock = new NumericUpDown();
            nupPrecioVenta = new NumericUpDown();
            nupPrecioCosto = new NumericUpDown();
            cboTamanio = new ComboBox();
            checkBox1 = new CheckBox();
            txtSabor = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label11 = new Label();
            txtCodigoBarras = new TextBox();
            label12 = new Label();
            cboCategorias = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel4 = new Panel();
            panel3 = new Panel();
            label13 = new Label();
            txtDescripcion = new TextBox();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            btnBuscar = new Button();
            groupBox4 = new GroupBox();
            panel2 = new Panel();
            panel1 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)nupNivelReposicion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioCosto).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.ItemHeight = 19;
            cboMarca.Location = new Point(137, 24);
            cboMarca.Margin = new Padding(4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(291, 27);
            cboMarca.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(727, 692);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(276, 68);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(410, 692);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(276, 68);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // nupNivelReposicion
            // 
            nupNivelReposicion.BackColor = Color.FromArgb(1, 95, 168);
            nupNivelReposicion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupNivelReposicion.Location = new Point(523, 493);
            nupNivelReposicion.Margin = new Padding(19, 16, 19, 16);
            nupNivelReposicion.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupNivelReposicion.Name = "nupNivelReposicion";
            nupNivelReposicion.Size = new Size(138, 26);
            nupNivelReposicion.TabIndex = 13;
            // 
            // nupStock
            // 
            nupStock.BackColor = Color.FromArgb(1, 95, 168);
            nupStock.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupStock.Location = new Point(178, 496);
            nupStock.Margin = new Padding(11, 10, 11, 10);
            nupStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupStock.Name = "nupStock";
            nupStock.Size = new Size(111, 26);
            nupStock.TabIndex = 12;
            // 
            // nupPrecioVenta
            // 
            nupPrecioVenta.BackColor = Color.FromArgb(1, 95, 168);
            nupPrecioVenta.DecimalPlaces = 2;
            nupPrecioVenta.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupPrecioVenta.Location = new Point(456, 39);
            nupPrecioVenta.Margin = new Padding(11, 10, 11, 10);
            nupPrecioVenta.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupPrecioVenta.Name = "nupPrecioVenta";
            nupPrecioVenta.Size = new Size(144, 26);
            nupPrecioVenta.TabIndex = 11;
            // 
            // nupPrecioCosto
            // 
            nupPrecioCosto.BackColor = Color.FromArgb(1, 95, 168);
            nupPrecioCosto.DecimalPlaces = 2;
            nupPrecioCosto.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupPrecioCosto.Location = new Point(135, 39);
            nupPrecioCosto.Margin = new Padding(11, 10, 11, 10);
            nupPrecioCosto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupPrecioCosto.Name = "nupPrecioCosto";
            nupPrecioCosto.Size = new Size(144, 26);
            nupPrecioCosto.TabIndex = 10;
            // 
            // cboTamanio
            // 
            cboTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTamanio.FormattingEnabled = true;
            cboTamanio.ItemHeight = 19;
            cboTamanio.Location = new Point(137, 126);
            cboTamanio.Margin = new Padding(4);
            cboTamanio.Name = "cboTamanio";
            cboTamanio.Size = new Size(291, 27);
            cboTamanio.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(866, 498);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 14;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSabor
            // 
            txtSabor.BackColor = Color.FromArgb(0, 59, 103);
            txtSabor.BorderStyle = BorderStyle.None;
            txtSabor.Location = new Point(135, 171);
            txtSabor.Margin = new Padding(4);
            txtSabor.MaxLength = 50;
            txtSabor.Name = "txtSabor";
            txtSabor.PlaceholderText = "Sabor";
            txtSabor.Size = new Size(293, 20);
            txtSabor.TabIndex = 8;
            txtSabor.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label10.Location = new Point(729, 495);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 19);
            label10.TabIndex = 20;
            label10.Text = "Suspendido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label9.Location = new Point(336, 495);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(168, 19);
            label9.TabIndex = 19;
            label9.Text = "Nivel De Reposición:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label8.Location = new Point(107, 498);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 19);
            label8.TabIndex = 18;
            label8.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label7.Location = new Point(330, 41);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 17;
            label7.Text = "Precio Venta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label6.Location = new Point(9, 41);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 16;
            label6.Text = "Precio Costo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label4.Location = new Point(13, 126);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 15;
            label4.Text = "Tamaño:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 14;
            label3.Text = "Sabor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 13;
            label2.Text = "Marca: ";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1014, 43);
            label1.TabIndex = 12;
            label1.Text = "¡Nuevo Producto!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label5.Location = new Point(9, 24);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 13;
            label5.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(0, 59, 103);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(147, 24);
            txtNombre.Margin = new Padding(4);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(304, 20);
            txtNombre.TabIndex = 1;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label11.Location = new Point(9, 76);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 19);
            label11.TabIndex = 14;
            label11.Text = "Cod. Barra: ";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.BackColor = Color.FromArgb(0, 59, 103);
            txtCodigoBarras.BorderStyle = BorderStyle.None;
            txtCodigoBarras.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoBarras.Location = new Point(147, 76);
            txtCodigoBarras.Margin = new Padding(4);
            txtCodigoBarras.MaxLength = 13;
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.PlaceholderText = "0123456789";
            txtCodigoBarras.Size = new Size(304, 19);
            txtCodigoBarras.TabIndex = 2;
            txtCodigoBarras.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label12.Location = new Point(13, 76);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(89, 19);
            label12.TabIndex = 15;
            label12.Text = "Categoria:";
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(137, 76);
            cboCategorias.Margin = new Padding(4);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(291, 27);
            cboCategorias.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nupPrecioCosto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nupPrecioVenta);
            groupBox1.Location = new Point(193, 376);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(636, 90);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Precios";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboMarca);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cboCategorias);
            groupBox2.Controls.Add(cboTamanio);
            groupBox2.Location = new Point(540, 85);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(464, 171);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos ";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(133, 154);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 1);
            panel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(135, 199);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 1);
            panel3.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label13.Location = new Point(9, 126);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(105, 19);
            label13.TabIndex = 14;
            label13.Text = "Descripción ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(0, 59, 103);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Location = new Point(133, 126);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.MaxLength = 150;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(293, 20);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(39, 543);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(261, 218);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Imagen";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(41, 39);
            picImagen.Margin = new Padding(4);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(183, 156);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(1, 95, 168);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(39, 768);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(261, 54);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(panel4);
            groupBox4.Controls.Add(panel1);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(panel3);
            groupBox4.Controls.Add(txtNombre);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtCodigoBarras);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtSabor);
            groupBox4.Controls.Add(txtDescripcion);
            groupBox4.Location = new Point(30, 85);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(489, 215);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(147, 52);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 1);
            panel2.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(147, 101);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 1);
            panel1.TabIndex = 24;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProductosAE
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(1014, 830);
            Controls.Add(groupBox4);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(nupNivelReposicion);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nupStock);
            Controls.Add(checkBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmProductosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto";
            Load += frmPostresAE_Load;
            ((System.ComponentModel.ISupportInitialize)nupNivelReposicion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioCosto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMarca;
        private Button btnCancelar;
        private Button btnAceptar;
        private NumericUpDown nupNivelReposicion;
        private NumericUpDown nupStock;
        private NumericUpDown nupPrecioVenta;
        private NumericUpDown nupPrecioCosto;
        private ComboBox cboTamanio;
        private CheckBox checkBox1;
        private TextBox txtSabor;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtNombre;
        private Label label11;
        private TextBox txtCodigoBarras;
        private Label label12;
        private ComboBox cboCategorias;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private Button btnBuscar;
        private GroupBox groupBox4;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label13;
        private TextBox txtDescripcion;
        private OpenFileDialog openFileDialog1;
    }
}