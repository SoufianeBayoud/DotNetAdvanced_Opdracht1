namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int berekening1 = 12345 * 54321;
            string resultaat1 = $"{berekening1}";
            Resultaatberekening1.Text = resultaat1;

            int berekening2 = 22222 * 33333;
            string resultaat2 = $"{berekening2}";
            Resultaatberekening2.Text = resultaat2;

            //if(berekening1 > berekening2)
            //{
            //    ResultaatTrueOrFalse.Text = "False";
            //} else if(berekening1 < berekening2)
            //{
            //    ResultaatTrueOrFalse.Text = "True";
            //}
            bool trueOrFalse = berekening1 > berekening2;
            string TOrF = $"{ trueOrFalse}";

            ResultaatTrueOrFalse.Text = TOrF;

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resultaatberekening1_Click(object sender, EventArgs e)
        {
            
        }

        private void Resultaatberekening2_Click(object sender, EventArgs e)
        {

        }

        private void ResultaatTrueOrFalse_Click(object sender, EventArgs e)
        {

        }

        private void berekening1_Click(object sender, EventArgs e)
        {

        }
    }
}