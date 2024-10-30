namespace Kevin2024.Windows.Formularios
{
    partial class frmIngredientes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnNuevo = new Button();
            dgvDatos = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColIngrediente = new DataGridViewTextBoxColumn();
            ConSuspendido = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 467);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.LemonChiffon;
            button4.Location = new Point(53, 397);
            button4.Name = "button4";
            button4.Size = new Size(87, 41);
            button4.TabIndex = 0;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.LemonChiffon;
            button3.Location = new Point(12, 253);
            button3.Name = "button3";
            button3.Size = new Size(177, 41);
            button3.TabIndex = 0;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LemonChiffon;
            button2.Location = new Point(12, 182);
            button2.Name = "button2";
            button2.Size = new Size(177, 41);
            button2.TabIndex = 0;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LemonChiffon;
            button1.Location = new Point(12, 113);
            button1.Name = "button1";
            button1.Size = new Size(177, 41);
            button1.TabIndex = 0;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.OrangeRed;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.LemonChiffon;
            btnNuevo.Location = new Point(12, 43);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(177, 41);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Agregar Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.BackgroundColor = Color.Brown;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCoral;
            dataGridViewCellStyle2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.ColumnHeadersHeight = 30;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColId, ColIngrediente, ConSuspendido });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = SystemColors.Highlight;
            dgvDatos.Location = new Point(209, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.LightCoral;
            dataGridViewCellStyle6.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(415, 467);
            dgvDatos.TabIndex = 1;
            // 
            // ColId
            // 
            ColId.HeaderText = "id";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // ColIngrediente
            // 
            ColIngrediente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.Gold;
            dataGridViewCellStyle3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            ColIngrediente.DefaultCellStyle = dataGridViewCellStyle3;
            ColIngrediente.HeaderText = "Ingrediente";
            ColIngrediente.Name = "ColIngrediente";
            ColIngrediente.ReadOnly = true;
            // 
            // ConSuspendido
            // 
            ConSuspendido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ConSuspendido.HeaderText = "Suspendido";
            ConSuspendido.Name = "ConSuspendido";
            ConSuspendido.ReadOnly = true;
            ConSuspendido.Resizable = DataGridViewTriState.True;
            ConSuspendido.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmIngredientes
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(624, 467);
            Controls.Add(dgvDatos);
            Controls.Add(panel1);
            Name = "frmIngredientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingredientes";
            Load += frmIngredientes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnNuevo;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColIngrediente;
        private DataGridViewCheckBoxColumn ConSuspendido;
    }
}