namespace Kevin2024.Windows.Formularios
{
    partial class frmNuevoTipoAE
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
            txtMarca = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelMarcas = new Panel();
            panelTipoDireccion = new Panel();
            panel13 = new Panel();
            label11 = new Label();
            txtDireccion = new TextBox();
            panel14 = new Panel();
            panelTipotelefono = new Panel();
            panel11 = new Panel();
            label9 = new Label();
            txtTelefono = new TextBox();
            panel12 = new Panel();
            label10 = new Label();
            label12 = new Label();
            panelTamanios = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            txtTamanio = new TextBox();
            label4 = new Label();
            panelCategorias = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            txtCategoria = new TextBox();
            label6 = new Label();
            panelGeneros = new Panel();
            panel9 = new Panel();
            label7 = new Label();
            txtGenero = new TextBox();
            panel10 = new Panel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelMarcas.SuspendLayout();
            panelTipoDireccion.SuspendLayout();
            panel13.SuspendLayout();
            panelTipotelefono.SuspendLayout();
            panel11.SuspendLayout();
            panelTamanios.SuspendLayout();
            panel5.SuspendLayout();
            panelCategorias.SuspendLayout();
            panel7.SuspendLayout();
            panelGeneros.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre Marca:";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 39);
            label2.TabIndex = 1;
            label2.Text = "¡Nueva Marca!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.None;
            txtMarca.BackColor = Color.FromArgb(0, 59, 103);
            txtMarca.BorderStyle = BorderStyle.None;
            txtMarca.Font = new Font("Constantia", 12F, FontStyle.Bold);
            txtMarca.ForeColor = Color.White;
            txtMarca.Location = new Point(151, 31);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(175, 20);
            txtMarca.TabIndex = 1;
            txtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.None;
            btnOK.BackColor = Color.FromArgb(68, 182, 120);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnOK.Image = Properties.Resources.caja;
            btnOK.Location = new Point(25, 6);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(159, 47);
            btnOK.TabIndex = 2;
            btnOK.Text = "Aceptar";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(207, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 49);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(151, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnOK);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 60);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtMarca);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 84);
            panel3.TabIndex = 6;
            // 
            // panelMarcas
            // 
            panelMarcas.Controls.Add(panel3);
            panelMarcas.Controls.Add(label2);
            panelMarcas.Location = new Point(0, 0);
            panelMarcas.Name = "panelMarcas";
            panelMarcas.Size = new Size(357, 123);
            panelMarcas.TabIndex = 7;
            // 
            // panelTipoDireccion
            // 
            panelTipoDireccion.Controls.Add(panel13);
            panelTipoDireccion.Controls.Add(label12);
            panelTipoDireccion.Location = new Point(0, 0);
            panelTipoDireccion.Name = "panelTipoDireccion";
            panelTipoDireccion.Size = new Size(357, 123);
            panelTipoDireccion.TabIndex = 10;
            // 
            // panel13
            // 
            panel13.Controls.Add(label11);
            panel13.Controls.Add(txtDireccion);
            panel13.Controls.Add(panel14);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 39);
            panel13.Name = "panel13";
            panel13.Size = new Size(357, 84);
            panel13.TabIndex = 6;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(34, 26);
            label11.Name = "label11";
            label11.Size = new Size(106, 19);
            label11.TabIndex = 0;
            label11.Text = "Descripcion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.BackColor = Color.FromArgb(0, 59, 103);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Constantia", 12F, FontStyle.Bold);
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(152, 24);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Tipo dirección";
            txtDireccion.Size = new Size(175, 20);
            txtDireccion.TabIndex = 1;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.None;
            panel14.BackColor = Color.Black;
            panel14.Location = new Point(152, 45);
            panel14.Name = "panel14";
            panel14.Size = new Size(175, 1);
            panel14.TabIndex = 4;
            // 
            // panelTipotelefono
            // 
            panelTipotelefono.Controls.Add(panel11);
            panelTipotelefono.Controls.Add(label10);
            panelTipotelefono.Location = new Point(0, 0);
            panelTipotelefono.Name = "panelTipotelefono";
            panelTipotelefono.Size = new Size(356, 123);
            panelTipotelefono.TabIndex = 9;
            // 
            // panel11
            // 
            panel11.Controls.Add(label9);
            panel11.Controls.Add(txtTelefono);
            panel11.Controls.Add(panel12);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 39);
            panel11.Name = "panel11";
            panel11.Size = new Size(356, 84);
            panel11.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(16, 29);
            label9.Name = "label9";
            label9.Size = new Size(106, 19);
            label9.TabIndex = 0;
            label9.Text = "Descripcion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.BackColor = Color.FromArgb(0, 59, 103);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Constantia", 12F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(134, 27);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Tipo teléfono";
            txtTelefono.Size = new Size(175, 20);
            txtTelefono.TabIndex = 1;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.Black;
            panel12.Location = new Point(134, 48);
            panel12.Name = "panel12";
            panel12.Size = new Size(175, 1);
            panel12.TabIndex = 4;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(356, 39);
            label10.TabIndex = 1;
            label10.Text = "¡Nuevo Tipo Teléfono!";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(357, 39);
            label12.TabIndex = 1;
            label12.Text = "¡Nuevo Tipo Dirección!";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTamanios
            // 
            panelTamanios.Controls.Add(panel5);
            panelTamanios.Controls.Add(label4);
            panelTamanios.Location = new Point(0, 0);
            panelTamanios.Name = "panelTamanios";
            panelTamanios.Size = new Size(357, 123);
            panelTamanios.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtTamanio);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(357, 94);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(75, 59);
            panel6.Name = "panel6";
            panel6.Size = new Size(223, 1);
            panel6.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 39);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 5;
            label3.Text = "Tamaño:";
            // 
            // txtTamanio
            // 
            txtTamanio.BackColor = Color.FromArgb(0, 59, 103);
            txtTamanio.BorderStyle = BorderStyle.None;
            txtTamanio.Font = new Font("Constantia", 12F, FontStyle.Bold);
            txtTamanio.ForeColor = Color.White;
            txtTamanio.Location = new Point(75, 38);
            txtTamanio.Name = "txtTamanio";
            txtTamanio.PlaceholderText = "Tamaño";
            txtTamanio.Size = new Size(223, 20);
            txtTamanio.TabIndex = 1;
            txtTamanio.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(357, 29);
            label4.TabIndex = 11;
            label4.Text = "¡Nuevo Tamaño!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCategorias
            // 
            panelCategorias.Controls.Add(panel7);
            panelCategorias.Controls.Add(label6);
            panelCategorias.Location = new Point(0, 0);
            panelCategorias.Name = "panelCategorias";
            panelCategorias.Size = new Size(357, 123);
            panelCategorias.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtCategoria);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 29);
            panel7.Name = "panel7";
            panel7.Size = new Size(357, 94);
            panel7.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(100, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(223, 1);
            panel8.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 44);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 5;
            label5.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.FromArgb(0, 59, 103);
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Constantia", 12F, FontStyle.Bold);
            txtCategoria.ForeColor = Color.White;
            txtCategoria.Location = new Point(100, 43);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoría";
            txtCategoria.Size = new Size(223, 20);
            txtCategoria.TabIndex = 1;
            txtCategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(357, 29);
            label6.TabIndex = 11;
            label6.Text = "¡Nueva Categoría!";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGeneros
            // 
            panelGeneros.Controls.Add(panel9);
            panelGeneros.Controls.Add(label8);
            panelGeneros.Location = new Point(0, 0);
            panelGeneros.Name = "panelGeneros";
            panelGeneros.Size = new Size(356, 123);
            panelGeneros.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Controls.Add(label7);
            panel9.Controls.Add(txtGenero);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 39);
            panel9.Name = "panel9";
            panel9.Size = new Size(356, 84);
            panel9.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(32, 31);
            label7.Name = "label7";
            label7.Size = new Size(71, 19);
            label7.TabIndex = 0;
            label7.Text = "Género:";
            // 
            // txtGenero
            // 
            txtGenero.Anchor = AnchorStyles.None;
            txtGenero.BackColor = Color.FromArgb(0, 59, 103);
            txtGenero.BorderStyle = BorderStyle.None;
            txtGenero.Font = new Font("Constantia", 12F, FontStyle.Bold);
            txtGenero.ForeColor = Color.White;
            txtGenero.Location = new Point(132, 31);
            txtGenero.Name = "txtGenero";
            txtGenero.PlaceholderText = "Género";
            txtGenero.Size = new Size(175, 20);
            txtGenero.TabIndex = 1;
            txtGenero.TextAlign = HorizontalAlignment.Center;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(132, 52);
            panel10.Name = "panel10";
            panel10.Size = new Size(175, 1);
            panel10.TabIndex = 4;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(356, 39);
            label8.TabIndex = 1;
            label8.Text = "¡Nueva Género!";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmNuevoTipoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(356, 183);
            Controls.Add(panelGeneros);
            Controls.Add(panelMarcas);
            Controls.Add(panel2);
            Controls.Add(panelCategorias);
            Controls.Add(panelTamanios);
            Controls.Add(panelTipoDireccion);
            Controls.Add(panelTipotelefono);
            Name = "frmNuevoTipoAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo";
            Load += frmMarcasAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelMarcas.ResumeLayout(false);
            panelTipoDireccion.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panelTipotelefono.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panelTamanios.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelCategorias.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelGeneros.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMarca;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelMarcas;
        private Panel panelTamanios;
        private Panel panel5;
        private Panel panel6;
        private Label label3;
        private TextBox txtTamanio;
        private Label label4;
        private Panel panelCategorias;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private TextBox txtCategoria;
        private Label label6;
        private Panel panelGeneros;
        private Panel panel9;
        private Label label7;
        private TextBox txtGenero;
        private Panel panel10;
        private Label label8;
        private Panel panelTipotelefono;
        private Panel panel11;
        private Label label9;
        private TextBox txtTelefono;
        private Panel panel12;
        private Label label10;
        private Panel panelTipoDireccion;
        private Panel panel13;
        private Label label11;
        private TextBox txtDireccion;
        private Panel panel14;
        private Label label12;
    }
}