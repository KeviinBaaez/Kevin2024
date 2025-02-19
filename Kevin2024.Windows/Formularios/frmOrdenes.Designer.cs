namespace Kevin2024.Windows.Formularios
{
    partial class frmOrdenes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            label1 = new Label();
            cboPaginas = new ComboBox();
            txtPaginas = new TextBox();
            panel2 = new Panel();
            toolStrip1 = new ToolStrip();
            tsbdetalles = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            busquedaToolStripMenuItem = new ToolStripMenuItem();
            cboEstadoOrdenFiltro = new ToolStripComboBox();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripDropDownButton();
            ordenAZToolStripMenuItem = new ToolStripMenuItem();
            ordenZAToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            dgvDatos = new DataGridView();
            repositorioArchivosBindingSource = new BindingSource(components);
            ColOrdenNro = new DataGridViewTextBoxColumn();
            ColTipoVenta = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFechaVta = new DataGridViewTextBoxColumn();
            ColRegalo = new DataGridViewCheckBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            ColEstadoOrden = new DataGridViewButtonColumn();
            ColEstadoPago = new DataGridViewButtonColumn();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositorioArchivosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 95, 168);
            panel3.Controls.Add(btnUltimo);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(btnPrimero);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cboPaginas);
            panel3.Controls.Add(txtPaginas);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 564);
            panel3.Name = "panel3";
            panel3.Size = new Size(1073, 64);
            panel3.TabIndex = 7;
            // 
            // btnUltimo
            // 
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.Image = Properties.Resources.angulo_doble_derecha__1_;
            btnUltimo.Location = new Point(732, 6);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(49, 49);
            btnUltimo.TabIndex = 3;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Image = Properties.Resources.angulo_pequeno_derecho__1_;
            btnSiguiente.Location = new Point(662, 9);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(51, 44);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Image = Properties.Resources.angulo_pequeno_izquierdo__1_;
            btnAnterior.Location = new Point(589, 9);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(51, 44);
            btnAnterior.TabIndex = 3;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.Image = Properties.Resources.angulo_doble_izquierda__1_;
            btnPrimero.Location = new Point(519, 6);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(49, 47);
            btnPrimero.TabIndex = 3;
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 33);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 2;
            label1.Text = "de";
            // 
            // cboPaginas
            // 
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(23, 29);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(79, 23);
            cboPaginas.TabIndex = 1;
            cboPaginas.SelectedIndexChanged += CboPaginas_SelectedIndexChanged;
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(140, 29);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.ReadOnly = true;
            txtPaginas.Size = new Size(79, 23);
            txtPaginas.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 72);
            panel2.TabIndex = 8;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(1, 95, 168);
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbdetalles, tsbBorrar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, toolStripButton7, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(1073, 72);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbdetalles
            // 
            tsbdetalles.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbdetalles.Image = Properties.Resources.lista;
            tsbdetalles.ImageTransparentColor = Color.Magenta;
            tsbdetalles.Name = "tsbdetalles";
            tsbdetalles.Size = new Size(87, 69);
            tsbdetalles.Text = "Detalles";
            tsbdetalles.TextAlign = ContentAlignment.BottomCenter;
            tsbdetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbdetalles.Click += tsbdetalles_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbBorrar.Image = Properties.Resources.borrar;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(72, 69);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextAlign = ContentAlignment.BottomCenter;
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 72);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { busquedaToolStripMenuItem, cboEstadoOrdenFiltro });
            tsbFiltrar.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbFiltrar.Image = Properties.Resources.lista;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(95, 69);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // busquedaToolStripMenuItem
            // 
            busquedaToolStripMenuItem.Image = Properties.Resources.busqueda;
            busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            busquedaToolStripMenuItem.Size = new Size(181, 28);
            busquedaToolStripMenuItem.Text = "Nro Órden";
            busquedaToolStripMenuItem.Click += busquedaToolStripMenuItem_Click;
            // 
            // cboEstadoOrdenFiltro
            // 
            cboEstadoOrdenFiltro.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboEstadoOrdenFiltro.Name = "cboEstadoOrdenFiltro";
            cboEstadoOrdenFiltro.Size = new Size(121, 31);
            cboEstadoOrdenFiltro.SelectedIndexChanged += cboEstadoOrdenFiltro_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbActualizar.Image = Properties.Resources.actualizar;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(121, 69);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 72);
            // 
            // toolStripButton7
            // 
            toolStripButton7.DropDownItems.AddRange(new ToolStripItem[] { ordenAZToolStripMenuItem, ordenZAToolStripMenuItem });
            toolStripButton7.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            toolStripButton7.Image = Properties.Resources.ordenar_alt;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(115, 69);
            toolStripButton7.Text = "Ordenar";
            // 
            // ordenAZToolStripMenuItem
            // 
            ordenAZToolStripMenuItem.Image = Properties.Resources.ordenar_alfa_arriba;
            ordenAZToolStripMenuItem.Name = "ordenAZToolStripMenuItem";
            ordenAZToolStripMenuItem.Size = new Size(183, 28);
            ordenAZToolStripMenuItem.Text = "Orden(A-Z)";
            ordenAZToolStripMenuItem.Click += ordenAZToolStripMenuItem_Click;
            // 
            // ordenZAToolStripMenuItem
            // 
            ordenZAToolStripMenuItem.Image = Properties.Resources.ordenar_alfa_abajo_alt;
            ordenZAToolStripMenuItem.Name = "ordenZAToolStripMenuItem";
            ordenZAToolStripMenuItem.Size = new Size(183, 28);
            ordenZAToolStripMenuItem.Text = "Orden(Z-A)";
            ordenZAToolStripMenuItem.Click += ordenZAToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 72);
            // 
            // tsbSalir
            // 
            tsbSalir.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbSalir.Image = Properties.Resources.salir_alt;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(54, 69);
            tsbSalir.Text = "Salir";
            tsbSalir.TextAlign = ContentAlignment.BottomCenter;
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColOrdenNro, ColTipoVenta, ColCliente, ColFechaVta, ColRegalo, ColTotal, ColEstadoOrden, ColEstadoPago });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 72);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1073, 492);
            dgvDatos.TabIndex = 9;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // repositorioArchivosBindingSource
            // 
            repositorioArchivosBindingSource.DataSource = typeof(Datos.Repositorios.RepositorioArchivos);
            // 
            // ColOrdenNro
            // 
            ColOrdenNro.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColOrdenNro.FillWeight = 253.807068F;
            ColOrdenNro.HeaderText = "Ord.Nro";
            ColOrdenNro.Name = "ColOrdenNro";
            ColOrdenNro.ReadOnly = true;
            ColOrdenNro.Width = 75;
            // 
            // ColTipoVenta
            // 
            ColTipoVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColTipoVenta.HeaderText = "Tipo Venta";
            ColTipoVenta.Name = "ColTipoVenta";
            ColTipoVenta.ReadOnly = true;
            ColTipoVenta.Width = 87;
            // 
            // ColCliente
            // 
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ColCliente.DefaultCellStyle = dataGridViewCellStyle2;
            ColCliente.FillWeight = 61.54823F;
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            // 
            // ColFechaVta
            // 
            ColFechaVta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFechaVta.FillWeight = 61.54823F;
            ColFechaVta.HeaderText = "Fecha";
            ColFechaVta.Name = "ColFechaVta";
            ColFechaVta.ReadOnly = true;
            // 
            // ColRegalo
            // 
            ColRegalo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColRegalo.FillWeight = 61.54823F;
            ColRegalo.HeaderText = "Regalo";
            ColRegalo.Name = "ColRegalo";
            ColRegalo.ReadOnly = true;
            ColRegalo.Width = 49;
            // 
            // ColTotal
            // 
            ColTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTotal.FillWeight = 61.54823F;
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            // 
            // ColEstadoOrden
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Demi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColEstadoOrden.DefaultCellStyle = dataGridViewCellStyle3;
            ColEstadoOrden.HeaderText = "Est. Órden";
            ColEstadoOrden.Name = "ColEstadoOrden";
            ColEstadoOrden.ReadOnly = true;
            ColEstadoOrden.Resizable = DataGridViewTriState.True;
            ColEstadoOrden.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColEstadoPago
            // 
            ColEstadoPago.HeaderText = "Est. Pago";
            ColEstadoPago.Name = "ColEstadoPago";
            ColEstadoPago.ReadOnly = true;
            ColEstadoPago.Resizable = DataGridViewTriState.True;
            // 
            // frmOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 628);
            Controls.Add(dgvDatos);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrdenes";
            Text = "frmOrdenes";
            Load += frmOrdenes_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositorioArchivosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private Label label1;
        private ComboBox cboPaginas;
        private TextBox txtPaginas;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbdetalles;
        private ToolStripButton tsbBorrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem busquedaToolStripMenuItem;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripButton7;
        private ToolStripMenuItem ordenAZToolStripMenuItem;
        private ToolStripMenuItem ordenZAToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private DataGridView dgvDatos;
        private BindingSource repositorioArchivosBindingSource;
        private ToolStripComboBox cboEstadoOrdenFiltro;
        private DataGridViewTextBoxColumn ColOrdenNro;
        private DataGridViewTextBoxColumn ColTipoVenta;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFechaVta;
        private DataGridViewCheckBoxColumn ColRegalo;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewButtonColumn ColEstadoOrden;
        private DataGridViewButtonColumn ColEstadoPago;
    }
}