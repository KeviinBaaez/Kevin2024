namespace Kevin2024.Windows.Formularios
{
    partial class frmTomarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTomarOrden));
            btnCancelar = new Button();
            btnAceptar = new Button();
            panel1 = new Panel();
            btnTakeAway = new Button();
            btnDelivery = new Button();
            btnLocal = new Button();
            cboClientes = new ComboBox();
            label2 = new Label();
            panelDelivery = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel10 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            lblDepto = new Label();
            label11 = new Label();
            lblPiso = new Label();
            label10 = new Label();
            lblAltura = new Label();
            label7 = new Label();
            lblEntre2 = new Label();
            lblEntre = new Label();
            label9 = new Label();
            label8 = new Label();
            lblTelefono = new Label();
            lblCalle = new Label();
            label6 = new Label();
            label4 = new Label();
            lbltipoDireccion = new Label();
            label3 = new Label();
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            lblTipoOrden = new Label();
            panel9 = new Panel();
            panelPrincipal = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panelDelivery.SuspendLayout();
            panelFormaPago.SuspendLayout();
            panelEfectivo.SuspendLayout();
            panelTarjeta.SuspendLayout();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.FromArgb(244, 0, 43);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.circulo_marca_x;
            btnCancelar.Location = new Point(323, 485);
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
            btnAceptar.Location = new Point(105, 485);
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
            // panel1
            // 
            panel1.Controls.Add(btnTakeAway);
            panel1.Controls.Add(btnDelivery);
            panel1.Controls.Add(btnLocal);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 78);
            panel1.TabIndex = 23;
            // 
            // btnTakeAway
            // 
            btnTakeAway.Dock = DockStyle.Fill;
            btnTakeAway.FlatStyle = FlatStyle.Flat;
            btnTakeAway.Font = new Font("Constantia", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnTakeAway.Image = (Image)resources.GetObject("btnTakeAway.Image");
            btnTakeAway.ImageAlign = ContentAlignment.TopCenter;
            btnTakeAway.Location = new Point(191, 0);
            btnTakeAway.Margin = new Padding(3, 30, 3, 3);
            btnTakeAway.Name = "btnTakeAway";
            btnTakeAway.Size = new Size(782, 78);
            btnTakeAway.TabIndex = 3;
            btnTakeAway.Text = "Take Away";
            btnTakeAway.TextAlign = ContentAlignment.BottomCenter;
            btnTakeAway.UseVisualStyleBackColor = true;
            btnTakeAway.Click += btnTakeAway_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.Dock = DockStyle.Right;
            btnDelivery.FlatStyle = FlatStyle.Flat;
            btnDelivery.Font = new Font("Constantia", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnDelivery.Image = (Image)resources.GetObject("btnDelivery.Image");
            btnDelivery.ImageAlign = ContentAlignment.TopCenter;
            btnDelivery.Location = new Point(973, 0);
            btnDelivery.Margin = new Padding(3, 30, 3, 3);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(191, 78);
            btnDelivery.TabIndex = 3;
            btnDelivery.Text = "Delivery";
            btnDelivery.TextAlign = ContentAlignment.BottomCenter;
            btnDelivery.UseVisualStyleBackColor = true;
            btnDelivery.Click += btnDelivery_Click;
            // 
            // btnLocal
            // 
            btnLocal.Dock = DockStyle.Left;
            btnLocal.FlatStyle = FlatStyle.Flat;
            btnLocal.Font = new Font("Constantia", 12.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLocal.Image = (Image)resources.GetObject("btnLocal.Image");
            btnLocal.ImageAlign = ContentAlignment.TopCenter;
            btnLocal.Location = new Point(0, 0);
            btnLocal.Margin = new Padding(3, 30, 3, 3);
            btnLocal.Name = "btnLocal";
            btnLocal.Size = new Size(191, 78);
            btnLocal.TabIndex = 3;
            btnLocal.Text = "Local";
            btnLocal.TextAlign = ContentAlignment.BottomCenter;
            btnLocal.UseVisualStyleBackColor = true;
            btnLocal.Click += btnLocal_Click;
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(177, 60);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(331, 23);
            cboClientes.TabIndex = 0;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 60);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 22;
            label2.Text = "Cliente:";
            // 
            // panelDelivery
            // 
            panelDelivery.Controls.Add(panel8);
            panelDelivery.Controls.Add(panel7);
            panelDelivery.Controls.Add(panel6);
            panelDelivery.Controls.Add(panel5);
            panelDelivery.Controls.Add(panel4);
            panelDelivery.Controls.Add(panel10);
            panelDelivery.Controls.Add(panel3);
            panelDelivery.Controls.Add(panel2);
            panelDelivery.Controls.Add(lblDepto);
            panelDelivery.Controls.Add(label11);
            panelDelivery.Controls.Add(lblPiso);
            panelDelivery.Controls.Add(label10);
            panelDelivery.Controls.Add(lblAltura);
            panelDelivery.Controls.Add(label7);
            panelDelivery.Controls.Add(lblEntre2);
            panelDelivery.Controls.Add(lblEntre);
            panelDelivery.Controls.Add(label9);
            panelDelivery.Controls.Add(label8);
            panelDelivery.Controls.Add(lblTelefono);
            panelDelivery.Controls.Add(lblCalle);
            panelDelivery.Controls.Add(label6);
            panelDelivery.Controls.Add(label4);
            panelDelivery.Controls.Add(lbltipoDireccion);
            panelDelivery.Controls.Add(label3);
            panelDelivery.Location = new Point(3, 142);
            panelDelivery.Name = "panelDelivery";
            panelDelivery.Size = new Size(569, 233);
            panelDelivery.TabIndex = 24;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(400, 173);
            panel8.Name = "panel8";
            panel8.Size = new Size(100, 1);
            panel8.TabIndex = 87;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(174, 173);
            panel7.Name = "panel7";
            panel7.Size = new Size(100, 1);
            panel7.TabIndex = 87;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(445, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(100, 1);
            panel6.TabIndex = 87;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(87, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 1);
            panel5.TabIndex = 87;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(87, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 87;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(106, 220);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 1);
            panel10.TabIndex = 87;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(87, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 87;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(152, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 87;
            // 
            // lblDepto
            // 
            lblDepto.AutoSize = true;
            lblDepto.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblDepto.Location = new Point(396, 155);
            lblDepto.Name = "lblDepto";
            lblDepto.Size = new Size(0, 19);
            lblDepto.TabIndex = 82;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label11.Location = new Point(326, 155);
            label11.Name = "label11";
            label11.Size = new Size(62, 19);
            label11.TabIndex = 82;
            label11.Text = "Depto:";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblPiso.Location = new Point(174, 155);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(0, 19);
            lblPiso.TabIndex = 81;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label10.Location = new Point(114, 155);
            label10.Name = "label10";
            label10.Size = new Size(46, 19);
            label10.TabIndex = 81;
            label10.Text = "Piso:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblAltura.Location = new Point(445, 50);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(0, 19);
            lblAltura.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label7.Location = new Point(361, 50);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 85;
            label7.Text = "Altura:";
            // 
            // lblEntre2
            // 
            lblEntre2.AutoSize = true;
            lblEntre2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblEntre2.Location = new Point(87, 116);
            lblEntre2.Name = "lblEntre2";
            lblEntre2.Size = new Size(0, 19);
            lblEntre2.TabIndex = 84;
            // 
            // lblEntre
            // 
            lblEntre.AutoSize = true;
            lblEntre.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblEntre.Location = new Point(87, 83);
            lblEntre.Name = "lblEntre";
            lblEntre.Size = new Size(0, 19);
            lblEntre.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label9.Location = new Point(12, 120);
            label9.Name = "label9";
            label9.Size = new Size(23, 19);
            label9.TabIndex = 84;
            label9.Text = "Y:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label8.Location = new Point(11, 83);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 83;
            label8.Text = "Entre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblTelefono.Location = new Point(106, 202);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(0, 19);
            lblTelefono.TabIndex = 86;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblCalle.Location = new Point(87, 50);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(0, 19);
            lblCalle.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 202);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 86;
            label6.Text = "Télefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 86;
            label4.Text = "Calle:";
            // 
            // lbltipoDireccion
            // 
            lbltipoDireccion.AutoSize = true;
            lbltipoDireccion.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lbltipoDireccion.Location = new Point(152, 15);
            lbltipoDireccion.Name = "lbltipoDireccion";
            lbltipoDireccion.Size = new Size(0, 19);
            lbltipoDireccion.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(128, 19);
            label3.TabIndex = 80;
            label3.Text = "Tipo Dirección:";
            // 
            // panelFormaPago
            // 
            panelFormaPago.Controls.Add(panelEfectivo);
            panelFormaPago.Controls.Add(cboFormaDePago);
            panelFormaPago.Controls.Add(label12);
            panelFormaPago.Location = new Point(3, 381);
            panelFormaPago.Name = "panelFormaPago";
            panelFormaPago.Size = new Size(569, 84);
            panelFormaPago.TabIndex = 89;
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
            panelTarjeta.Location = new Point(578, 142);
            panelTarjeta.Name = "panelTarjeta";
            panelTarjeta.Size = new Size(560, 323);
            panelTarjeta.TabIndex = 24;
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
            txtAnio.KeyPress += txtFechaVto_KeyPress;
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
            // label1
            // 
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 110);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 22;
            label1.Text = "Régalo:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(177, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 25;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label5.Location = new Point(90, 10);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 80;
            label5.Text = "Tipo Órden:";
            // 
            // lblTipoOrden
            // 
            lblTipoOrden.AutoSize = true;
            lblTipoOrden.Font = new Font("Constantia", 12F, FontStyle.Bold);
            lblTipoOrden.Location = new Point(230, 10);
            lblTipoOrden.Name = "lblTipoOrden";
            lblTipoOrden.Size = new Size(0, 19);
            lblTipoOrden.TabIndex = 80;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(230, 32);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 1);
            panel9.TabIndex = 87;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(btnCancelar);
            panelPrincipal.Controls.Add(btnAceptar);
            panelPrincipal.Controls.Add(panelFormaPago);
            panelPrincipal.Controls.Add(panelTarjeta);
            panelPrincipal.Controls.Add(checkBox1);
            panelPrincipal.Controls.Add(lblTipoOrden);
            panelPrincipal.Controls.Add(panelDelivery);
            panelPrincipal.Controls.Add(label5);
            panelPrincipal.Controls.Add(cboClientes);
            panelPrincipal.Controls.Add(panel9);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 78);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1164, 547);
            panelPrincipal.TabIndex = 88;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTomarOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(1, 95, 168);
            ClientSize = new Size(1164, 625);
            Controls.Add(panelPrincipal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTomarOrden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTomarOrden";
            Load += frmTomarOrden_Load;
            panel1.ResumeLayout(false);
            panelDelivery.ResumeLayout(false);
            panelDelivery.PerformLayout();
            panelFormaPago.ResumeLayout(false);
            panelFormaPago.PerformLayout();
            panelEfectivo.ResumeLayout(false);
            panelEfectivo.PerformLayout();
            panelTarjeta.ResumeLayout(false);
            panelTarjeta.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Panel panel1;
        private Button btnTakeAway;
        private Button btnDelivery;
        private Button btnLocal;
        private ComboBox cboClientes;
        private Label label2;
        private Panel panelDelivery;
        private Label label1;
        private CheckBox checkBox1;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label4;
        private TextBox txtDepto;
        private TextBox txtPiso;
        private Label label3;
        private Label lblAltura;
        private Label lblCalle;
        private Label lbltipoDireccion;
        private Label lblDepto;
        private Label lblPiso;
        private Label lblEntre2;
        private Label lblEntre;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label5;
        private Label lblTipoOrden;
        private Panel panel9;
        private Panel panelPrincipal;
        private Panel panel10;
        private Label lblTelefono;
        private Label label6;
        private Panel panelFormaPago;
        private Panel panelEfectivo;
        private TextBox txtDevuelvo;
        private TextBox txtRecibo;
        private Label label14;
        private Label label13;
        private ComboBox cboFormaDePago;
        private Label label12;
        private Label label15;
        private Panel panelTarjeta;
        private TextBox txtNumero;
        private Panel panel19;
        private Label label30;
        private Label label31;
        private Panel panel11;
        private Panel panel13;
        private Panel panel12;
        private Panel panel17;
        private Panel panel30;
        private Panel panel26;
        private Panel panel22;
        private Panel panel16;
        private Panel panel29;
        private Panel panel25;
        private Panel panel21;
        private Panel panel15;
        private Panel panel28;
        private Panel panel24;
        private Panel panel20;
        private TextBox txtNombreApellido;
        private Panel panel14;
        private TextBox txtDni;
        private TextBox txtMes;
        private Panel panel27;
        private TextBox txtCodigoSeguridad;
        private Panel panel23;
        private Panel panel18;
        private Label label23;
        private Label label17;
        private Label label21;
        private Label label22;
        private Label label19;
        private Label label24;
        private Label label20;
        private Label label16;
        private Label label18;
        private Label label25;
        private Label label26;
        private ErrorProvider errorProvider1;
        private Panel panel34;
        private Panel panel33;
        private Panel panel32;
        private TextBox txtAnio;
        private Panel panel31;
    }
}