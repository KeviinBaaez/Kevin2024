namespace Kevin2024.Windows.Formularios
{
    partial class frmFiltro
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
            panelCategorias = new Panel();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            panelMarcas = new Panel();
            lblMarcas = new Label();
            txtMarca = new TextBox();
            panelTamanios = new Panel();
            label4 = new Label();
            txtTamanios = new TextBox();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            PanelBusqueda = new Panel();
            txtBusqueda = new TextBox();
            panelGeneros = new Panel();
            txtGenero = new TextBox();
            label1 = new Label();
            panelTiposTelefonos = new Panel();
            txtTelefono = new TextBox();
            label2 = new Label();
            panelTiposDirecciones = new Panel();
            txtDireccion = new TextBox();
            label3 = new Label();
            panelCategorias.SuspendLayout();
            panelMarcas.SuspendLayout();
            panelTamanios.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            PanelBusqueda.SuspendLayout();
            panelGeneros.SuspendLayout();
            panelTiposTelefonos.SuspendLayout();
            panelTiposDirecciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategorias
            // 
            panelCategorias.BackColor = Color.FromArgb(0, 59, 103);
            panelCategorias.Controls.Add(txtCategoria);
            panelCategorias.Controls.Add(lblCategoria);
            panelCategorias.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelCategorias.Location = new Point(1, 0);
            panelCategorias.Name = "panelCategorias";
            panelCategorias.Size = new Size(358, 76);
            panelCategorias.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.Black;
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.ForeColor = Color.White;
            txtCategoria.Location = new Point(118, 28);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Escriba para buscar...";
            txtCategoria.Size = new Size(217, 27);
            txtCategoria.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(12, 30);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 19);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categorías: ";
            // 
            // panelMarcas
            // 
            panelMarcas.BackColor = Color.FromArgb(0, 59, 103);
            panelMarcas.Controls.Add(lblMarcas);
            panelMarcas.Controls.Add(txtMarca);
            panelMarcas.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMarcas.Location = new Point(0, 0);
            panelMarcas.Name = "panelMarcas";
            panelMarcas.Size = new Size(357, 76);
            panelMarcas.TabIndex = 1;
            // 
            // lblMarcas
            // 
            lblMarcas.AutoSize = true;
            lblMarcas.ForeColor = Color.White;
            lblMarcas.Location = new Point(12, 32);
            lblMarcas.Name = "lblMarcas";
            lblMarcas.Size = new Size(73, 19);
            lblMarcas.TabIndex = 1;
            lblMarcas.Text = "Marcas: ";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.Black;
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.ForeColor = Color.White;
            txtMarca.Location = new Point(91, 30);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Escriba para buscar...";
            txtMarca.Size = new Size(245, 27);
            txtMarca.TabIndex = 1;
            // 
            // panelTamanios
            // 
            panelTamanios.BackColor = Color.FromArgb(0, 59, 103);
            panelTamanios.Controls.Add(label4);
            panelTamanios.Controls.Add(txtTamanios);
            panelTamanios.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTamanios.Location = new Point(1, 0);
            panelTamanios.Name = "panelTamanios";
            panelTamanios.Size = new Size(357, 76);
            panelTamanios.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 32);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 1;
            label4.Text = "Tamaños:";
            // 
            // txtTamanios
            // 
            txtTamanios.BackColor = Color.Black;
            txtTamanios.BorderStyle = BorderStyle.FixedSingle;
            txtTamanios.ForeColor = Color.White;
            txtTamanios.Location = new Point(109, 30);
            txtTamanios.Name = "txtTamanios";
            txtTamanios.PlaceholderText = "Escriba para buscar...";
            txtTamanios.Size = new Size(220, 27);
            txtTamanios.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 103);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 52);
            panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(208, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(21, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(156, 41);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PanelBusqueda
            // 
            PanelBusqueda.BackColor = Color.FromArgb(0, 59, 103);
            PanelBusqueda.Controls.Add(txtBusqueda);
            PanelBusqueda.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelBusqueda.Location = new Point(0, 0);
            PanelBusqueda.Name = "PanelBusqueda";
            PanelBusqueda.Size = new Size(358, 73);
            PanelBusqueda.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.Black;
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.ForeColor = Color.White;
            txtBusqueda.Location = new Point(39, 25);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Escriba para buscar...";
            txtBusqueda.Size = new Size(281, 27);
            txtBusqueda.TabIndex = 1;
            // 
            // panelGeneros
            // 
            panelGeneros.BackColor = Color.FromArgb(0, 59, 103);
            panelGeneros.Controls.Add(txtGenero);
            panelGeneros.Controls.Add(label1);
            panelGeneros.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelGeneros.Location = new Point(1, 0);
            panelGeneros.Name = "panelGeneros";
            panelGeneros.Size = new Size(358, 76);
            panelGeneros.TabIndex = 1;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = Color.Black;
            txtGenero.BorderStyle = BorderStyle.FixedSingle;
            txtGenero.ForeColor = Color.White;
            txtGenero.Location = new Point(118, 28);
            txtGenero.Name = "txtGenero";
            txtGenero.PlaceholderText = "Escriba para buscar...";
            txtGenero.Size = new Size(217, 27);
            txtGenero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 1;
            label1.Text = "Géneros:";
            // 
            // panelTiposTelefonos
            // 
            panelTiposTelefonos.BackColor = Color.FromArgb(0, 59, 103);
            panelTiposTelefonos.Controls.Add(txtTelefono);
            panelTiposTelefonos.Controls.Add(label2);
            panelTiposTelefonos.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTiposTelefonos.Location = new Point(0, 0);
            panelTiposTelefonos.Name = "panelTiposTelefonos";
            panelTiposTelefonos.Size = new Size(358, 76);
            panelTiposTelefonos.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Black;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(118, 28);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escriba para buscar...";
            txtTelefono.Size = new Size(217, 27);
            txtTelefono.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 1;
            label2.Text = "T. teléfono:";
            // 
            // panelTiposDirecciones
            // 
            panelTiposDirecciones.BackColor = Color.FromArgb(0, 59, 103);
            panelTiposDirecciones.Controls.Add(txtDireccion);
            panelTiposDirecciones.Controls.Add(label3);
            panelTiposDirecciones.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTiposDirecciones.Location = new Point(0, 0);
            panelTiposDirecciones.Name = "panelTiposDirecciones";
            panelTiposDirecciones.Size = new Size(358, 76);
            panelTiposDirecciones.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.Black;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(118, 28);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escriba para buscar...";
            txtDireccion.Size = new Size(217, 27);
            txtDireccion.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 1;
            label3.Text = "T. dirección:";
            // 
            // frmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 125);
            Controls.Add(panel1);
            Controls.Add(PanelBusqueda);
            Controls.Add(panelGeneros);
            Controls.Add(panelCategorias);
            Controls.Add(panelMarcas);
            Controls.Add(panelTamanios);
            Controls.Add(panelTiposDirecciones);
            Controls.Add(panelTiposTelefonos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFiltro";
            Load += frmFiltro_Load;
            panelCategorias.ResumeLayout(false);
            panelCategorias.PerformLayout();
            panelMarcas.ResumeLayout(false);
            panelMarcas.PerformLayout();
            panelTamanios.ResumeLayout(false);
            panelTamanios.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            PanelBusqueda.ResumeLayout(false);
            PanelBusqueda.PerformLayout();
            panelGeneros.ResumeLayout(false);
            panelGeneros.PerformLayout();
            panelTiposTelefonos.ResumeLayout(false);
            panelTiposTelefonos.PerformLayout();
            panelTiposDirecciones.ResumeLayout(false);
            panelTiposDirecciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCategorias;
        private Label lblCategoria;
        private Panel panelMarcas;
        private Label lblMarcas;
        private Panel panelTamanios;
        private Label label4;
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private TextBox txtTamanios;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
        private Panel PanelBusqueda;
        private TextBox txtBusqueda;
        private Panel panelGeneros;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtGenero;
        private Panel panelTiposTelefonos;
        private TextBox txtTelefono;
        private Label label2;
        private Panel panelTiposDirecciones;
        private TextBox txtDireccion;
        private Label label3;
    }
}