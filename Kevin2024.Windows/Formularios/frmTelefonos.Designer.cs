namespace Kevin2024.Windows.Formularios
{
    partial class frmTelefonos
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
            panel1 = new Panel();
            txtNumero = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtTipo = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 2;
            label2.Text = "Tipo Télefono:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(99, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 1);
            panel1.TabIndex = 28;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(0, 59, 103);
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(99, 90);
            txtNumero.MaxLength = 45;
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(224, 16);
            txtNumero.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(202, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 46);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(26, 144);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(154, 46);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(0, 59, 103);
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.ForeColor = Color.White;
            txtTipo.Location = new Point(139, 42);
            txtTipo.MaxLength = 45;
            txtTipo.Name = "txtTipo";
            txtTipo.PlaceholderText = "Tipo Télefono";
            txtTipo.Size = new Size(184, 16);
            txtTipo.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(139, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 1);
            panel2.TabIndex = 28;
            // 
            // frmTelefonos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(360, 202);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtTipo);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTelefonos";
            Text = "frmTelefonos";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtNumero;
        private Button btnCancelar;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
        private Panel panel2;
        private TextBox txtTipo;
    }
}