namespace Kevin2024.Windows.Formularios
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            iniciarSeciónToolStripMenuItem = new ToolStripMenuItem();
            registrarmeToolStripMenuItem = new ToolStripMenuItem();
            cerrarSeciónToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 385);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 29);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO";
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 12F, FontStyle.Italic);
            button1.Location = new Point(178, 63);
            button1.Name = "button1";
            button1.Size = new Size(103, 238);
            button1.TabIndex = 0;
            button1.Text = "Nuestros Productos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 12F, FontStyle.Italic);
            button2.Location = new Point(374, 63);
            button2.Name = "button2";
            button2.Size = new Size(103, 238);
            button2.TabIndex = 0;
            button2.Text = "Combos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(576, 63);
            button3.Name = "button3";
            button3.Size = new Size(102, 238);
            button3.TabIndex = 0;
            button3.Text = "Realizar Una Órden";
            button3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(690, 9);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(87, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { iniciarSeciónToolStripMenuItem, registrarmeToolStripMenuItem, cerrarSeciónToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(75, 22);
            toolStripDropDownButton1.Text = "Mí Cuenta";
            toolStripDropDownButton1.TextAlign = ContentAlignment.MiddleRight;
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // iniciarSeciónToolStripMenuItem
            // 
            iniciarSeciónToolStripMenuItem.Name = "iniciarSeciónToolStripMenuItem";
            iniciarSeciónToolStripMenuItem.Size = new Size(180, 22);
            iniciarSeciónToolStripMenuItem.Text = "Iniciar Seción";
            // 
            // registrarmeToolStripMenuItem
            // 
            registrarmeToolStripMenuItem.Name = "registrarmeToolStripMenuItem";
            registrarmeToolStripMenuItem.Size = new Size(180, 22);
            registrarmeToolStripMenuItem.Text = "Registrarme";
            // 
            // cerrarSeciónToolStripMenuItem
            // 
            cerrarSeciónToolStripMenuItem.Name = "cerrarSeciónToolStripMenuItem";
            cerrarSeciónToolStripMenuItem.Size = new Size(180, 22);
            cerrarSeciónToolStripMenuItem.Text = "Cerrar Seción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCompras";
            Text = "frmCompras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem iniciarSeciónToolStripMenuItem;
        private ToolStripMenuItem registrarmeToolStripMenuItem;
        private ToolStripMenuItem cerrarSeciónToolStripMenuItem;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}