namespace Kevin2024.Windows.Formularios
{
    partial class frmLogin
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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(1, 95, 168);
            label1.Location = new Point(89, 59);
            label1.Name = "label1";
            label1.Size = new Size(237, 44);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(1, 95, 168);
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.WindowText;
            txtUsuario.Location = new Point(32, 143);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.MaxLength = 200;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(351, 29);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(1, 95, 168);
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(89, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(252, 29);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(1, 95, 168);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(33, 266);
            btnOK.MaximumSize = new Size(350, 36);
            btnOK.MinimumSize = new Size(350, 36);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(350, 36);
            btnOK.TabIndex = 3;
            btnOK.Text = "Login";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(1, 95, 168);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(32, 317);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.MaximumSize = new Size(350, 36);
            btnCancelar.MinimumSize = new Size(350, 36);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(350, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(409, 421);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            MaximumSize = new Size(425, 460);
            MinimumSize = new Size(425, 460);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}