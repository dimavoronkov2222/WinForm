namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            string surname = Convert.ToString(Surname.Text);
            string Name = Convert.ToString(Name1.Text);
            string patronymic = Convert.ToString(Patronymic.Text);
            string gender_of_a_person = Convert.ToString(Gender_of_a_person.Text);
            string year_and_date_of_birth = Convert.ToString(Year_and_date_of_birth.Text);
            string family_status = Convert.ToString(Family_status.Text);
            string additional_information = Convert.ToString(Additional_Information.Text);
            string allStrings = "Surname: " + surname + "\n Name: " + Name + "\n Patronymic: " + patronymic + "\n Gender of a person: " + gender_of_a_person + "\n Year and date of birth: " + year_and_date_of_birth + "\n Family_status: " + family_status + "\n Additional Information: " + additional_information;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = "person";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, allStrings);
            }
        }
    }
}