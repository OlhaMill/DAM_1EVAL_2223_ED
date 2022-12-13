namespace GestionBancaria
{
    public partial class Form1 : Form
    {

        //codigo modificado
       
        private double saldo_om_2223 = 1000;  // Saldo inicial de la cuenta, 1000€

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
            double cantidad_om_2223 = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a número
            if (cantidad_om_2223 < 0)
            {
                MessageBox.Show("Cantidad no válidá, sólo se admiten cantidades positivas.");
            }
            else
            {
                if (rbReintegro.Checked)
                {
                    if (realizarReintegro(ref cantidad_om_2223) == false)  // No se ha podido completar la operación, saldo insuficiente?
                        MessageBox.Show("No se ha podido realizar la operación (¿Saldo insuficiente?)");
                }
                if (radioButton1.Checked)
                    realizarIngreso(ref cantidad_om_2223);
            }
            txtSaldo.Text = saldo_om_2223.ToString();
        }
    }
}