using System.Diagnostics;

namespace Oefening4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Alle Ext.Price
            double sum1 = Convert.ToDouble(Price1.Text) * Convert.ToDouble(Quantity1.Text);
            ExtPrice1.Text = "$" + sum1.ToString();
            double sum2 = Convert.ToDouble(Price2.Text) * Convert.ToDouble(Quantity2.Text);
            ExtPrice2.Text = "$" + sum2.ToString();
            double sum3 = Convert.ToDouble(Price3.Text) * Convert.ToDouble(Quantity3.Text);
            ExtPrice3.Text = "$" + sum3.ToString();
            double sum4 = Convert.ToDouble(Price4.Text) * Convert.ToDouble(Quantity4.Text);
            ExtPrice4.Text = "$" + sum4.ToString();

            //Subtotal
            double subtotal = sum1 + sum2 + sum3 + sum4;
            SubtotalResult.Text = "$" + subtotal;

            //Sales Tax
            double salesTax = Convert.ToDouble(TaxRateResult.Text) * subtotal;
            SalesTaxResult.Text = "$" + salesTax.ToString();

            //Grand Total
            double grandTotal = subtotal + salesTax + Convert.ToDouble(ShippingResult.Text);
            GrandTotalResult.Text = "$" + grandTotal.ToString();




        }

        private void ExtPrice1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}