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
            dtFechaNac = new DateTimePicker();
            dtFechaContrato = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nupSalario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(254, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 54);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(27, 383);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(193, 54);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // nupSalario
            // 
            nupSalario.DecimalPlaces = 2;
            nupSalario.Location = new Point(120, 285);
            nupSalario.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupSalario.Name = "nupSalario";
            nupSalario.Size = new Size(100, 23);
            nupSalario.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(144, 334);
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
            txtApellido.Location = new Point(119, 120);
            txtApellido.MaxLength = 13;
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
            txtNombre.Location = new Point(119, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(224, 16);
            txtNombre.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F);
            label5.Location = new Point(43, 120);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 16;
            label5.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F);
            label3.Location = new Point(43, 75);
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
            label1.Size = new Size(429, 41);
            label1.TabIndex = 14;
            label1.Text = "¡Empleados!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F);
            label2.Location = new Point(44, 330);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 18;
            label2.Text = "Suspendido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F);
            label4.Location = new Point(43, 167);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 18;
            label4.Text = "Num. Dni:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F);
            label7.Location = new Point(43, 206);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 18;
            label7.Text = "Fecha Nac.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F);
            label8.Location = new Point(44, 285);
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
            txtDni.Location = new Point(135, 163);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Dni";
            txtDni.Size = new Size(212, 16);
            txtDni.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F);
            label9.Location = new Point(43, 242);
            label9.Name = "label9";
            label9.Size = new Size(120, 19);
            label9.TabIndex = 18;
            label9.Text = "Fecha Contrato:";
            // 
            // dtFechaNac
            // 
            dtFechaNac.Location = new Point(147, 202);
            dtFechaNac.MinDate = new DateTime(1779, 1, 1, 0, 0, 0, 0);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(234, 23);
            dtFechaNac.TabIndex = 4;
            // 
            // dtFechaContrato
            // 
            dtFechaContrato.Location = new Point(169, 238);
            dtFechaContrato.Name = "dtFechaContrato";
            dtFechaContrato.Size = new Size(212, 23);
            dtFechaContrato.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(119, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 1);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(120, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 1);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(135, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 1);
            panel3.TabIndex = 26;
            // 
            // frmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(429, 466);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dtFechaContrato);
            Controls.Add(dtFechaNac);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nupSalario);
            Controls.Add(checkBox1);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmEmpleadosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpleadosAE";
            Load += frmEmpleadosAE_Load;
            ((System.ComponentModel.ISupportInitialize)nupSalario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private DateTimePicker dtFechaNac;
        private DateTimePicker dtFechaContrato;
        private ErrorProvider errorProvider1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}