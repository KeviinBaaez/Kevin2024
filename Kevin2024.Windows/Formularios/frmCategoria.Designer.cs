﻿namespace Kevin2024.Windows.Formularios
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            ColCategoriaId = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
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
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            busquedaToolStripMenuItem = new ToolStripMenuItem();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripDropDownButton();
            ordenToolStripMenuItem = new ToolStripMenuItem();
            ordenZAToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 327);
            panel1.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColCategoriaId, ColCategoria });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(514, 327);
            dgvDatos.TabIndex = 0;
            // 
            // ColCategoriaId
            // 
            ColCategoriaId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategoriaId.HeaderText = "CategoriaId";
            ColCategoriaId.Name = "ColCategoriaId";
            ColCategoriaId.ReadOnly = true;
            // 
            // ColCategoria
            // 
            ColCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategoria.HeaderText = "Categoria";
            ColCategoria.Name = "ColCategoria";
            ColCategoria.ReadOnly = true;
            // 
            // panel3
            // 
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
            panel3.Size = new Size(514, 64);
            panel3.TabIndex = 5;
            // 
            // btnUltimo
            // 
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.Image = Properties.Resources.angulo_doble_derecha__1_;
            btnUltimo.Location = new Point(422, 20);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(43, 37);
            btnUltimo.TabIndex = 3;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Image = Properties.Resources.angulo_pequeno_derecho__1_;
            btnSiguiente.Location = new Point(375, 22);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(41, 35);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Image = Properties.Resources.angulo_pequeno_izquierdo__1_;
            btnAnterior.Location = new Point(328, 22);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(41, 35);
            btnAnterior.TabIndex = 3;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.Image = Properties.Resources.angulo_doble_izquierda__1_;
            btnPrimero.Location = new Point(279, 20);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(43, 39);
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
            txtPaginas.Size = new Size(79, 23);
            txtPaginas.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 59);
            panel2.TabIndex = 4;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbBorrar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, toolStripButton7, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(514, 59);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Font = new Font("Constantia", 11.25F);
            tsbNuevo.Image = Properties.Resources.agregar_documento__1_;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(54, 56);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextAlign = ContentAlignment.BottomCenter;
            tsbNuevo.TextImageRelation = TextImageRelation.Overlay;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Font = new Font("Constantia", 11.25F);
            tsbEditar.Image = Properties.Resources.editar;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 56);
            tsbEditar.Text = "Editar";
            tsbEditar.TextAlign = ContentAlignment.BottomCenter;
            tsbEditar.TextImageRelation = TextImageRelation.Overlay;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Font = new Font("Constantia", 11.25F);
            tsbBorrar.Image = Properties.Resources.borrar;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 56);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextAlign = ContentAlignment.BottomCenter;
            tsbBorrar.TextImageRelation = TextImageRelation.Overlay;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { busquedaToolStripMenuItem });
            tsbFiltrar.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsbFiltrar.Image = Properties.Resources.lista;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(77, 56);
            tsbFiltrar.Text = "Filtrar";
            // 
            // busquedaToolStripMenuItem
            // 
            busquedaToolStripMenuItem.Image = (Image)resources.GetObject("busquedaToolStripMenuItem.Image");
            busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            busquedaToolStripMenuItem.Size = new Size(140, 22);
            busquedaToolStripMenuItem.Text = "Busqueda";
            busquedaToolStripMenuItem.Click += busquedaToolStripMenuItem_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Font = new Font("Constantia", 11.25F);
            tsbActualizar.Image = Properties.Resources.actualizar;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(94, 56);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 59);
            // 
            // toolStripButton7
            // 
            toolStripButton7.DropDownItems.AddRange(new ToolStripItem[] { ordenToolStripMenuItem, ordenZAToolStripMenuItem });
            toolStripButton7.Font = new Font("Constantia", 11.25F);
            toolStripButton7.Image = Properties.Resources.ordenar_alt;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(93, 56);
            toolStripButton7.Text = "Ordenar";
            // 
            // ordenToolStripMenuItem
            // 
            ordenToolStripMenuItem.Image = (Image)resources.GetObject("ordenToolStripMenuItem.Image");
            ordenToolStripMenuItem.Name = "ordenToolStripMenuItem";
            ordenToolStripMenuItem.Size = new Size(155, 22);
            ordenToolStripMenuItem.Text = "Orden(A-Z)";
            ordenToolStripMenuItem.Click += ordenAZToolStripMenuItem_Click;
            // 
            // ordenZAToolStripMenuItem
            // 
            ordenZAToolStripMenuItem.Image = (Image)resources.GetObject("ordenZAToolStripMenuItem.Image");
            ordenZAToolStripMenuItem.Name = "ordenZAToolStripMenuItem";
            ordenZAToolStripMenuItem.Size = new Size(155, 22);
            ordenZAToolStripMenuItem.Text = "Orden(Z-A)";
            ordenZAToolStripMenuItem.Click += ordenZAToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 59);
            // 
            // tsbSalir
            // 
            tsbSalir.Font = new Font("Constantia", 11.25F);
            tsbSalir.Image = Properties.Resources.salir_alt;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(41, 56);
            tsbSalir.Text = "Salir";
            tsbSalir.TextAlign = ContentAlignment.BottomCenter;
            tsbSalir.TextImageRelation = TextImageRelation.Overlay;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategorias_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColCategoriaId;
        private DataGridViewTextBoxColumn ColCategoria;
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
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbBorrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem busquedaToolStripMenuItem;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private ToolStripDropDownButton toolStripButton7;
        private ToolStripMenuItem ordenToolStripMenuItem;
        private ToolStripMenuItem ordenZAToolStripMenuItem;
    }
}