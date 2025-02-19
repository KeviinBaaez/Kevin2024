namespace Kevin2024.Windows.Formularios
{
    partial class frmConsulta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            ColProductoId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColMarca = new DataGridViewTextBoxColumn();
            ColCodBarras = new DataGridViewTextBoxColumn();
            ColTamaño = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            ColPrecioVenta = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColSuspendido = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColProductoId, ColNombre, ColMarca, ColCodBarras, ColTamaño, ColCategoria, ColPrecioVenta, ColStock, ColSuspendido });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 450);
            dgvDatos.TabIndex = 1;
            // 
            // ColProductoId
            // 
            ColProductoId.HeaderText = "ProductoId";
            ColProductoId.Name = "ColProductoId";
            ColProductoId.ReadOnly = true;
            ColProductoId.Visible = false;
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNombre.FillWeight = 41.34588F;
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColMarca
            // 
            ColMarca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMarca.FillWeight = 41.34588F;
            ColMarca.HeaderText = "Marca";
            ColMarca.Name = "ColMarca";
            ColMarca.ReadOnly = true;
            // 
            // ColCodBarras
            // 
            ColCodBarras.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCodBarras.FillWeight = 41.34588F;
            ColCodBarras.HeaderText = "CodBarras";
            ColCodBarras.Name = "ColCodBarras";
            ColCodBarras.ReadOnly = true;
            // 
            // ColTamaño
            // 
            ColTamaño.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTamaño.FillWeight = 41.34588F;
            ColTamaño.HeaderText = "Tamaño";
            ColTamaño.Name = "ColTamaño";
            ColTamaño.ReadOnly = true;
            // 
            // ColCategoria
            // 
            ColCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategoria.FillWeight = 41.34588F;
            ColCategoria.HeaderText = "Categoria";
            ColCategoria.Name = "ColCategoria";
            ColCategoria.ReadOnly = true;
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
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Name = "frmConsulta";
            Text = "frmConsulta";
            Load += frmConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColProductoId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColCodBarras;
        private DataGridViewTextBoxColumn ColTamaño;
        private DataGridViewTextBoxColumn ColCategoria;
        private DataGridViewTextBoxColumn ColPrecioVenta;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewCheckBoxColumn ColSuspendido;
    }
}