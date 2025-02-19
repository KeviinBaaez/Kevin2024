namespace Kevin2024.Windows.Formularios
{
    partial class frmVentasAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasAE));
            splitContainer1 = new SplitContainer();
            fmlProductos = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelOrdenes = new Panel();
            btnOrdenes = new Button();
            PanelProductos = new Panel();
            btnProductos = new Button();
            panelCombos = new Panel();
            btnCombos = new Button();
            dgvDatos = new DataGridView();
            panel3 = new Panel();
            lblTotal = new Label();
            label4 = new Label();
            lblCantidad = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            panel2 = new Panel();
            btnMas = new Button();
            label1 = new Label();
            lblCantidadPor = new Label();
            errorProvider1 = new ErrorProvider(components);
            ColProductoId = new DataGridViewTextBoxColumn();
            ColProducto = new DataGridViewTextBoxColumn();
            ColPrecioUnidad = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            ColBorrar = new DataGridViewImageColumn();
            ColEditar = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelOrdenes.SuspendLayout();
            PanelProductos.SuspendLayout();
            panelCombos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(fmlProductos);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDatos);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1026, 634);
            splitContainer1.SplitterDistance = 618;
            splitContainer1.TabIndex = 0;
            // 
            // fmlProductos
            // 
            fmlProductos.AutoScroll = true;
            fmlProductos.Dock = DockStyle.Fill;
            fmlProductos.Location = new Point(0, 94);
            fmlProductos.Name = "fmlProductos";
            fmlProductos.Size = new Size(618, 540);
            fmlProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 95, 168);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 94);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panelOrdenes);
            flowLayoutPanel2.Controls.Add(PanelProductos);
            flowLayoutPanel2.Controls.Add(panelCombos);
            flowLayoutPanel2.Location = new Point(58, 7);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(499, 81);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panelOrdenes
            // 
            panelOrdenes.BackColor = Color.FromArgb(0, 59, 103);
            panelOrdenes.Controls.Add(btnOrdenes);
            panelOrdenes.Location = new Point(3, 3);
            panelOrdenes.Name = "panelOrdenes";
            panelOrdenes.Size = new Size(160, 65);
            panelOrdenes.TabIndex = 3;
            // 
            // btnOrdenes
            // 
            btnOrdenes.Dock = DockStyle.Top;
            btnOrdenes.FlatStyle = FlatStyle.Flat;
            btnOrdenes.Font = new Font("Constantia", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnOrdenes.Image = Properties.Resources.lista;
            btnOrdenes.ImageAlign = ContentAlignment.TopCenter;
            btnOrdenes.Location = new Point(0, 0);
            btnOrdenes.Margin = new Padding(3, 30, 3, 3);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(160, 65);
            btnOrdenes.TabIndex = 2;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.TextAlign = ContentAlignment.BottomCenter;
            btnOrdenes.UseVisualStyleBackColor = true;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // PanelProductos
            // 
            PanelProductos.BackColor = Color.FromArgb(0, 59, 103);
            PanelProductos.Controls.Add(btnProductos);
            PanelProductos.Location = new Point(169, 3);
            PanelProductos.Name = "PanelProductos";
            PanelProductos.Size = new Size(160, 65);
            PanelProductos.TabIndex = 3;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Constantia", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.TopCenter;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Margin = new Padding(3, 30, 3, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(160, 65);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.BottomCenter;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelCombos
            // 
            panelCombos.BackColor = Color.FromArgb(0, 59, 103);
            panelCombos.Controls.Add(btnCombos);
            panelCombos.Location = new Point(335, 3);
            panelCombos.Name = "panelCombos";
            panelCombos.Size = new Size(160, 65);
            panelCombos.TabIndex = 3;
            // 
            // btnCombos
            // 
            btnCombos.Dock = DockStyle.Top;
            btnCombos.FlatStyle = FlatStyle.Flat;
            btnCombos.Font = new Font("Constantia", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCombos.Image = Properties.Resources.comida_rapida__1_;
            btnCombos.ImageAlign = ContentAlignment.TopCenter;
            btnCombos.Location = new Point(0, 0);
            btnCombos.Margin = new Padding(3, 30, 3, 3);
            btnCombos.Name = "btnCombos";
            btnCombos.Size = new Size(160, 65);
            btnCombos.TabIndex = 2;
            btnCombos.Text = "Combos";
            btnCombos.TextAlign = ContentAlignment.BottomCenter;
            btnCombos.UseVisualStyleBackColor = true;
            btnCombos.Click += btnCombos_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColProductoId, ColProducto, ColPrecioUnidad, ColCantidad, ColTotal, ColBorrar, ColEditar });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 100);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(404, 429);
            dgvDatos.TabIndex = 2;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 95, 168);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblCantidad);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 529);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 105);
            panel3.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(342, 3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(24, 15);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "$ 0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(299, 3);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 23;
            label4.Text = "Total:";
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(234, 3);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(14, 15);
            lblCantidad.TabIndex = 24;
            lblCantidad.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(185, 3);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 25;
            label3.Text = "Cant.:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(55, 3);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 21;
            label2.Text = "Totales:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(244, 44);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 48);
            btnCancelar.TabIndex = 20;
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
            btnAceptar.Location = new Point(26, 44);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(181, 48);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 95, 168);
            panel2.Controls.Add(btnMas);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblCantidadPor);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 100);
            panel2.TabIndex = 0;
            // 
            // btnMas
            // 
            btnMas.FlatStyle = FlatStyle.Flat;
            btnMas.ForeColor = Color.FromArgb(1, 95, 168);
            btnMas.Image = Properties.Resources.calculadora;
            btnMas.Location = new Point(163, 16);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(110, 65);
            btnMas.TabIndex = 0;
            btnMas.TextImageRelation = TextImageRelation.TextAboveImage;
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 36);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 24;
            label1.Text = "x";
            // 
            // lblCantidadPor
            // 
            lblCantidadPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCantidadPor.AutoSize = true;
            lblCantidadPor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadPor.Location = new Point(80, 36);
            lblCantidadPor.Name = "lblCantidadPor";
            lblCantidadPor.Size = new Size(19, 21);
            lblCantidadPor.TabIndex = 24;
            lblCantidadPor.Text = "1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ColProductoId
            // 
            ColProductoId.HeaderText = "Id";
            ColProductoId.Name = "ColProductoId";
            ColProductoId.ReadOnly = true;
            ColProductoId.Visible = false;
            // 
            // ColProducto
            // 
            ColProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColProducto.HeaderText = "Producto";
            ColProducto.Name = "ColProducto";
            ColProducto.ReadOnly = true;
            // 
            // ColPrecioUnidad
            // 
            ColPrecioUnidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPrecioUnidad.HeaderText = "Precio(U)";
            ColPrecioUnidad.Name = "ColPrecioUnidad";
            ColPrecioUnidad.ReadOnly = true;
            ColPrecioUnidad.Width = 81;
            // 
            // ColCantidad
            // 
            ColCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            ColCantidad.Width = 80;
            // 
            // ColTotal
            // 
            ColTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            ColTotal.Width = 57;
            // 
            // ColBorrar
            // 
            ColBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColBorrar.HeaderText = "";
            ColBorrar.Image = Properties.Resources.boton_de_eliminacion_de_la_papelera__1_;
            ColBorrar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColBorrar.Name = "ColBorrar";
            ColBorrar.ReadOnly = true;
            ColBorrar.Width = 5;
            // 
            // ColEditar
            // 
            ColEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColEditar.HeaderText = "";
            ColEditar.Image = Properties.Resources.boton_subrayado;
            ColEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColEditar.Name = "ColEditar";
            ColEditar.ReadOnly = true;
            ColEditar.Width = 5;
            // 
            // frmVentasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 634);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVentasAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVentasAE";
            Load += frmVentasAE_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panelOrdenes.ResumeLayout(false);
            PanelProductos.ResumeLayout(false);
            panelCombos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel fmlProductos;
        private Panel panel1;
        private DataGridView dgvDatos;
        private Panel panel3;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel PanelProductos;
        private Button btnProductos;
        private Panel panelCombos;
        private Button btnCombos;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTotal;
        private Label label4;
        private Label lblCantidad;
        private Label label3;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Button btnMas;
        private Label lblCantidadPor;
        private Label label1;
        private Panel panelOrdenes;
        private Button btnOrdenes;
        private DataGridViewTextBoxColumn ColProductoId;
        private DataGridViewTextBoxColumn ColProducto;
        private DataGridViewTextBoxColumn ColPrecioUnidad;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewImageColumn ColBorrar;
        private DataGridViewImageColumn ColEditar;
    }
}