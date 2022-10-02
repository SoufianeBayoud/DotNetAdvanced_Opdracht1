namespace Oefening7
{
    public partial class Form1 : Form
    {

        int sum; 
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            
            int aantal = Convert.ToInt32(inputNumber.Text);
            
            for (int i = 1; i <= aantal; i++)
            {
                
                    sum += i;
                
            }

            showResult.Text = sum.ToString();
            sum = 0;
        }
    }
}