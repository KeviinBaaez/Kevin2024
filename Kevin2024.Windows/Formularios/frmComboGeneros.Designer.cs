namespace Kevin2024.Windows.Formularios
{
    partial class frmComboGeneros
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
            panel1 = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboGeneros = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 103);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 55);
            panel1.TabIndex = 3;
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
            // cboGeneros
            // 
            cboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGeneros.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGeneros.FormattingEnabled = true;
            cboGeneros.Location = new Point(56, 34);
            cboGeneros.Name = "cboGeneros";
            cboGeneros.Size = new Size(259, 27);
            cboGeneros.TabIndex = 4;
            // 
            // frmComboGeneros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 103);
            ClientSize = new Size(371, 158);
            Controls.Add(cboGeneros);
            Controls.Add(panel1);
            Name = "frmComboGeneros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmComboGeneros";
            Load += frmComboGeneros_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboGeneros;
    }
}