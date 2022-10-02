namespace Oefening6
{
    public partial class Form1 : Form
    {
        const double belasting = 0.07;
        double vervoerskosten;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the prices 
            double sum1 = Convert.ToDouble(Price1.Text) * Convert.ToDouble(quantity1.Text);
            priceShow1.Text = "$" + sum1.ToString();
            double sum2 = Convert.ToDouble(Price2.Text) * Convert.ToDouble(quantity2.Text);
            priceShow2.Text = "$" + sum2.ToString();
            double sum3 = Convert.ToDouble(Price3.Text) * Convert.ToDouble(quantity3.Text);
            priceShow3.Text = "$" + sum3.ToString();
            double sum4 = Convert.ToDouble(Price4.Text) * Convert.ToDouble(quantity4.Text);
            priceShow4.Text = "$" + sum4.ToString();

            //Subtotal
            double subtotal = sum1 + sum2 + sum3 + sum4;
            subtotalShow.Text = "$" + subtotal.ToString();

            // Sales Tax
            double tax = belasting * subtotal;
            salesTaxShow.Text = "$" + tax.ToString(); 

            // Shipping 
            if(subtotal < 20)
            {
                vervoerskosten = 5;
            } else if(subtotal < 50)
            {
                vervoerskosten = 7.5;
            } else if(subtotal < 75)
            {
                vervoerskosten = 10;
            }
            else if (subtotal >= 75)
            {
                vervoerskosten = 0;
            }

            shippingShow.Text = "$" + vervoerskosten.ToString();

            //Grand Total
            double grandtotal = subtotal + tax + vervoerskosten;
            grandTotalShow.Text = "$" + grandtotal.ToString();


        }
    }
}