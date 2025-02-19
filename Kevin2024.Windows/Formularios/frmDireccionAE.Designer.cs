namespace Kevin2024.Windows.Formularios
{
    partial class frmDireccionAE
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
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            txtAltura = new TextBox();
            txtEntre2 = new TextBox();
            txtEntre1 = new TextBox();
            txtCalle = new TextBox();
            txtDepto = new TextBox();
            txtPiso = new TextBox();
            cboTipoDireccion = new ComboBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label11.Location = new Point(298, 171);
            label11.Name = "label11";
            label11.Size = new Size(62, 19);
            label11.TabIndex = 68;
            label11.Text = "Depto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label10.Location = new Point(34, 171);
            label10.Name = "label10";
            label10.Size = new Size(46, 19);
            label10.TabIndex = 67;
            label10.Text = "Piso:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label7.Location = new Point(565, 62);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 71;
            label7.Text = "Altura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label9.Location = new Point(34, 120);
            label9.Name = "label9";
            label9.Size = new Size(23, 19);
            label9.TabIndex = 70;
            label9.Text = "Y:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label8.Location = new Point(34, 91);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 69;
            label8.Text = "Entre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label4.Location = new Point(34, 62);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 72;
            label4.Text = "Calle:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(633, 62);
            txtAltura.MaxLength = 50;
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(144, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtEntre2
            // 
            txtEntre2.Location = new Point(168, 120);
            txtEntre2.MaxLength = 50;
            txtEntre2.Name = "txtEntre2";
            txtEntre2.Size = new Size(383, 23);
            txtEntre2.TabIndex = 4;
            // 
            // txtEntre1
            // 
            txtEntre1.Location = new Point(168, 91);
            txtEntre1.MaxLength = 50;
            txtEntre1.Name = "txtEntre1";
            txtEntre1.Size = new Size(383, 23);
            txtEntre1.TabIndex = 3;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(168, 58);
            txtCalle.MaxLength = 50;
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(383, 23);
            txtCalle.TabIndex = 1;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(366, 171);
            txtDepto.MaxLength = 50;
            txtDepto.Name = "txtDepto";
            txtDepto.Size = new Size(129, 23);
            txtDepto.TabIndex = 6;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(111, 171);
            txtPiso.MaxLength = 50;
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(129, 23);
            txtPiso.TabIndex = 5;
            // 
            // cboTipoDireccion
            // 
            cboTipoDireccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDireccion.FormattingEnabled = true;
            cboTipoDireccion.Location = new Point(168, 22);
            cboTipoDireccion.Name = "cboTipoDireccion";
            cboTipoDireccion.Size = new Size(315, 23);
            cboTipoDireccion.TabIndex = 8;
            cboTipoDireccion.SelectedIndexChanged += cboTipoDireccion_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.Location = new Point(34, 22);
            label3.Name = "label3";
            label3.Size = new Size(128, 19);
            label3.TabIndex = 64;
            label3.Text = "Tipo Dirección:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(434, 269);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 56);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(224, 269);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(172, 56);
            btnAceptar.TabIndex = 7;
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
            // frmDireccionAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 95, 168);
            ClientSize = new Size(800, 340);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtAltura);
            Controls.Add(txtEntre2);
            Controls.Add(txtEntre1);
            Controls.Add(txtCalle);
            Controls.Add(txtDepto);
            Controls.Add(txtPiso);
            Controls.Add(cboTipoDireccion);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDireccionAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDireccionAE";
            Load += frmDireccionAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label10;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label4;
        private TextBox txtAltura;
        private TextBox txtEntre2;
        private TextBox txtEntre1;
        private TextBox txtCalle;
        private TextBox txtDepto;
        private TextBox txtPiso;
        private ComboBox cboTipoDireccion;
        private Label label3;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        public Button btnAceptar;
    }
}