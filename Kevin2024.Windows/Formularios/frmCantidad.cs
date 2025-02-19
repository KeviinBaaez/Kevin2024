using System.Reflection.Metadata.Ecma335;

namespace Kevin2024.Windows.Formularios
{
    public partial class frmCantidad : Form
    {
        private int cantidad;
        public frmCantidad()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "0";
                RecargarTodo();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "1";
                RecargarTodo();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "2";
                RecargarTodo();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "3";
                RecargarTodo();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "4";
                RecargarTodo();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "5";
                RecargarTodo();
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "6";
                RecargarTodo();
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "7";
                RecargarTodo();
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "8";
                RecargarTodo();
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length < 9)
            {
                txtNumeros.Text += "9";
                RecargarTodo();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text.Length > 0)
            {
                txtNumeros.Text = txtNumeros.Text.Substring(0, txtNumeros.Text.Length - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = " ";
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeros.Text, out int nro))
            {
                MessageBox.Show("Ups, encontramos un error inesperado!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cantidad = int.Parse(txtNumeros.Text);
            DialogResult = DialogResult.OK;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
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
        private void RecargarTodo()
        {
            txtNumeros.Focus();
            txtNumeros.SelectionLength = 0;
            txtNumeros.SelectionStart = txtNumeros.Text.Length;
        }

        private void txtNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }

}
