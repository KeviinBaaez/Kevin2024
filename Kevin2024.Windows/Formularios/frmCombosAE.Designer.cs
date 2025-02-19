namespace Kevin2024.Windows.Formularios
{
    partial class frmCombosAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombosAE));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            nupPrecioCosto = new NumericUpDown();
            label7 = new Label();
            nupPrecioVenta = new NumericUpDown();
            panel4 = new Panel();
            label13 = new Label();
            txtDescripcion = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            txtNombre = new TextBox();
            panel3 = new Panel();
            cboTamanio = new ComboBox();
            nupNivelReposicion = new NumericUpDown();
            nupStock = new NumericUpDown();
            checkBox1 = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            btnCancelar = new Button();
            panel6 = new Panel();
            btnBuscar = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            btnAceptar = new Button();
            panel7 = new Panel();
            btnBorrar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            panel8 = new Panel();
            dgvDatos = new DataGridView();
            ColProductoId = new DataGridViewTextBoxColumn();
            ColProducto = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColTamaño = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrecioCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupNivelReposicion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 115);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nupPrecioCosto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nupPrecioVenta);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(602, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(378, 115);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Precios";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label6.Location = new Point(52, 27);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 16;
            label6.Text = "Precio Costo:";
            // 
            // nupPrecioCosto
            // 
            nupPrecioCosto.BackColor = Color.FromArgb(1, 95, 168);
            nupPrecioCosto.DecimalPlaces = 2;
            nupPrecioCosto.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupPrecioCosto.Location = new Point(177, 24);
            nupPrecioCosto.Margin = new Padding(11, 10, 11, 10);
            nupPrecioCosto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupPrecioCosto.Name = "nupPrecioCosto";
            nupPrecioCosto.Size = new Size(144, 26);
            nupPrecioCosto.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label7.Location = new Point(52, 71);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 17;
            label7.Text = "Precio Venta:";
            // 
            // nupPrecioVenta
            // 
            nupPrecioVenta.BackColor = Color.FromArgb(1, 95, 168);
            nupPrecioVenta.DecimalPlaces = 2;
            nupPrecioVenta.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupPrecioVenta.Location = new Point(177, 68);
            nupPrecioVenta.Margin = new Padding(11, 10, 11, 10);
            nupPrecioVenta.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupPrecioVenta.Name = "nupPrecioVenta";
            nupPrecioVenta.Size = new Size(144, 26);
            nupPrecioVenta.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(137, 89);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(410, 1);
            panel4.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label13.Location = new Point(13, 61);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(105, 19);
            label13.TabIndex = 29;
            label13.Text = "Descripción ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(0, 59, 103);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Location = new Point(137, 61);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.MaxLength = 150;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(410, 16);
            txtDescripcion.TabIndex = 28;
            txtDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(137, 27);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 1);
            panel2.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label5.Location = new Point(13, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 26;
            label5.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(0, 59, 103);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(137, 4);
            txtNombre.Margin = new Padding(4);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(290, 16);
            txtNombre.TabIndex = 25;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(cboTamanio);
            panel3.Controls.Add(nupNivelReposicion);
            panel3.Controls.Add(nupStock);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 50);
            panel3.TabIndex = 1;
            // 
            // cboTamanio
            // 
            cboTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTamanio.FormattingEnabled = true;
            cboTamanio.ItemHeight = 15;
            cboTamanio.Location = new Point(97, 15);
            cboTamanio.Margin = new Padding(4);
            cboTamanio.Name = "cboTamanio";
            cboTamanio.Size = new Size(141, 23);
            cboTamanio.TabIndex = 27;
            // 
            // nupNivelReposicion
            // 
            nupNivelReposicion.BackColor = Color.FromArgb(1, 95, 168);
            nupNivelReposicion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupNivelReposicion.Location = new Point(669, 13);
            nupNivelReposicion.Margin = new Padding(19, 16, 19, 16);
            nupNivelReposicion.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupNivelReposicion.Name = "nupNivelReposicion";
            nupNivelReposicion.Size = new Size(138, 26);
            nupNivelReposicion.TabIndex = 22;
            // 
            // nupStock
            // 
            nupStock.BackColor = Color.FromArgb(1, 95, 168);
            nupStock.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupStock.Location = new Point(352, 13);
            nupStock.Margin = new Padding(11, 10, 11, 10);
            nupStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupStock.Name = "nupStock";
            nupStock.Size = new Size(111, 26);
            nupStock.TabIndex = 21;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(960, 19);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 23;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label10.Location = new Point(854, 16);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 19);
            label10.TabIndex = 26;
            label10.Text = "Suspendido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label9.Location = new Point(478, 16);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(168, 19);
            label9.TabIndex = 25;
            label9.Text = "Nivel De Reposición:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.Location = new Point(13, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 24;
            label1.Text = "Tamaño:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label8.Location = new Point(281, 16);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 19);
            label8.TabIndex = 24;
            label8.Text = "Stock:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCancelar);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnAceptar);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(780, 165);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 452);
            panel5.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(20, 389);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(167, 50);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnBuscar);
            panel6.Controls.Add(groupBox3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 216);
            panel6.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(1, 95, 168);
            btnBuscar.Dock = DockStyle.Bottom;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(0, 176);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 40);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(200, 173);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Imagen";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(8, 24);
            picImagen.Margin = new Padding(4);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(184, 138);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(7, 320);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(185, 51);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnBorrar);
            panel7.Controls.Add(btnEditar);
            panel7.Controls.Add(btnAgregar);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 165);
            panel7.Name = "panel7";
            panel7.Size = new Size(145, 452);
            panel7.TabIndex = 3;
            // 
            // btnBorrar
            // 
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.Image = Properties.Resources.borrar;
            btnBorrar.Location = new Point(19, 287);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 45);
            btnBorrar.TabIndex = 0;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.boton_subrayado;
            btnEditar.Location = new Point(19, 202);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 45);
            btnEditar.TabIndex = 0;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Image = Properties.Resources.boton_agregar_a_la_cola;
            btnAgregar.Location = new Point(19, 117);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 45);
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvDatos);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(145, 165);
            panel8.Name = "panel8";
            panel8.Size = new Size(635, 452);
            panel8.TabIndex = 4;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColProductoId, ColProducto, ColCantidad, ColTamaño });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(635, 452);
            dgvDatos.TabIndex = 0;
            // 
            // ColProductoId
            // 
            ColProductoId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColProductoId.HeaderText = "ProductoId";
            ColProductoId.Name = "ColProductoId";
            ColProductoId.ReadOnly = true;
            ColProductoId.Visible = false;
            // 
            // ColProducto
            // 
            ColProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColProducto.HeaderText = "Producto";
            ColProducto.Name = "ColProducto";
            ColProducto.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColTamaño
            // 
            ColTamaño.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTamaño.HeaderText = "Tamaño";
            ColTamaño.Name = "ColTamaño";
            ColTamaño.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCombosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(980, 617);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "frmCombosAE";
            Text = "frmCombosAE";
            Load += frmCombosAE_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrecioCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupNivelReposicion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private TextBox txtNombre;
        private Panel panel4;
        private Label label13;
        private TextBox txtDescripcion;
        private GroupBox groupBox1;
        private Label label6;
        private NumericUpDown nupPrecioCosto;
        private Label label7;
        private NumericUpDown nupPrecioVenta;
        private Panel panel3;
        private NumericUpDown nupNivelReposicion;
        private NumericUpDown nupStock;
        private CheckBox checkBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel5;
        private Panel panel6;
        private Button btnBuscar;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dgvDatos;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label1;
        private ComboBox cboTamanio;
        private DataGridViewTextBoxColumn ColProductoId;
        private DataGridViewTextBoxColumn ColProducto;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColTamaño;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}