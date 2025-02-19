namespace Kevin2024.Windows.Formularios
{
    partial class frmEmpleadosAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosAE));
            btnCancelar = new Button();
            btnAceptar = new Button();
            nupSalario = new NumericUpDown();
            checkBox1 = new CheckBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDni = new TextBox();
            label9 = new Label();
            dtFechaContrato = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            cboGeneros = new ComboBox();
            dtFechaNac = new DateTimePicker();
            btnBuscar = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            label10 = new Label();
            label11 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nupSalario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(474, 463);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(237, 54);
            btnCancelar.TabIndex = 12;
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
            btnAceptar.Location = new Point(155, 463);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(285, 54);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // nupSalario
            // 
            nupSalario.DecimalPlaces = 2;
            nupSalario.Location = new Point(140, 295);
            nupSalario.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupSalario.Name = "nupSalario";
            nupSalario.Size = new Size(100, 23);
            nupSalario.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(164, 389);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(0, 59, 103);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(139, 115);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(224, 16);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(0, 59, 103);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(139, 70);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(224, 16);
            txtNombre.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F);
            label5.Location = new Point(64, 115);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 16;
            label5.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F);
            label3.Location = new Point(63, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 17;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Constantia", 17.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(831, 41);
            label1.TabIndex = 14;
            label1.Text = "¡Empleados!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F);
            label2.Location = new Point(64, 385);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 18;
            label2.Text = "Suspendido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F);
            label4.Location = new Point(63, 160);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 18;
            label4.Text = "Num. Dni:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F);
            label7.Location = new Point(63, 205);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 18;
            label7.Text = "Fecha Nac.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F);
            label8.Location = new Point(64, 295);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 18;
            label8.Text = "Salario:";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(0, 59, 103);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(155, 160);
            txtDni.MaxLength = 10;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Dni";
            txtDni.Size = new Size(212, 16);
            txtDni.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F);
            label9.Location = new Point(63, 250);
            label9.Name = "label9";
            label9.Size = new Size(120, 19);
            label9.TabIndex = 18;
            label9.Text = "Fecha Contrato:";
            // 
            // dtFechaContrato
            // 
            dtFechaContrato.Location = new Point(189, 250);
            dtFechaContrato.Name = "dtFechaContrato";
            dtFechaContrato.Size = new Size(212, 23);
            dtFechaContrato.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(139, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 1);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(140, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 1);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(155, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 1);
            panel3.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F);
            label6.Location = new Point(64, 340);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 16;
            label6.Text = "Sexo:";
            // 
            // cboGeneros
            // 
            cboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGeneros.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGeneros.FormattingEnabled = true;
            cboGeneros.Location = new Point(139, 337);
            cboGeneros.Name = "cboGeneros";
            cboGeneros.Size = new Size(188, 27);
            cboGeneros.TabIndex = 9;
            // 
            // dtFechaNac
            // 
            dtFechaNac.Location = new Point(189, 205);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(212, 23);
            dtFechaNac.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(1, 95, 168);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.Location = new Point(501, 384);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(254, 45);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(501, 158);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(254, 209);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Imagen";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(37, 24);
            picImagen.Margin = new Padding(4);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(183, 166);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F);
            label10.Location = new Point(474, 70);
            label10.Name = "label10";
            label10.Size = new Size(75, 19);
            label10.TabIndex = 17;
            label10.Text = "Télefono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F);
            label11.Location = new Point(475, 115);
            label11.Name = "label11";
            label11.Size = new Size(81, 19);
            label11.TabIndex = 16;
            label11.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(0, 59, 103);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(550, 70);
            txtTelefono.MaxLength = 50;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Télefono";
            txtTelefono.Size = new Size(224, 16);
            txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(0, 59, 103);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(551, 117);
            txtDireccion.MaxLength = 50;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(224, 16);
            txtDireccion.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(550, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 1);
            panel4.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(551, 139);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 1);
            panel5.TabIndex = 26;
            // 
            // frmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(831, 537);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox3);
            Controls.Add(dtFechaNac);
            Controls.Add(cboGeneros);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(dtFechaContrato);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nupSalario);
            Controls.Add(checkBox1);
            Controls.Add(txtDni);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmEmpleadosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpleadosAE";
            Load += frmEmpleadosAE_Load;
            ((System.ComponentModel.ISupportInitialize)nupSalario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private NumericUpDown nupSalario;
        private CheckBox checkBox1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtDni;
        private Label label9;
        private DateTimePicker dtFechaContrato;
        private ErrorProvider errorProvider1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private ComboBox cboGeneros;
        private DateTimePicker dtFechaNac;
        private Button btnBuscar;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private OpenFileDialog openFileDialog1;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label11;
        private Label label10;
    }
}