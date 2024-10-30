namespace Kevin2024.Windows.Formularios
{
    partial class frmTamaniosAE
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
            txtTamanio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            NudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Constantia", 12F);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(187, 142);
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
            btnOK.Font = new Font("Constantia", 12F);
            btnOK.Image = Properties.Resources.caja;
            btnOK.Location = new Point(12, 142);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(159, 50);
            btnOK.TabIndex = 8;
            btnOK.Text = "Aceptar";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtTamanio
            // 
            txtTamanio.Location = new Point(88, 58);
            txtTamanio.Name = "txtTamanio";
            txtTamanio.Size = new Size(223, 23);
            txtTamanio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 11);
            label2.Name = "label2";
            label2.Size = new Size(205, 29);
            label2.TabIndex = 6;
            label2.Text = "NUEVA TAMAÑO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 5;
            label1.Text = "Tamaño:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 5;
            label3.Text = "Cantidad:";
            // 
            // NudCantidad
            // 
            NudCantidad.DecimalPlaces = 2;
            NudCantidad.Location = new Point(88, 103);
            NudCantidad.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            NudCantidad.Name = "NudCantidad";
            NudCantidad.Size = new Size(223, 23);
            NudCantidad.TabIndex = 10;
            // 
            // frmTamaniosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 204);
            Controls.Add(NudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtTamanio);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmTamaniosAE";
            Text = "frmTamaniosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtTamanio;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        private NumericUpDown NudCantidad;
        private Label label3;
    }
}