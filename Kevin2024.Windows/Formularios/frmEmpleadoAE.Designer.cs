namespace Kevin2024.Windows.Formularios
{
    partial class frmEmpleadoAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadoAE));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCancelar = new Button();
            btnBuscar = new Button();
            btnAceptar = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            dtFechaNac = new DateTimePicker();
            cboGeneros = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            dtFechaContrato = new DateTimePicker();
            nupSalario = new NumericUpDown();
            checkBox1 = new CheckBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgvDatosDirecciones = new DataGridView();
            ColDireccionId = new DataGridViewTextBoxColumn();
            ColDIreccion = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnBorrarT = new Button();
            btnAgregarT = new Button();
            btnEditarT = new Button();
            dgvTelefonos = new DataGridView();
            ColTelefonoId = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupSalario).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosDirecciones).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTelefonos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 478);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 59, 103);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(btnAceptar);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(dtFechaNac);
            tabPage1.Controls.Add(cboGeneros);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dtFechaContrato);
            tabPage1.Controls.Add(nupSalario);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(txtDni);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Empleado";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(415, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(237, 54);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(1, 95, 168);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(462, 279);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(261, 54);
            btnBuscar.TabIndex = 49;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(96, 390);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(285, 54);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(462, 53);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(261, 218);
            groupBox3.TabIndex = 48;
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
            // dtFechaNac
            // 
            dtFechaNac.Location = new Point(155, 155);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(212, 23);
            dtFechaNac.TabIndex = 47;
            // 
            // cboGeneros
            // 
            cboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGeneros.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGeneros.FormattingEnabled = true;
            cboGeneros.Location = new Point(96, 290);
            cboGeneros.Name = "cboGeneros";
            cboGeneros.Size = new Size(188, 27);
            cboGeneros.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(121, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 1);
            panel3.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(106, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 1);
            panel2.TabIndex = 43;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(105, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 1);
            panel1.TabIndex = 45;
            // 
            // dtFechaContrato
            // 
            dtFechaContrato.Location = new Point(155, 203);
            dtFechaContrato.Name = "dtFechaContrato";
            dtFechaContrato.Size = new Size(212, 23);
            dtFechaContrato.TabIndex = 32;
            // 
            // nupSalario
            // 
            nupSalario.DecimalPlaces = 2;
            nupSalario.Location = new Point(106, 248);
            nupSalario.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupSalario.Name = "nupSalario";
            nupSalario.Size = new Size(100, 23);
            nupSalario.TabIndex = 33;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(130, 342);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 34;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(0, 59, 103);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(121, 113);
            txtDni.MaxLength = 10;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Dni";
            txtDni.Size = new Size(212, 16);
            txtDni.TabIndex = 31;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(0, 59, 103);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(105, 68);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(224, 16);
            txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(0, 59, 103);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(105, 23);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(224, 16);
            txtNombre.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F);
            label2.Location = new Point(30, 338);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 38;
            label2.Text = "Suspendido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F);
            label4.Location = new Point(29, 113);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 39;
            label4.Text = "Num. Dni:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F);
            label9.Location = new Point(29, 203);
            label9.Name = "label9";
            label9.Size = new Size(120, 19);
            label9.TabIndex = 40;
            label9.Text = "Fecha Contrato:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F);
            label7.Location = new Point(29, 158);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 41;
            label7.Text = "Fecha Nac.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F);
            label8.Location = new Point(30, 248);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 42;
            label8.Text = "Salario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F);
            label6.Location = new Point(30, 293);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 35;
            label6.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F);
            label5.Location = new Point(30, 68);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 36;
            label5.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F);
            label3.Location = new Point(29, 23);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 37;
            label3.Text = "Nombre:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 59, 103);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dgvDatosDirecciones);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Direcciones";
            // 
            // button3
            // 
            button3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            button3.Image = Properties.Resources.borrar;
            button3.Location = new Point(240, 318);
            button3.Name = "button3";
            button3.Size = new Size(94, 43);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            button2.Image = Properties.Resources.boton_agregar_a_la_cola;
            button2.Location = new Point(20, 318);
            button2.Name = "button2";
            button2.Size = new Size(94, 43);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            button1.Image = Properties.Resources.boton_subrayado;
            button1.Location = new Point(130, 318);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvDatosDirecciones
            // 
            dgvDatosDirecciones.AllowUserToAddRows = false;
            dgvDatosDirecciones.AllowUserToDeleteRows = false;
            dgvDatosDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosDirecciones.Columns.AddRange(new DataGridViewColumn[] { ColDireccionId, ColDIreccion });
            dgvDatosDirecciones.Dock = DockStyle.Top;
            dgvDatosDirecciones.Location = new Point(3, 3);
            dgvDatosDirecciones.Name = "dgvDatosDirecciones";
            dgvDatosDirecciones.ReadOnly = true;
            dgvDatosDirecciones.RowHeadersVisible = false;
            dgvDatosDirecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosDirecciones.Size = new Size(762, 299);
            dgvDatosDirecciones.TabIndex = 0;
            // 
            // ColDireccionId
            // 
            ColDireccionId.HeaderText = "DIreccionId";
            ColDireccionId.Name = "ColDireccionId";
            ColDireccionId.ReadOnly = true;
            ColDireccionId.Visible = false;
            // 
            // ColDIreccion
            // 
            ColDIreccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDIreccion.HeaderText = "Dirección";
            ColDIreccion.Name = "ColDIreccion";
            ColDIreccion.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(0, 59, 103);
            tabPage3.Controls.Add(btnBorrarT);
            tabPage3.Controls.Add(btnAgregarT);
            tabPage3.Controls.Add(btnEditarT);
            tabPage3.Controls.Add(dgvTelefonos);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 450);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Télefonos";
            // 
            // btnBorrarT
            // 
            btnBorrarT.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnBorrarT.Image = Properties.Resources.borrar;
            btnBorrarT.Location = new Point(240, 319);
            btnBorrarT.Name = "btnBorrarT";
            btnBorrarT.Size = new Size(94, 43);
            btnBorrarT.TabIndex = 2;
            btnBorrarT.UseVisualStyleBackColor = true;
            // 
            // btnAgregarT
            // 
            btnAgregarT.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAgregarT.Image = Properties.Resources.boton_agregar_a_la_cola;
            btnAgregarT.Location = new Point(20, 318);
            btnAgregarT.Name = "btnAgregarT";
            btnAgregarT.Size = new Size(94, 43);
            btnAgregarT.TabIndex = 3;
            btnAgregarT.UseVisualStyleBackColor = true;
            btnAgregarT.Click += btnAgregarT_Click;
            // 
            // btnEditarT
            // 
            btnEditarT.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnEditarT.Image = Properties.Resources.boton_subrayado;
            btnEditarT.Location = new Point(130, 318);
            btnEditarT.Name = "btnEditarT";
            btnEditarT.Size = new Size(94, 43);
            btnEditarT.TabIndex = 4;
            btnEditarT.UseVisualStyleBackColor = true;
            // 
            // dgvTelefonos
            // 
            dgvTelefonos.AllowUserToAddRows = false;
            dgvTelefonos.AllowUserToDeleteRows = false;
            dgvTelefonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefonos.Columns.AddRange(new DataGridViewColumn[] { ColTelefonoId, ColTelefono });
            dgvTelefonos.Dock = DockStyle.Top;
            dgvTelefonos.Location = new Point(3, 3);
            dgvTelefonos.Name = "dgvTelefonos";
            dgvTelefonos.ReadOnly = true;
            dgvTelefonos.RowHeadersVisible = false;
            dgvTelefonos.Size = new Size(762, 299);
            dgvTelefonos.TabIndex = 0;
            // 
            // ColTelefonoId
            // 
            ColTelefonoId.HeaderText = "TelefonoId";
            ColTelefonoId.Name = "ColTelefonoId";
            ColTelefonoId.ReadOnly = true;
            ColTelefonoId.Visible = false;
            // 
            // ColTelefono
            // 
            ColTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTelefono.HeaderText = "Teléfono";
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEmpleadoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(800, 526);
            Controls.Add(tabControl1);
            Name = "frmEmpleadoAE";
            Text = "frmEmpleadoAE";
            Load += frmEmpleadosAE_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupSalario).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatosDirecciones).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTelefonos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dtFechaNac;
        private ComboBox cboGeneros;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DateTimePicker dtFechaContrato;
        private NumericUpDown nupSalario;
        private CheckBox checkBox1;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private Label label4;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label3;
        private TabPage tabPage3;
        private Button btnBuscar;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private DataGridView dgvDatosDirecciones;
        private DataGridViewTextBoxColumn ColDireccionId;
        private DataGridViewTextBoxColumn ColDIreccion;
        private Button btnCancelar;
        private Button btnAceptar;
        private DataGridView dgvTelefonos;
        private DataGridViewTextBoxColumn ColTelefonoId;
        private DataGridViewTextBoxColumn ColTelefono;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnBorrarT;
        private Button btnAgregarT;
        private Button btnEditarT;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}