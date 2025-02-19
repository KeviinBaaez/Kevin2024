using Kevin2024.Entidades.Entidades;
using Kevin2024.Servicios.Interfaces;
using Kevin2024.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmEstadoPago : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosOrden? _servicios;
        private OrdenPedido? orden;

        public frmEstadoPago(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider!.GetService<IServiciosOrden>() ??
                throw new ApplicationException("Dependencias no cargadas!!");
        }

        public void SetOrden(OrdenPedido orden)
        {
            this.orden = orden;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmEstadoPago_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboFormasDePago(ref cboFormaDePago, _serviceProvider);
            panelTarjeta.Visible = false;
            this.Width = 650;
            this.Height = 200;
            lblOrdenNro.Text = orden!.OrdenId.ToString();
            lblTotal.Text = orden!.Total.ToString();
            //650; 530
        }

        private void cboFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaDePago.SelectedIndex == 0) return;
            if (cboFormaDePago.SelectedIndex == 1)
            {
                this.Width = 650;
                this.Height = 200;
                panelTarjeta.Visible = false;
                panelEfectivo.Visible = true;
            }
            if (cboFormaDePago.SelectedIndex == 2 || cboFormaDePago.SelectedIndex == 3)
            {
                this.Width = 650;
                this.Height = 530;
                panelTarjeta.Visible = true;
                panelEfectivo.Visible = false;
            }
            if (cboFormaDePago.SelectedIndex == 4) return;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cboFormaDePago.SelectedIndex > 1 && cboFormaDePago.SelectedIndex < 4)
            {
                if (!ValidarDatos())
                {
                    errorProvider1.SetError(txtNumero, "Error");
                }
            }
            if (cboFormaDePago.SelectedIndex == 0 || cboFormaDePago.SelectedIndex == 4)
            {
                errorProvider1.SetError(cboFormaDePago, "Seleccione una opcion valida para realizar un pago");
            }
            try
            {
                if (orden is null) return;
                orden.EstadoPagoId = 2;
                _servicios!.Guardar(orden);
                MessageBox.Show("Orden Pagada!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

            decimal cobrar = orden!.Total;
            if (recibido > cobrar)
            {
                txtDevuelvo.Text = (recibido - cobrar).ToString();
            }
            else
            {
                txtDevuelvo.Text = "";
            }

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
