namespace Kevin2024.Windows.Formularios
{
    partial class frmMenuPrincipal
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
            btnMarcas = new Button();
            btnBebidas = new Button();
            btnTamanio = new Button();
            btnPostres = new Button();
            brnCategoria = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(23, 21);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(169, 74);
            btnMarcas.TabIndex = 0;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // btnBebidas
            // 
            btnBebidas.Location = new Point(210, 21);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(168, 74);
            btnBebidas.TabIndex = 1;
            btnBebidas.Text = "Bebidas";
            btnBebidas.UseVisualStyleBackColor = true;
            btnBebidas.Click += btnBebidas_Click;
            // 
            // btnTamanio
            // 
            btnTamanio.Location = new Point(23, 120);
            btnTamanio.Name = "btnTamanio";
            btnTamanio.Size = new Size(168, 71);
            btnTamanio.TabIndex = 2;
            btnTamanio.Text = "Tamaños";
            btnTamanio.UseVisualStyleBackColor = true;
            btnTamanio.Click += btnTamanio_Click;
            // 
            // btnPostres
            // 
            btnPostres.Location = new Point(210, 120);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(168, 71);
            btnPostres.TabIndex = 3;
            btnPostres.Text = "Postres";
            btnPostres.UseVisualStyleBackColor = true;
            btnPostres.Click += btnPostres_Click;
            // 
            // brnCategoria
            // 
            brnCategoria.Location = new Point(384, 21);
            brnCategoria.Name = "brnCategoria";
            brnCategoria.Size = new Size(168, 74);
            brnCategoria.TabIndex = 4;
            brnCategoria.Text = "Categorias";
            brnCategoria.UseVisualStyleBackColor = true;
            brnCategoria.Click += brnCategoria_Click;
            // 
            // button1
            // 
            button1.Location = new Point(384, 117);
            button1.Name = "button1";
            button1.Size = new Size(168, 74);
            button1.TabIndex = 4;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(brnCategoria);
            Controls.Add(btnPostres);
            Controls.Add(btnTamanio);
            Controls.Add(btnBebidas);
            Controls.Add(btnMarcas);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMarcas;
        private Button btnBebidas;
        private Button btnTamanio;
        private Button btnPostres;
        private Button brnCategoria;
        private Button button1;
    }
}