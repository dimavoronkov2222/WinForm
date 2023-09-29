namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = piker1.Value;
            DateTime date2 = piker2.Value;
            int days = (date2 - date1).Days;
            result.Text = Convert.ToString(days) + " Days";
        }
    }
}