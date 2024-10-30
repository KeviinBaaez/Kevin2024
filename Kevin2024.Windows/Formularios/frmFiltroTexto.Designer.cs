namespace Kevin2024.Windows.Formularios
{
    partial class frmFiltroTexto
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
            txtTexto = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(45, 30);
            txtTexto.Margin = new Padding(4);
            txtTexto.MaximumSize = new Size(244, 26);
            txtTexto.MinimumSize = new Size(244, 26);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(244, 26);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "Escriba para buscar..";
            txtTexto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(192, 85);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 46);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(12, 85);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(161, 46);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmFiltroTexto
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 145);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtTexto);
            Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmFiltroTexto";
            Text = "frmFiltroTexto";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private Button btnCancelar;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
    }
}