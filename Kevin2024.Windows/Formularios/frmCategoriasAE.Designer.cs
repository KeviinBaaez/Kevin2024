namespace Kevin2024.Windows.Formularios
{
    partial class frmCategoriasAE
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
            btnCancelar = new Button();
            btnOK = new Button();
            txtCategoria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(187, 98);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 50);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnOK.Image = Properties.Resources.caja;
            btnOK.Location = new Point(12, 98);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(159, 50);
            btnOK.TabIndex = 8;
            btnOK.Text = "Aceptar";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(99, 48);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(175, 23);
            txtCategoria.TabIndex = 7;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(331, 39);
            label2.TabIndex = 6;
            label2.Text = "NUEVA CATEGORIA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 5;
            label1.Text = "Categoria:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCategoriasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 169);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategoriasAE";
            Text = "frmCategoriasAE";
            Load += frmCategoriasAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtCategoria;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}