using Kevin2024.Entidades.Entidades;
using Kevin2024.Entidades.Enumeraciones;
using Kevin2024.Entidades.ViewModels;
using Kevin2024.Windows.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmTomarOrden : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        TipoOrden? tipoOrden;
        EstadoOrden? estadoOrden;
        EstadoPago? estadoPago;
        Cliente? cliente;
        string? total;
        public frmTomarOrden(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void frmTomarOrden_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboClientes(ref cboClientes, _serviceProvider);
            CombosHelper.CargarComboFormasDePago(ref cboFormaDePago, _serviceProvider);
            this.Width = 575;
            this.Height = 400;

            btnLocal.Size = new Size(191, 78);
            btnTakeAway.Size = new Size(193, 78);
            btnDelivery.Size = new Size(191, 78);

            lblTipoOrden.Text = "Local";

            panelDelivery.Visible = false;
            panelFormaPago.Location = new Point(3, 142);
            panelFormaPago.Visible = true;
            panelTarjeta.Visible = false;

            btnAceptar.Location = new Point(104, 250);
            btnCancelar.Location = new Point(323, 250);

            btnLocal.Enabled = false;
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            ButtonLocal();
        }

        private void ButtonLocal()
        {
            btnDelivery.Enabled = true;

            this.Width = 575;
            this.Height = 400;

            btnLocal.Size = new Size(191, 78);
            btnTakeAway.Size = new Size(193, 78);
            btnDelivery.Size = new Size(191, 78);

            lblTipoOrden.Text = "Local";

            panelDelivery.Visible = false;

            panelFormaPago.Location = new Point(3, 142);
            panelFormaPago.Visible = true;
            cboFormaDePago.SelectedIndex = 1;

            panelEfectivo.Visible = true;
            panelTarjeta.Visible = false;

            btnTakeAway.Enabled = true;
            btnDelivery.Enabled = true;
            btnLocal.Enabled = false;

            btnAceptar.Location = new Point(105, 250);
            btnCancelar.Location = new Point(323, 250);
        }
        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            btnDelivery.Enabled = true;

            this.Width = 575;
            this.Height = 400;

            btnLocal.Size = new Size(191, 78);
            btnTakeAway.Size = new Size(193, 78);
            btnDelivery.Size = new Size(191, 78);

            lblTipoOrden.Text = "Take Away";

            panelDelivery.Visible = false;

            panelTarjeta.Visible = false;
            panelFormaPago.Location = new Point(3, 142);
            panelFormaPago.Visible = true;
            cboFormaDePago.SelectedIndex = 1;

            panelEfectivo.Visible = true;
            panelTarjeta.Visible = false;


            btnLocal.Enabled = true;
            btnDelivery.Enabled = true;
            btnTakeAway.Enabled = false;

            btnAceptar.Location = new Point(105, 250);
            btnCancelar.Location = new Point(323, 250);
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            this.Width = 575;
            this.Height = 650;

            btnLocal.Size = new Size(191, 78);
            btnTakeAway.Size = new Size(193, 78);
            btnDelivery.Size = new Size(191, 78);

            panelFormaPago.Location = new Point(3, 381);
            panelFormaPago.Visible = true;

            panelEfectivo.Visible = true;
            panelTarjeta.Visible = false;


            btnLocal.Enabled = true;
            btnTakeAway.Enabled = true;


            lblTipoOrden.Text = "Delivery";
            panelDelivery.Visible = true;
            panelDelivery.Location = new Point(3, 142);

            frmOrdenDelivery frm = new frmOrdenDelivery(_serviceProvider);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                ButtonLocal();
                return;
            }
            DireccionConTipoVm? direccion = frm.GetDireccion();
            TelefonoConTipoVm? telefono = frm.GetTelefono();
            lbltipoDireccion.Text = direccion!.TipoDireccion?.Descripcion;
            lblCalle.Text = direccion.Direccion!.Calle;
            lblAltura.Text = direccion.Direccion.Altura;
            lblEntre.Text = direccion.Direccion.Entre1;
            lblEntre2.Text = direccion.Direccion.Entre2;
            lblPiso.Text = direccion.Direccion.Piso.ToString();
            lblDepto.Text = direccion.Direccion.Depto;
            lblTelefono.Text = telefono!.ToString();

            btnDelivery.Enabled = false;
        }
        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = (Cliente?)cboClientes.SelectedItem;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            estadoOrden = new EstadoOrden();
            estadoPago = new EstadoPago();
            tipoOrden = new TipoOrden();
            if (cboFormaDePago.SelectedIndex == 0)
            {
                return;
            }
            if (btnLocal.Enabled == false)
            {
                tipoOrden.TipoOrdenId = 1;
                if (cboFormaDePago.SelectedIndex == 4)
                {
                    estadoPago.EstadoPagoId = 2;
                }
                else
                {
                    estadoPago.EstadoPagoId = 1;
                }
            }
            else if (btnTakeAway.Enabled == false)
            {
                tipoOrden.TipoOrdenId = 2;
                if (cboFormaDePago.SelectedIndex == 4)
                {
                    estadoPago.EstadoPagoId = 2;
                }
                else
                {
                    estadoPago.EstadoPagoId = 1;
                }
            }
            else
            {
                tipoOrden.TipoOrdenId = 3;
                if (cboFormaDePago.SelectedIndex == 4)
                {
                    estadoPago.EstadoPagoId = 2;
                }
                else
                {
                    estadoPago.EstadoPagoId = 1;
                }
            }
            if (cboFormaDePago.SelectedIndex > 1 && cboFormaDePago.SelectedIndex < 4)
            {
                if (!ValidarDatos())
                {
                    errorProvider1.SetError(txtNumero, "Error");
                }
                estadoPago.EstadoPagoId = 1;
            }

            estadoOrden.EstadoOrdenId = 2;
            DialogResult = DialogResult.OK;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!ValidarTarjeta())
            {
                valido = false;
            }
            return valido;
        }

        private bool ValidarTarjeta()
        {
            bool valido = false;
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                int total = 0;
                var numeros = txtNumero.Text.Replace(" ", ""); // Elimina espacios en blanco
                char[] array = numeros.ToCharArray(); // Convierte el número a un arreglo de caracteres
                Array.Reverse(array); // Invierte el arreglo de caracteres
                string reverse = new string(array); // Vuelve a convertir el arreglo a cadena

                // Recorre el número de derecha a izquierda
                for (int i = 0; i < reverse.Length; i++)
                {
                    int n = int.Parse(reverse.Substring(i, 1)); // Obtiene el dígito actual

                    // Si estamos en una posición impar (cuando la cadena está invertida, es un índice par)
                    if (i % 2 == 1)
                    {
                        n *= 2; // Multiplicamos el número por 2

                        if (n > 9)
                        {
                            n -= 9;  // Si el número es mayor que 9, restamos 9
                        }
                    }

                    total += n; // Sumamos el dígito (o el valor ajustado) al total
                }

                // Si el total es divisible por 10, la tarjeta es válida según el algoritmo de Luhn
                if (total % 10 == 0)
                {
                    valido = true;
                }
                else
                {
                    valido = false;
                }
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public bool GetRegalo()
        {
            return checkBox1.Checked;
        }

        private void cboFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaDePago.SelectedIndex == 1)
            {
                if (btnDelivery.Enabled == true)
                {
                    this.Width = 575;
                    this.Height = 400;

                    btnLocal.Size = new Size(191, 78);
                    btnTakeAway.Size = new Size(193, 78);
                    btnDelivery.Size = new Size(191, 78);

                    panelFormaPago.Location = new Point(3, 142);
                    panelEfectivo.Visible = true;
                    panelTarjeta.Location = new Point(3, 232);
                    panelTarjeta.Visible = false;
                    panelDelivery.Visible = false;
                    btnAceptar.Location = new Point(105, 250);
                    btnCancelar.Location = new Point(323, 250);
                }
                else
                {
                    //Forma de pago efectivo y delivery: 
                    this.Width = 575;
                    this.Height = 610;

                    panelDelivery.Location = new Point(3, 142);
                    panelFormaPago.Location = new Point(3, 381);
                    panelTarjeta.Location = new Point(578, 142);

                    panelDelivery.Visible = true;
                    panelFormaPago.Visible = true;
                    panelEfectivo.Visible = true;
                    panelTarjeta.Visible = false;



                    btnLocal.Size = new Size(191, 78);
                    btnTakeAway.Size = new Size(193, 78);
                    btnDelivery.Size = new Size(191, 78);

                    btnAceptar.Location = new Point(105, 470);
                    btnCancelar.Location = new Point(323, 470);
                }
            }
            if (cboFormaDePago.SelectedIndex == 2 || cboFormaDePago.SelectedIndex == 3)
            {
                if (btnDelivery.Enabled == true)
                {
                    this.Width = 575;
                    this.Height = 705;

                    btnLocal.Size = new Size(191, 78);
                    btnTakeAway.Size = new Size(193, 78);
                    btnDelivery.Size = new Size(191, 78);

                    panelFormaPago.Location = new Point(3, 142);
                    panelEfectivo.Visible = false;
                    panelTarjeta.Location = new Point(3, 232);
                    panelTarjeta.Visible = true;
                    panelDelivery.Visible = false;
                    btnAceptar.Location = new Point(105, 566);
                    btnCancelar.Location = new Point(323, 566);
                }
                else
                {
                    //Forma de pago tarjeta y delivery:

                    this.Width = 1140;
                    this.Height = 635;

                    panelDelivery.Location = new Point(3, 142);
                    panelFormaPago.Location = new Point(3, 381);
                    panelTarjeta.Location = new Point(578, 142);

                    panelDelivery.Visible = true;
                    panelFormaPago.Visible = true;
                    panelEfectivo.Visible = false;
                    panelTarjeta.Visible = true;

                    btnLocal.Size = new Size(380, 78);
                    btnTakeAway.Size = new Size(380, 78);
                    btnDelivery.Size = new Size(380, 78);

                    btnAceptar.Location = new Point(367, 494);
                    btnCancelar.Location = new Point(594, 494);
                }
            }
            if (cboFormaDePago.SelectedIndex == 4)
            {
                if (btnDelivery.Enabled == true)
                {
                    this.Width = 575;
                    this.Height = 400;

                    btnLocal.Size = new Size(191, 78);
                    btnTakeAway.Size = new Size(193, 78);
                    btnDelivery.Size = new Size(191, 78);

                    panelFormaPago.Location = new Point(3, 142);
                    panelEfectivo.Visible = false;
                    panelTarjeta.Location = new Point(3, 232);
                    panelTarjeta.Visible = false;
                    panelDelivery.Visible = false;
                    btnAceptar.Location = new Point(105, 250);
                    btnCancelar.Location = new Point(323, 250);
                }
                else
                {
                    //impaga delivery: 
                    this.Width = 575;
                    this.Height = 610;

                    panelDelivery.Location = new Point(3, 142);
                    panelFormaPago.Location = new Point(3, 381);
                    panelTarjeta.Location = new Point(578, 142);

                    panelDelivery.Visible = true;
                    panelFormaPago.Visible = true;
                    panelEfectivo.Visible = false;
                    panelTarjeta.Visible = false;



                    btnLocal.Size = new Size(191, 78);
                    btnTakeAway.Size = new Size(193, 78);
                    btnDelivery.Size = new Size(191, 78);

                    btnAceptar.Location = new Point(105, 470);
                    btnCancelar.Location = new Point(323, 470);
                }
            }
        }

        private void txtRecibo_TextChanged(object sender, EventArgs e)
        {
            decimal recibido;
            if (string.IsNullOrEmpty(txtRecibo.Text) || (txtRecibo.Text[0] == ',' || txtRecibo.Text[0] == '.'))
            {
                recibido = 0;
            }
            else
            {
                recibido = decimal.Parse(txtRecibo.Text.Replace(".", ","));
            }

            decimal cobrar = decimal.Parse(total!);
            if (recibido > cobrar)
            {
                txtDevuelvo.Text = (recibido - cobrar).ToString();
            }
            else
            {
                txtDevuelvo.Text = "";
            }

        }

        public void SetTotal(string text)
        {
            total = text;
        }


        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                return;

            }
        }
        int tn = 0;
        string t;
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            // Evitar el bucle infinito al modificar el texto
            int cursorPosition = txtNumero.SelectionStart;

            // Eliminar espacios si ya existen en el texto
            string textWithoutSpaces = txtNumero.Text.Replace(" ", "");

            // Condición para agregar un espacio después de cada 4 caracteres
            if (textWithoutSpaces.Length > 0)
            {
                // Solo agregar un espacio si es necesario (cada 4 caracteres)
                string formattedText = string.Empty;
                for (int i = 0; i < textWithoutSpaces.Length; i++)
                {
                    formattedText += textWithoutSpaces[i];
                    // Insertar un espacio cada 4 caracteres
                    if ((i + 1) % 4 == 0 && i != textWithoutSpaces.Length - 1)
                    {
                        formattedText += " ";
                    }
                }

                // Actualizar el texto con espacios
                txtNumero.Text = formattedText;

                // Restaurar la posición del cursor, teniendo en cuenta los espacios
                txtNumero.SelectionStart = cursorPosition + (formattedText.Length - textWithoutSpaces.Length);
            }
        }

        private void txtFechaVto_TextChanged(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            if (!string.IsNullOrEmpty(txtMes.Text))
            {
                int mes = int.Parse(txtMes.Text);
                if (mes < 1 || mes > 12)
                {
                    errorProvider1.SetError(txtMes, "Ingrese una fecha válida");
                }
                else
                {
                    if (txtMes.Text.Length == 2)
                    {
                        txtAnio.Focus();
                    }
                }
            }
        }
        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!string.IsNullOrEmpty(txtMes.Text))
            {
                int mes = int.Parse(txtMes.Text);
                if (mes < 10)
                {
                    txtMes.Text = "0" + mes;
                }
            }
            else
            {
                errorProvider1.SetError(txtMes, "Ingrese una fecha válida");
            }
            if (!string.IsNullOrEmpty(txtAnio.Text))
            {
                int anio = int.Parse(txtAnio.Text);
                anio += 2000;
                if (anio < DateTime.Now.Year)
                {
                    errorProvider1.SetError(txtAnio, "Ingrese una fecha válida");
                }
                else
                {
                    if (txtAnio.Text.Length == 2)
                    {
                        txtDni.Focus();
                    }
                }
            }
        }

        private void txtFechaVto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int mes = int.Parse(txtMes.Text);
                if (mes < 10)
                {
                    txtMes.Text = "0" + mes;
                }
                txtAnio.Focus();
            }
        }

        public Cliente? GetCliente()
        {
            return cliente;
        }
        public TipoOrden? GetTipoOrden()
        {
            return tipoOrden;
        }
        public EstadoOrden? GetEstadoOrden()
        {
            return estadoOrden;
        }

        public EstadoPago? GetEstadoPago()
        {
            return estadoPago;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
