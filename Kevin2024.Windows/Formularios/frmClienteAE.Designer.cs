namespace Kevin2024.Windows.Formularios
{
    partial class frmClienteAE
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
            dgvDirecciones = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            dgvTelefonos = new DataGridView();
            colTelId = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btnAgregarDireccion = new Button();
            btnBorrarDireccion = new Button();
            btnEditarDireccion = new Button();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            tabCliente = new TabControl();
            Télefonos = new TabPage();
            panel5 = new Panel();
            btnAgregarTelefono = new Button();
            btnBorrarTelefono = new Button();
            btnEditarTelefono = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDirecciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTelefonos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabCliente.SuspendLayout();
            Télefonos.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDirecciones
            // 
            dgvDirecciones.AllowUserToAddRows = false;
            dgvDirecciones.AllowUserToDeleteRows = false;
            dgvDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirecciones.Columns.AddRange(new DataGridViewColumn[] { colId, colDireccion });
            dgvDirecciones.Dock = DockStyle.Fill;
            dgvDirecciones.Location = new Point(3, 3);
            dgvDirecciones.MultiSelect = false;
            dgvDirecciones.Name = "dgvDirecciones";
            dgvDirecciones.ReadOnly = true;
            dgvDirecciones.RowHeadersVisible = false;
            dgvDirecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirecciones.Size = new Size(793, 284);
            dgvDirecciones.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colDireccion
            // 
            colDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // dgvTelefonos
            // 
            dgvTelefonos.AllowUserToAddRows = false;
            dgvTelefonos.AllowUserToDeleteRows = false;
            dgvTelefonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefonos.Columns.AddRange(new DataGridViewColumn[] { colTelId, colTelefono });
            dgvTelefonos.Dock = DockStyle.Fill;
            dgvTelefonos.Location = new Point(3, 3);
            dgvTelefonos.MultiSelect = false;
            dgvTelefonos.Name = "dgvTelefonos";
            dgvTelefonos.ReadOnly = true;
            dgvTelefonos.RowHeadersVisible = false;
            dgvTelefonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelefonos.Size = new Size(793, 284);
            dgvTelefonos.TabIndex = 1;
            // 
            // colTelId
            // 
            colTelId.HeaderText = "Id";
            colTelId.Name = "colTelId";
            colTelId.ReadOnly = true;
            colTelId.Visible = false;
            // 
            // colTelefono
            // 
            colTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(420, 439);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 61);
            btnCancelar.TabIndex = 46;
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
            btnAceptar.Location = new Point(202, 439);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(189, 61);
            btnAceptar.TabIndex = 45;
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
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(1, 95, 168);
            tabPage2.Controls.Add(dgvDirecciones);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Direcciones";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregarDireccion);
            panel1.Controls.Add(btnBorrarDireccion);
            panel1.Controls.Add(btnEditarDireccion);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 287);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 93);
            panel1.TabIndex = 36;
            // 
            // btnAgregarDireccion
            // 
            btnAgregarDireccion.Location = new Point(14, 20);
            btnAgregarDireccion.Name = "btnAgregarDireccion";
            btnAgregarDireccion.Size = new Size(119, 54);
            btnAgregarDireccion.TabIndex = 35;
            btnAgregarDireccion.Text = "Agregar";
            btnAgregarDireccion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarDireccion.UseVisualStyleBackColor = true;
            btnAgregarDireccion.Click += btnAgregarDireccion_Click;
            // 
            // btnBorrarDireccion
            // 
            btnBorrarDireccion.Location = new Point(139, 20);
            btnBorrarDireccion.Name = "btnBorrarDireccion";
            btnBorrarDireccion.Size = new Size(119, 54);
            btnBorrarDireccion.TabIndex = 35;
            btnBorrarDireccion.Text = "Borrar";
            btnBorrarDireccion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrarDireccion.UseVisualStyleBackColor = true;
            btnBorrarDireccion.Click += btnBorrarDireccion_Click;
            // 
            // btnEditarDireccion
            // 
            btnEditarDireccion.Location = new Point(264, 20);
            btnEditarDireccion.Name = "btnEditarDireccion";
            btnEditarDireccion.Size = new Size(119, 54);
            btnEditarDireccion.TabIndex = 35;
            btnEditarDireccion.Text = "Editar";
            btnEditarDireccion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarDireccion.UseVisualStyleBackColor = true;
            btnEditarDireccion.Click += btnEditarDireccion_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(1, 95, 168);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtDocumento);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Cliente";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(252, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 1);
            panel4.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(252, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 1);
            panel3.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(252, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 1);
            panel2.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            label3.Location = new Point(150, 72);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 41;
            label3.Text = "Documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            label6.Location = new Point(150, 160);
            label6.Name = "label6";
            label6.Size = new Size(70, 18);
            label6.TabIndex = 40;
            label6.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            label4.Location = new Point(150, 117);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 40;
            label4.Text = "Apellido:";
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.FromArgb(1, 95, 168);
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Location = new Point(252, 72);
            txtDocumento.MaxLength = 8;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Direccion";
            txtDocumento.Size = new Size(148, 16);
            txtDocumento.TabIndex = 30;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(1, 95, 168);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(252, 117);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(412, 16);
            txtApellido.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(1, 95, 168);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(252, 160);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(412, 16);
            txtNombre.TabIndex = 31;
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tabPage1);
            tabCliente.Controls.Add(tabPage2);
            tabCliente.Controls.Add(Télefonos);
            tabCliente.Dock = DockStyle.Top;
            tabCliente.Location = new Point(0, 0);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(807, 411);
            tabCliente.TabIndex = 44;
            // 
            // Télefonos
            // 
            Télefonos.BackColor = Color.FromArgb(1, 95, 168);
            Télefonos.Controls.Add(dgvTelefonos);
            Télefonos.Controls.Add(panel5);
            Télefonos.Location = new Point(4, 24);
            Télefonos.Name = "Télefonos";
            Télefonos.Padding = new Padding(3);
            Télefonos.Size = new Size(799, 383);
            Télefonos.TabIndex = 2;
            Télefonos.Text = "Télefonos";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAgregarTelefono);
            panel5.Controls.Add(btnBorrarTelefono);
            panel5.Controls.Add(btnEditarTelefono);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 287);
            panel5.Name = "panel5";
            panel5.Size = new Size(793, 93);
            panel5.TabIndex = 37;
            // 
            // btnAgregarTelefono
            // 
            btnAgregarTelefono.Location = new Point(14, 20);
            btnAgregarTelefono.Name = "btnAgregarTelefono";
            btnAgregarTelefono.Size = new Size(119, 54);
            btnAgregarTelefono.TabIndex = 35;
            btnAgregarTelefono.Text = "Agregar";
            btnAgregarTelefono.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarTelefono.UseVisualStyleBackColor = true;
            btnAgregarTelefono.Click += btnAgregarTelefono_Click;
            // 
            // btnBorrarTelefono
            // 
            btnBorrarTelefono.Location = new Point(139, 20);
            btnBorrarTelefono.Name = "btnBorrarTelefono";
            btnBorrarTelefono.Size = new Size(119, 54);
            btnBorrarTelefono.TabIndex = 35;
            btnBorrarTelefono.Text = "Borrar";
            btnBorrarTelefono.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrarTelefono.UseVisualStyleBackColor = true;
            btnBorrarTelefono.Click += btnBorrarTelefono_Click;
            // 
            // btnEditarTelefono
            // 
            btnEditarTelefono.Location = new Point(264, 20);
            btnEditarTelefono.Name = "btnEditarTelefono";
            btnEditarTelefono.Size = new Size(119, 54);
            btnEditarTelefono.TabIndex = 35;
            btnEditarTelefono.Text = "Editar";
            btnEditarTelefono.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarTelefono.UseVisualStyleBackColor = true;
            btnEditarTelefono.Click += btnEditarTelefono_Click;
            // 
            // frmClienteAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 95, 168);
            ClientSize = new Size(807, 530);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tabCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClienteAE";
            Text = "frmClienteAE";
            Load += frmClienteAE_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDirecciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTelefonos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabCliente.ResumeLayout(false);
            Télefonos.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDirecciones;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridView dgvTelefonos;
        private DataGridViewTextBoxColumn colTelId;
        private DataGridViewTextBoxColumn colTelefono;
        private Button btnCancelar;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
        private TabControl tabCliente;
        private TabPage tabPage1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox txtDocumento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TabPage tabPage2;
        private Panel panel1;
        private Button btnAgregarDireccion;
        private Button btnBorrarDireccion;
        private Button btnEditarDireccion;
        private TabPage Télefonos;
        private Panel panel5;
        private Button btnAgregarTelefono;
        private Button btnBorrarTelefono;
        private Button btnEditarTelefono;
    }
}