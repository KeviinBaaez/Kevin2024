namespace Kevin2024.Windows.Formularios
{
    partial class frmUsuarios
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
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            cboRoles = new ComboBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            picImagen = new PictureBox();
            btnBuscarImg = new Button();
            txtRepitContraseña = new TextBox();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnUsuarios = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 103);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cboRoles);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtRepitContraseña);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 367);
            panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(80, 261);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 95, 168);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.ojo_cruzado;
            button1.Location = new Point(392, 89);
            button1.Name = "button1";
            button1.Size = new Size(34, 20);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cboRoles
            // 
            cboRoles.BackColor = SystemColors.Window;
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoles.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboRoles.FormattingEnabled = true;
            cboRoles.Location = new Point(147, 200);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(159, 27);
            cboRoles.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(355, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(194, 51);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(114, 304);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(220, 51);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Registrar usuario";
            btnAceptar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picImagen);
            groupBox1.Controls.Add(btnBuscarImg);
            groupBox1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(439, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 193);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen:";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(23, 26);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(177, 127);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnBuscarImg
            // 
            btnBuscarImg.BackColor = Color.FromArgb(1, 95, 168);
            btnBuscarImg.FlatStyle = FlatStyle.Popup;
            btnBuscarImg.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarImg.Location = new Point(23, 159);
            btnBuscarImg.Name = "btnBuscarImg";
            btnBuscarImg.Size = new Size(177, 28);
            btnBuscarImg.TabIndex = 6;
            btnBuscarImg.Text = "Buscar";
            btnBuscarImg.UseVisualStyleBackColor = false;
            btnBuscarImg.Click += btnBuscarImg_Click;
            // 
            // txtRepitContraseña
            // 
            txtRepitContraseña.BackColor = Color.FromArgb(0, 59, 103);
            txtRepitContraseña.BorderStyle = BorderStyle.None;
            txtRepitContraseña.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepitContraseña.Location = new Point(175, 142);
            txtRepitContraseña.Name = "txtRepitContraseña";
            txtRepitContraseña.Size = new Size(211, 20);
            txtRepitContraseña.TabIndex = 3;
            txtRepitContraseña.UseSystemPasswordChar = true;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(0, 59, 103);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(175, 85);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(211, 20);
            txtContraseña.TabIndex = 2;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(0, 59, 103);
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(175, 35);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(211, 20);
            txtNombreUsuario.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(175, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 1);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(175, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 1);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(175, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 1);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 90);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 0;
            label5.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 0;
            label3.Text = "Repita contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 0;
            label4.Text = "Asigna un rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 0;
            label2.Text = "Activo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(0, 59, 103);
            btnUsuarios.Dock = DockStyle.Right;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(668, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(151, 367);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "Todos los usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 367);
            Controls.Add(btnUsuarios);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNombreUsuario;
        private Panel panel2;
        private TextBox txtRepitContraseña;
        private TextBox txtContraseña;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private PictureBox picImagen;
        private Button btnBuscarImg;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboRoles;
        private Label label4;
        private Button btnUsuarios;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox1;
        private Label label5;
    }
}