namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Hello " + Environment.UserName + ". Het is " + DateTime.Now.ToShortTimeString() + "u op " + DateTime.Now.ToShortDateString() + ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}