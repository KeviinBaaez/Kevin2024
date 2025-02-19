namespace Kevin2024.Windows.Formularios
{
    partial class frmEstadoPago
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
            label1 = new Label();
            btnAtras = new Button();
            panelFormaPago = new Panel();
            panelEfectivo = new Panel();
            txtDevuelvo = new TextBox();
            txtRecibo = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            cboFormaDePago = new ComboBox();
            label12 = new Label();
            panelTarjeta = new Panel();
            panel34 = new Panel();
            panel24 = new Panel();
            panel17 = new Panel();
            panel33 = new Panel();
            panel30 = new Panel();
            panel26 = new Panel();
            panel22 = new Panel();
            panel12 = new Panel();
            panel16 = new Panel();
            panel32 = new Panel();
            panel29 = new Panel();
            panel25 = new Panel();
            panel21 = new Panel();
            panel11 = new Panel();
            panel15 = new Panel();
            panel28 = new Panel();
            panel20 = new Panel();
            panel13 = new Panel();
            txtNombreApellido = new TextBox();
            panel14 = new Panel();
            txtAnio = new TextBox();
            txtDni = new TextBox();
            txtMes = new TextBox();
            panel27 = new Panel();
            panel31 = new Panel();
            txtCodigoSeguridad = new TextBox();
            panel23 = new Panel();
            txtNumero = new TextBox();
            panel18 = new Panel();
            label23 = new Label();
            label17 = new Label();
            label21 = new Label();
            panel19 = new Panel();
            label22 = new Label();
            label19 = new Label();
            label25 = new Label();
            label26 = new Label();
            label24 = new Label();
            label20 = new Label();
            label16 = new Label();
            label18 = new Label();
            label30 = new Label();
            label31 = new Label();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            lblOrdenNro = new Label();
            lblTotal = new Label();
            panelFormaPago.SuspendLayout();
            panelEfectivo.SuspendLayout();
            panelTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(200, 10, 0, 10);
            label1.Size = new Size(403, 53);
            label1.TabIndex = 6;
            label1.Text = "Estado de pago";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.White;
            btnAtras.Dock = DockStyle.Left;
            btnAtras.Image = Properties.Resources.angulo_pequeno_izquierdo__1_;
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(50, 515);
            btnAtras.TabIndex = 3;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // panelFormaPago
            // 
            panelFormaPago.Controls.Add(panelEfectivo);
            panelFormaPago.Controls.Add(cboFormaDePago);
            panelFormaPago.Controls.Add(label12);
            panelFormaPago.Dock = DockStyle.Top;
            panelFormaPago.Location = new Point(50, 53);
            panelFormaPago.Name = "panelFormaPago";
            panelFormaPago.Size = new Size(600, 84);
            panelFormaPago.TabIndex = 90;
            // 
            // panelEfectivo
            // 
            panelEfectivo.Controls.Add(txtDevuelvo);
            panelEfectivo.Controls.Add(txtRecibo);
            panelEfectivo.Controls.Add(label15);
            panelEfectivo.Controls.Add(label14);
            panelEfectivo.Controls.Add(label13);
            panelEfectivo.Location = new Point(221, 0);
            panelEfectivo.Name = "panelEfectivo";
            panelEfectivo.Size = new Size(348, 84);
            panelEfectivo.TabIndex = 87;
            // 
            // txtDevuelvo
            // 
            txtDevuelvo.Font = new Font("Arial Rounded MT Bold", 14.25F);
            txtDevuelvo.Location = new Point(185, 42);
            txtDevuelvo.Name = "txtDevuelvo";
            txtDevuelvo.ReadOnly = true;
            txtDevuelvo.Size = new Size(154, 29);
            txtDevuelvo.TabIndex = 0;
            // 
            // txtRecibo
            // 
            txtRecibo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecibo.Location = new Point(13, 42);
            txtRecibo.MaxLength = 10;
            txtRecibo.Name = "txtRecibo";
            txtRecibo.Size = new Size(147, 29);
            txtRecibo.TabIndex = 0;
            txtRecibo.TextChanged += txtRecibo_TextChanged;
            txtRecibo.KeyPress += txtRecibo_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(160, 38);
            label15.Name = "label15";
            label15.Size = new Size(25, 33);
            label15.TabIndex = 86;
            label15.Text = "|";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label14.Location = new Point(185, 20);
            label14.Name = "label14";
            label14.Size = new Size(86, 19);
            label14.TabIndex = 86;
            label14.Text = "Devuelvo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label13.Location = new Point(13, 17);
            label13.Name = "label13";
            label13.Size = new Size(83, 19);
            label13.TabIndex = 86;
            label13.Text = "Pagá con:";
            // 
            // cboFormaDePago
            // 
            cboFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaDePago.FormattingEnabled = true;
            cboFormaDePago.Location = new Point(15, 48);
            cboFormaDePago.Name = "cboFormaDePago";
            cboFormaDePago.Size = new Size(163, 23);
            cboFormaDePago.TabIndex = 0;
            cboFormaDePago.SelectedIndexChanged += cboFormaDePago_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label12.Location = new Point(15, 16);
            label12.Name = "label12";
            label12.Size = new Size(128, 19);
            label12.TabIndex = 86;
            label12.Text = "Forma de pago:";
            // 
            // panelTarjeta
            // 
            panelTarjeta.Controls.Add(panel34);
            panelTarjeta.Controls.Add(panel24);
            panelTarjeta.Controls.Add(panel17);
            panelTarjeta.Controls.Add(panel33);
            panelTarjeta.Controls.Add(panel30);
            panelTarjeta.Controls.Add(panel26);
            panelTarjeta.Controls.Add(panel22);
            panelTarjeta.Controls.Add(panel12);
            panelTarjeta.Controls.Add(panel16);
            panelTarjeta.Controls.Add(panel32);
            panelTarjeta.Controls.Add(panel29);
            panelTarjeta.Controls.Add(panel25);
            panelTarjeta.Controls.Add(panel21);
            panelTarjeta.Controls.Add(panel11);
            panelTarjeta.Controls.Add(panel15);
            panelTarjeta.Controls.Add(panel28);
            panelTarjeta.Controls.Add(panel20);
            panelTarjeta.Controls.Add(panel13);
            panelTarjeta.Controls.Add(txtNombreApellido);
            panelTarjeta.Controls.Add(panel14);
            panelTarjeta.Controls.Add(txtAnio);
            panelTarjeta.Controls.Add(txtDni);
            panelTarjeta.Controls.Add(txtMes);
            panelTarjeta.Controls.Add(panel27);
            panelTarjeta.Controls.Add(panel31);
            panelTarjeta.Controls.Add(txtCodigoSeguridad);
            panelTarjeta.Controls.Add(panel23);
            panelTarjeta.Controls.Add(txtNumero);
            panelTarjeta.Controls.Add(panel18);
            panelTarjeta.Controls.Add(label23);
            panelTarjeta.Controls.Add(label17);
            panelTarjeta.Controls.Add(label21);
            panelTarjeta.Controls.Add(panel19);
            panelTarjeta.Controls.Add(label22);
            panelTarjeta.Controls.Add(label19);
            panelTarjeta.Controls.Add(label25);
            panelTarjeta.Controls.Add(label26);
            panelTarjeta.Controls.Add(label24);
            panelTarjeta.Controls.Add(label20);
            panelTarjeta.Controls.Add(label16);
            panelTarjeta.Controls.Add(label18);
            panelTarjeta.Controls.Add(label30);
            panelTarjeta.Controls.Add(label31);
            panelTarjeta.Dock = DockStyle.Fill;
            panelTarjeta.Location = new Point(50, 137);
            panelTarjeta.Name = "panelTarjeta";
            panelTarjeta.Size = new Size(600, 378);
            panelTarjeta.TabIndex = 91;
            // 
            // panel34
            // 
            panel34.BackColor = Color.Black;
            panel34.Location = new Point(101, 187);
            panel34.Name = "panel34";
            panel34.Size = new Size(77, 1);
            panel34.TabIndex = 87;
            // 
            // panel24
            // 
            panel24.BackColor = Color.Black;
            panel24.Location = new Point(12, 187);
            panel24.Name = "panel24";
            panel24.Size = new Size(77, 1);
            panel24.TabIndex = 87;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Black;
            panel17.Location = new Point(12, 101);
            panel17.Name = "panel17";
            panel17.Size = new Size(1, 29);
            panel17.TabIndex = 87;
            // 
            // panel33
            // 
            panel33.BackColor = Color.Black;
            panel33.Location = new Point(101, 187);
            panel33.Name = "panel33";
            panel33.Size = new Size(1, 29);
            panel33.TabIndex = 87;
            // 
            // panel30
            // 
            panel30.BackColor = Color.Black;
            panel30.Location = new Point(12, 278);
            panel30.Name = "panel30";
            panel30.Size = new Size(1, 29);
            panel30.TabIndex = 87;
            // 
            // panel26
            // 
            panel26.BackColor = Color.Black;
            panel26.Location = new Point(12, 187);
            panel26.Name = "panel26";
            panel26.Size = new Size(1, 29);
            panel26.TabIndex = 87;
            // 
            // panel22
            // 
            panel22.BackColor = Color.Black;
            panel22.Location = new Point(284, 187);
            panel22.Name = "panel22";
            panel22.Size = new Size(1, 29);
            panel22.TabIndex = 87;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Location = new Point(12, 41);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 29);
            panel12.TabIndex = 87;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Location = new Point(261, 101);
            panel16.Name = "panel16";
            panel16.Size = new Size(1, 29);
            panel16.TabIndex = 87;
            // 
            // panel32
            // 
            panel32.BackColor = Color.Black;
            panel32.Location = new Point(177, 188);
            panel32.Name = "panel32";
            panel32.Size = new Size(1, 28);
            panel32.TabIndex = 87;
            // 
            // panel29
            // 
            panel29.BackColor = Color.Black;
            panel29.Location = new Point(261, 278);
            panel29.Name = "panel29";
            panel29.Size = new Size(1, 29);
            panel29.TabIndex = 87;
            // 
            // panel25
            // 
            panel25.BackColor = Color.Black;
            panel25.Location = new Point(88, 188);
            panel25.Name = "panel25";
            panel25.Size = new Size(1, 28);
            panel25.TabIndex = 87;
            // 
            // panel21
            // 
            panel21.BackColor = Color.Black;
            panel21.Location = new Point(533, 187);
            panel21.Name = "panel21";
            panel21.Size = new Size(1, 29);
            panel21.TabIndex = 87;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(261, 41);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 29);
            panel11.TabIndex = 87;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Location = new Point(12, 101);
            panel15.Name = "panel15";
            panel15.Size = new Size(249, 1);
            panel15.TabIndex = 87;
            // 
            // panel28
            // 
            panel28.BackColor = Color.Black;
            panel28.Location = new Point(12, 278);
            panel28.Name = "panel28";
            panel28.Size = new Size(249, 1);
            panel28.TabIndex = 87;
            // 
            // panel20
            // 
            panel20.BackColor = Color.Black;
            panel20.Location = new Point(284, 187);
            panel20.Name = "panel20";
            panel20.Size = new Size(249, 1);
            panel20.TabIndex = 87;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Location = new Point(12, 41);
            panel13.Name = "panel13";
            panel13.Size = new Size(249, 1);
            panel13.TabIndex = 87;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.BackColor = Color.FromArgb(1, 95, 168);
            txtNombreApellido.BorderStyle = BorderStyle.None;
            txtNombreApellido.Font = new Font("Constantia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreApellido.Location = new Point(16, 107);
            txtNombreApellido.MaxLength = 65;
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(243, 21);
            txtNombreApellido.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Location = new Point(12, 129);
            panel14.Name = "panel14";
            panel14.Size = new Size(249, 1);
            panel14.TabIndex = 87;
            // 
            // txtAnio
            // 
            txtAnio.BackColor = Color.FromArgb(1, 95, 168);
            txtAnio.BorderStyle = BorderStyle.None;
            txtAnio.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnio.Location = new Point(104, 188);
            txtAnio.MaxLength = 2;
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(73, 25);
            txtAnio.TabIndex = 4;
            txtAnio.TextAlign = HorizontalAlignment.Center;
            txtAnio.TextChanged += txtAnio_TextChanged;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(1, 95, 168);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDni.Location = new Point(16, 279);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(246, 25);
            txtDni.TabIndex = 88;
            txtDni.KeyPress += txtNumero_KeyPress;
            // 
            // txtMes
            // 
            txtMes.BackColor = Color.FromArgb(1, 95, 168);
            txtMes.BorderStyle = BorderStyle.None;
            txtMes.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMes.Location = new Point(15, 188);
            txtMes.MaxLength = 2;
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(73, 25);
            txtMes.TabIndex = 3;
            txtMes.TextAlign = HorizontalAlignment.Center;
            txtMes.TextChanged += txtFechaVto_TextChanged;
            txtMes.KeyDown += txtMes_KeyDown;
            txtMes.KeyPress += txtFechaVto_KeyPress;
            // 
            // panel27
            // 
            panel27.BackColor = Color.Black;
            panel27.Location = new Point(12, 306);
            panel27.Name = "panel27";
            panel27.Size = new Size(249, 1);
            panel27.TabIndex = 87;
            // 
            // panel31
            // 
            panel31.BackColor = Color.Black;
            panel31.Location = new Point(101, 215);
            panel31.Name = "panel31";
            panel31.Size = new Size(77, 1);
            panel31.TabIndex = 87;
            // 
            // txtCodigoSeguridad
            // 
            txtCodigoSeguridad.BackColor = Color.FromArgb(1, 95, 168);
            txtCodigoSeguridad.BorderStyle = BorderStyle.None;
            txtCodigoSeguridad.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoSeguridad.Location = new Point(287, 187);
            txtCodigoSeguridad.MaxLength = 3;
            txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            txtCodigoSeguridad.Size = new Size(246, 25);
            txtCodigoSeguridad.TabIndex = 88;
            txtCodigoSeguridad.KeyPress += txtNumero_KeyPress;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Black;
            panel23.Location = new Point(12, 215);
            panel23.Name = "panel23";
            panel23.Size = new Size(77, 1);
            panel23.TabIndex = 87;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(1, 95, 168);
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(16, 44);
            txtNumero.MaxLength = 19;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(246, 25);
            txtNumero.TabIndex = 1;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Black;
            panel18.Location = new Point(284, 215);
            panel18.Name = "panel18";
            panel18.Size = new Size(249, 1);
            panel18.TabIndex = 87;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label23.Location = new Point(152, 256);
            label23.Name = "label23";
            label23.Size = new Size(0, 19);
            label23.TabIndex = 80;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label17.Location = new Point(152, 79);
            label17.Name = "label17";
            label17.Size = new Size(0, 19);
            label17.TabIndex = 80;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label21.Location = new Point(152, 165);
            label21.Name = "label21";
            label21.Size = new Size(0, 19);
            label21.TabIndex = 80;
            // 
            // panel19
            // 
            panel19.BackColor = Color.Black;
            panel19.Location = new Point(12, 69);
            panel19.Name = "panel19";
            panel19.Size = new Size(249, 1);
            panel19.TabIndex = 87;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label22.Location = new Point(12, 256);
            label22.Name = "label22";
            label22.Size = new Size(215, 19);
            label22.TabIndex = 80;
            label22.Text = "DNI del titular de la tarjeta";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label19.Location = new Point(424, 165);
            label19.Name = "label19";
            label19.Size = new Size(0, 19);
            label19.TabIndex = 80;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.GrayText;
            label25.Location = new Point(284, 219);
            label25.Name = "label25";
            label25.Size = new Size(38, 18);
            label25.TabIndex = 80;
            label25.Text = "CVV";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.GrayText;
            label26.Location = new Point(13, 133);
            label26.Name = "label26";
            label26.Size = new Size(174, 18);
            label26.TabIndex = 80;
            label26.Text = "Como figura en la tarjeta.";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.GrayText;
            label24.Location = new Point(13, 219);
            label24.Name = "label24";
            label24.Size = new Size(120, 18);
            label24.TabIndex = 80;
            label24.Text = "Mes            / Año";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label20.Location = new Point(12, 165);
            label20.Name = "label20";
            label20.Size = new Size(175, 19);
            label20.TabIndex = 80;
            label20.Text = "Fecha de vencimiento";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label16.Location = new Point(12, 79);
            label16.Name = "label16";
            label16.Size = new Size(151, 19);
            label16.TabIndex = 80;
            label16.Text = "Nombre y apellido";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label18.Location = new Point(284, 165);
            label18.Name = "label18";
            label18.Size = new Size(167, 19);
            label18.TabIndex = 80;
            label18.Text = "Código de seguridad";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label30.Location = new Point(152, 19);
            label30.Name = "label30";
            label30.Size = new Size(0, 19);
            label30.TabIndex = 80;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label31.Location = new Point(12, 19);
            label31.Name = "label31";
            label31.Size = new Size(150, 19);
            label31.TabIndex = 80;
            label31.Text = "Número de tarjeta";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(68, 182, 120);
            btnAceptar.Dock = DockStyle.Bottom;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAceptar.Image = Properties.Resources.caja;
            btnAceptar.Location = new Point(50, 453);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(600, 62);
            btnAceptar.TabIndex = 92;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 93;
            label2.Text = "Nro. órden:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 35);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 93;
            label3.Text = "Total:";
            // 
            // lblOrdenNro
            // 
            lblOrdenNro.AutoSize = true;
            lblOrdenNro.Location = new Point(126, 9);
            lblOrdenNro.Name = "lblOrdenNro";
            lblOrdenNro.Size = new Size(0, 15);
            lblOrdenNro.TabIndex = 93;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(91, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 93;
            // 
            // frmEstadoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 95, 168);
            ClientSize = new Size(650, 515);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(lblOrdenNro);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(panelTarjeta);
            Controls.Add(panelFormaPago);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEstadoPago";
            Text = "frmEstadoPago";
            Load += frmEstadoPago_Load;
            panelFormaPago.ResumeLayout(false);
            panelFormaPago.PerformLayout();
            panelEfectivo.ResumeLayout(false);
            panelEfectivo.PerformLayout();
            panelTarjeta.ResumeLayout(false);
            panelTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAtras;
        private Panel panelFormaPago;
        private Panel panelEfectivo;
        private TextBox txtDevuelvo;
        private TextBox txtRecibo;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox cboFormaDePago;
        private Label label12;
        private Panel panelTarjeta;
        private Panel panel34;
        private Panel panel24;
        private Panel panel17;
        private Panel panel33;
        private Panel panel30;
        private Panel panel26;
        private Panel panel22;
        private Panel panel12;
        private Panel panel16;
        private Panel panel32;
        private Panel panel29;
        private Panel panel25;
        private Panel panel21;
        private Panel panel11;
        private Panel panel15;
        private Panel panel28;
        private Panel panel20;
        private Panel panel13;
        private TextBox txtNombreApellido;
        private Panel panel14;
        private TextBox txtAnio;
        private TextBox txtDni;
        private TextBox txtMes;
        private Panel panel27;
        private Panel panel31;
        private TextBox txtCodigoSeguridad;
        private Panel panel23;
        private TextBox txtNumero;
        private Panel panel18;
        private Label label23;
        private Label label17;
        private Label label21;
        private Panel panel19;
        private Label label22;
        private Label label19;
        private Label label25;
        private Label label26;
        private Label label24;
        private Label label20;
        private Label label16;
        private Label label18;
        private Label label30;
        private Label label31;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label2;
        private Label lblTotal;
        private Label lblOrdenNro;
    }
}