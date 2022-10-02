namespace CelsiusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void celsiusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double convertToFahrenheit = Convert.ToDouble(celsiusTxtBox.Text) * 9 / 5 + 32;
                MessageBox.Show(" °F = " + convertToFahrenheit);
            }
            catch
            {
                MessageBox.Show("Veld mag niet leeg zijn !");
            }
        }

        private void fahrenheitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double convertToCelsius = (Convert.ToDouble(FahrenheitTxtBox.Text) - 32) * 5 / 9;
                MessageBox.Show(" °C = " + convertToCelsius);
            }
            catch
            {
                MessageBox.Show("Veld mag niet leeg zijn !");
            }
        }
    }
}