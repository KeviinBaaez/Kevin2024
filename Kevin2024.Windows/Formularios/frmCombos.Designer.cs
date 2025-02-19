﻿namespace Kevin2024.Windows.Formularios
{
    partial class frmCombos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            busquedaToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            marcaToolStripMenuItem = new ToolStripMenuItem();
            tamañoToolStripMenuItem = new ToolStripMenuItem();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripDropDownButton();
            ordenAZToolStripMenuItem = new ToolStripMenuItem();
            ordenZAToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel3 = new Panel();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            label1 = new Label();
            cboPaginas = new ComboBox();
            txtPaginas = new TextBox();
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            ColComoboId = new DataGridViewTextBoxColumn();
            ColCombos = new DataGridViewTextBoxColumn();
            ColTamaño = new DataGridViewTextBoxColumn();
            ColPrecioVenta = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColSuspendido = new DataGridViewCheckBoxColumn();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 72);
            panel2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(1, 95, 168);
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbBorrar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, toolStripButton7, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 72);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.BackColor = Color.FromArgb(1, 95, 168);
            tsbNuevo.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbNuevo.Image = Properties.Resources.agregar_documento__1_;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(71, 69);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextAlign = ContentAlignment.BottomCenter;
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbEditar.Image = Properties.Resources.editar;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(68, 69);
            tsbEditar.Text = "Editar";
            tsbEditar.TextAlign = ContentAlignment.BottomCenter;
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
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
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { busquedaToolStripMenuItem, categoriaToolStripMenuItem, marcaToolStripMenuItem, tamañoToolStripMenuItem });
            tsbFiltrar.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbFiltrar.Image = Properties.Resources.lista;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(95, 69);
            tsbFiltrar.Text = "Filtrar";
            // 
            // busquedaToolStripMenuItem
            // 
            busquedaToolStripMenuItem.Image = (Image)resources.GetObject("busquedaToolStripMenuItem.Image");
            busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            busquedaToolStripMenuItem.Size = new Size(170, 28);
            busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Image = Properties.Resources.busqueda;
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(170, 28);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // marcaToolStripMenuItem
            // 
            marcaToolStripMenuItem.Image = Properties.Resources.busqueda;
            marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            marcaToolStripMenuItem.Size = new Size(170, 28);
            marcaToolStripMenuItem.Text = "Marca";
            // 
            // tamañoToolStripMenuItem
            // 
            tamañoToolStripMenuItem.Image = Properties.Resources.busqueda;
            tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            tamañoToolStripMenuItem.Size = new Size(170, 28);
            tamañoToolStripMenuItem.Text = "Tamaño";
            // 
            // tsbActualizar
            // 
            tsbActualizar.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            tsbActualizar.Image = Properties.Resources.actualizar;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(121, 69);
            tsbActualizar.Text = "Actualizar";
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
            // 
            // ordenZAToolStripMenuItem
            // 
            ordenZAToolStripMenuItem.Image = Properties.Resources.ordenar_alfa_abajo_alt;
            ordenZAToolStripMenuItem.Name = "ordenZAToolStripMenuItem";
            ordenZAToolStripMenuItem.Size = new Size(183, 28);
            ordenZAToolStripMenuItem.Text = "Orden(Z-A)";
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
            panel3.Location = new Point(0, 386);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 64);
            panel3.TabIndex = 3;
            // 
            // btnUltimo
            // 
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.Image = Properties.Resources.angulo_doble_derecha__1_;
            btnUltimo.Location = new Point(797, 9);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(49, 49);
            btnUltimo.TabIndex = 3;
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Image = Properties.Resources.angulo_pequeno_derecho__1_;
            btnSiguiente.Location = new Point(728, 12);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(51, 44);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Image = Properties.Resources.angulo_pequeno_izquierdo__1_;
            btnAnterior.Location = new Point(655, 12);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(51, 44);
            btnAnterior.TabIndex = 3;
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.Image = Properties.Resources.angulo_doble_izquierda__1_;
            btnPrimero.Location = new Point(585, 9);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(49, 47);
            btnPrimero.TabIndex = 3;
            btnPrimero.UseVisualStyleBackColor = true;
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
            cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(140, 29);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.ReadOnly = true;
            txtPaginas.Size = new Size(79, 23);
            txtPaginas.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 314);
            panel1.TabIndex = 4;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColComoboId, ColCombos, ColTamaño, ColPrecioVenta, ColStock, ColSuspendido });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 314);
            dgvDatos.TabIndex = 0;
            // 
            // ColComoboId
            // 
            ColComoboId.HeaderText = "ComboId";
            ColComoboId.Name = "ColComoboId";
            ColComoboId.ReadOnly = true;
            ColComoboId.Visible = false;
            // 
            // ColCombos
            // 
            ColCombos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCombos.FillWeight = 41.34588F;
            ColCombos.HeaderText = "Combos";
            ColCombos.Name = "ColCombos";
            ColCombos.ReadOnly = true;
            // 
            // ColTamaño
            // 
            ColTamaño.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTamaño.FillWeight = 41.34588F;
            ColTamaño.HeaderText = "Tamaño";
            ColTamaño.Name = "ColTamaño";
            ColTamaño.ReadOnly = true;
            // 
            // ColPrecioVenta
            // 
            ColPrecioVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColPrecioVenta.FillWeight = 41.34588F;
            ColPrecioVenta.HeaderText = "PrecioVenta";
            ColPrecioVenta.Name = "ColPrecioVenta";
            ColPrecioVenta.ReadOnly = true;
            ColPrecioVenta.Width = 110;
            // 
            // ColStock
            // 
            ColStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColStock.FillWeight = 67.87527F;
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            ColStock.Width = 90;
            // 
            // ColSuspendido
            // 
            ColSuspendido.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColSuspendido.FillWeight = 484.049438F;
            ColSuspendido.HeaderText = "Suspendido";
            ColSuspendido.Name = "ColSuspendido";
            ColSuspendido.ReadOnly = true;
            ColSuspendido.Width = 80;
            // 
            // frmCombos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmCombos";
            Text = "frmCombos";
            Load += frmCombos_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbBorrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem busquedaToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem marcaToolStripMenuItem;
        private ToolStripMenuItem tamañoToolStripMenuItem;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripButton7;
        private ToolStripMenuItem ordenAZToolStripMenuItem;
        private ToolStripMenuItem ordenZAToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private Panel panel3;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private Label label1;
        private ComboBox cboPaginas;
        private TextBox txtPaginas;
        private Panel panel1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColComoboId;
        private DataGridViewTextBoxColumn ColCombos;
        private DataGridViewTextBoxColumn ColTamaño;
        private DataGridViewTextBoxColumn ColPrecioVenta;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewCheckBoxColumn ColSuspendido;
    }
}