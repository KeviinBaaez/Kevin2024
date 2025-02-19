namespace Kevin2024.Windows.Formularios
{
    partial class frmOrdenDelivery
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
            panelDireccion = new Panel();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            panelTelefono = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelDireccion
            // 
            panelDireccion.BackColor = Color.FromArgb(1, 95, 168);
            panelDireccion.Dock = DockStyle.Top;
            panelDireccion.Location = new Point(0, 0);
            panelDireccion.Name = "panelDireccion";
            panelDireccion.Size = new Size(824, 220);
            panelDireccion.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 95, 168);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnAceptar);
            panel2.Controls.Add(panelTelefono);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 208);
            panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(425, 156);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 48);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(207, 156);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(181, 48);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // panelTelefono
            // 
            panelTelefono.Location = new Point(216, 0);
            panelTelefono.Name = "panelTelefono";
            panelTelefono.Size = new Size(360, 143);
            panelTelefono.TabIndex = 0;
            // 
            // frmOrdenDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 428);
            Controls.Add(panel2);
            Controls.Add(panelDireccion);
            Name = "frmOrdenDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dirección y télefono";
            Load += frmOrdenDelivery_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDireccion;
        private Panel panel2;
        private Panel panelTelefono;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}