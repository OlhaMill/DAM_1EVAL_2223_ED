namespace GestionBancaria
{
    public partial class Form1 : Form
    {

        //codigo modificado
       
        private double saldo_om_2223 = 1000;  // Saldo inicial de la cuenta, 1000�

        public Form1()
        {
            InitializeComponent();
            txtSaldo.Text = saldo_om_2223.ToString();
            txtCantidad.Text = "0";
        }

        private bool realizarReintegro(ref double cantidad_om_2223)
        {
            if (cantidad_om_2223 >= 0 && saldo_om_2223 >= cantidad_om_2223)
            {
                saldo_om_2223 -= cantidad_om_2223;
                return true;
            }
            else return false;
        }

        private void realizarIngreso(ref double cantidad_om_2223)
        {
            if (cantidad_om_2223 > 0)
                saldo_om_2223 += cantidad_om_2223;
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            double cantidad_om_2223 = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a n�mero
            if (cantidad_om_2223 < 0)
            {
                MessageBox.Show("Cantidad no v�lid�, s�lo se admiten cantidades positivas.");
            }
            else
            {
                if (rbReintegro.Checked)
                {
                    if (realizarReintegro(ref cantidad_om_2223) == false)  // No se ha podido completar la operaci�n, saldo insuficiente?
                        MessageBox.Show("No se ha podido realizar la operaci�n (�Saldo insuficiente?)");
                }
                if (radioButton1.Checked)
                    realizarIngreso(ref cantidad_om_2223);
            }
            txtSaldo.Text = saldo_om_2223.ToString();
        }
    }
}