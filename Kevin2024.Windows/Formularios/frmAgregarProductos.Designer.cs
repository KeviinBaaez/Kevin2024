namespace Kevin2024.Windows.Formularios
{
    partial class frmAgregarProductos
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
            panel4 = new Panel();
            btnFiltroCategoria = new Button();
            panel2 = new Panel();
            btnFiltroMarca = new Button();
            panel5 = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            nupCantidad = new NumericUpDown();
            label8 = new Label();
            label1 = new Label();
            cboProductos = new ComboBox();
            btnActualizar = new Button();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel3 = new Panel();
            btnFiltroTamanio = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 51);
            panel1.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnFiltroCategoria);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(374, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(187, 51);
            panel4.TabIndex = 2;
            // 
            // btnFiltroCategoria
            // 
            btnFiltroCategoria.Dock = DockStyle.Fill;
            btnFiltroCategoria.FlatStyle = FlatStyle.Popup;
            btnFiltroCategoria.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnFiltroCategoria.Location = new Point(0, 0);
            btnFiltroCategoria.Name = "btnFiltroCategoria";
            btnFiltroCategoria.Size = new Size(187, 51);
            btnFiltroCategoria.TabIndex = 20;
            btnFiltroCategoria.Text = "Cátegoria";
            btnFiltroCategoria.UseVisualStyleBackColor = true;
            btnFiltroCategoria.Click += btnFiltroCategoria_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFiltroMarca);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 51);
            panel2.TabIndex = 0;
            // 
            // btnFiltroMarca
            // 
            btnFiltroMarca.Dock = DockStyle.Fill;
            btnFiltroMarca.FlatStyle = FlatStyle.Popup;
            btnFiltroMarca.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnFiltroMarca.Location = new Point(0, 0);
            btnFiltroMarca.Name = "btnFiltroMarca";
            btnFiltroMarca.Size = new Size(187, 51);
            btnFiltroMarca.TabIndex = 20;
            btnFiltroMarca.Text = "Marca";
            btnFiltroMarca.UseVisualStyleBackColor = true;
            btnFiltroMarca.Click += btnFiltroMarca_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCancelar);
            panel5.Controls.Add(btnAceptar);
            panel5.Controls.Add(nupCantidad);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cboProductos);
            panel5.Controls.Add(btnActualizar);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            panel5.Location = new Point(0, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(561, 223);
            panel5.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(297, 146);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(184, 50);
            btnCancelar.TabIndex = 23;
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
            btnAceptar.Location = new Point(75, 146);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(201, 50);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // nupCantidad
            // 
            nupCantidad.BackColor = Color.FromArgb(1, 95, 168);
            nupCantidad.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupCantidad.Location = new Point(150, 76);
            nupCantidad.Margin = new Padding(11, 10, 11, 10);
            nupCantidad.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nupCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(111, 26);
            nupCantidad.TabIndex = 20;
            nupCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label8.Location = new Point(51, 78);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 21;
            label8.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 19;
            label1.Text = "Productos:";
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.FormattingEnabled = true;
            cboProductos.ItemHeight = 23;
            cboProductos.Location = new Point(151, 20);
            cboProductos.Margin = new Padding(4);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(284, 31);
            cboProductos.TabIndex = 18;
            cboProductos.SelectedIndexChanged += cboProductos_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.Location = new Point(442, 20);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(39, 31);
            btnActualizar.TabIndex = 25;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(561, 43);
            label2.TabIndex = 24;
            label2.Text = "Filtrar Por";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnFiltroTamanio);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(187, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 51);
            panel3.TabIndex = 0;
            // 
            // btnFiltroTamanio
            // 
            btnFiltroTamanio.Dock = DockStyle.Fill;
            btnFiltroTamanio.FlatStyle = FlatStyle.Popup;
            btnFiltroTamanio.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnFiltroTamanio.Location = new Point(0, 0);
            btnFiltroTamanio.Name = "btnFiltroTamanio";
            btnFiltroTamanio.Size = new Size(187, 51);
            btnFiltroTamanio.TabIndex = 20;
            btnFiltroTamanio.Text = "Tamaño";
            btnFiltroTamanio.UseVisualStyleBackColor = true;
            btnFiltroTamanio.Click += btnFiltroTamanio_Click;
            // 
            // frmAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(561, 317);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "frmAgregarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarProductos";
            Load += frmAgregarProductos_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private ComboBox cboProductos;
        private NumericUpDown nupCantidad;
        private Label label8;
        private Button btnCancelar;
        private Button btnAceptar;
        private Button btnFiltroMarca;
        private Label label2;
        private Button btnFiltroCategoria;
        private ErrorProvider errorProvider1;
        private Button btnActualizar;
        private Panel panel3;
        private Button btnFiltroTamanio;
    }
}