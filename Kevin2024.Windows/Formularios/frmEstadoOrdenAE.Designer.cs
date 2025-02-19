namespace Kevin2024.Windows.Formularios
{
    partial class frmEstadoOrdenAE
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
            btnAtras = new Button();
            btnCancelar = new Button();
            btnPendiente = new Button();
            btnEnviado = new Button();
            btnCompletado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.White;
            btnAtras.Dock = DockStyle.Left;
            btnAtras.Image = Properties.Resources.angulo_pequeno_izquierdo__1_;
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(50, 158);
            btnAtras.TabIndex = 0;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(66, 78);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 60);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPendiente
            // 
            btnPendiente.BackColor = Color.FromArgb(255, 255, 192);
            btnPendiente.FlatStyle = FlatStyle.Flat;
            btnPendiente.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendiente.Location = new Point(239, 78);
            btnPendiente.Name = "btnPendiente";
            btnPendiente.Size = new Size(157, 60);
            btnPendiente.TabIndex = 1;
            btnPendiente.Text = "PENDIENTE";
            btnPendiente.UseVisualStyleBackColor = false;
            btnPendiente.Click += btnPendiente_Click;
            // 
            // btnEnviado
            // 
            btnEnviado.BackColor = Color.FromArgb(192, 255, 192);
            btnEnviado.FlatStyle = FlatStyle.Flat;
            btnEnviado.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviado.Location = new Point(412, 78);
            btnEnviado.Name = "btnEnviado";
            btnEnviado.Size = new Size(157, 60);
            btnEnviado.TabIndex = 1;
            btnEnviado.Text = "ENVIADO";
            btnEnviado.UseVisualStyleBackColor = false;
            btnEnviado.Click += btnEnviado_Click;
            // 
            // btnCompletado
            // 
            btnCompletado.BackColor = Color.FromArgb(128, 255, 128);
            btnCompletado.FlatStyle = FlatStyle.Flat;
            btnCompletado.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompletado.Location = new Point(587, 78);
            btnCompletado.Name = "btnCompletado";
            btnCompletado.Size = new Size(157, 60);
            btnCompletado.TabIndex = 1;
            btnCompletado.Text = "COMPLETADO";
            btnCompletado.UseVisualStyleBackColor = false;
            btnCompletado.Click += btnCompletado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 33);
            label1.TabIndex = 2;
            label1.Text = "Estado de órden";
            // 
            // frmEstadoOrdenAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 95, 168);
            ClientSize = new Size(759, 158);
            Controls.Add(label1);
            Controls.Add(btnCompletado);
            Controls.Add(btnEnviado);
            Controls.Add(btnPendiente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEstadoOrdenAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEstadoOrdenAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Button btnCancelar;
        private Button btnPendiente;
        private Button btnEnviado;
        private Button btnCompletado;
        private Label label1;
    }
}