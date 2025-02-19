namespace Kevin2024.Windows.UsersControls
{
    partial class ucProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picImagenProducto = new PictureBox();
            lblNombreProducto = new Label();
            lblPrecioProducto = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagenProducto).BeginInit();
            SuspendLayout();
            // 
            // picImagenProducto
            // 
            picImagenProducto.Location = new Point(24, 15);
            picImagenProducto.Name = "picImagenProducto";
            picImagenProducto.Size = new Size(103, 83);
            picImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagenProducto.TabIndex = 0;
            picImagenProducto.TabStop = false;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProducto.ForeColor = Color.Blue;
            lblNombreProducto.Location = new Point(0, 117);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(150, 23);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "label1";
            lblNombreProducto.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioProducto.ForeColor = Color.DodgerBlue;
            lblPrecioProducto.Location = new Point(-3, 140);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(150, 23);
            lblPrecioProducto.TabIndex = 1;
            lblPrecioProducto.Text = "label1";
            lblPrecioProducto.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 128, 255);
            btnAgregar.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.mas;
            btnAgregar.Location = new Point(24, 166);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 41);
            btnAgregar.TabIndex = 2;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // ucProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAgregar);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(picImagenProducto);
            Name = "ucProducto";
            Size = new Size(150, 222);
            ((System.ComponentModel.ISupportInitialize)picImagenProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImagenProducto;
        private Label lblNombreProducto;
        private Label lblPrecioProducto;
        public Button btnAgregar;
    }
}
