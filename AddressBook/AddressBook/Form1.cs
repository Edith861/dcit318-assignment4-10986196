namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = textBoxName1.Text;
            string email1 = textBoxEmail1.Text;
            string phone1 = textBoxPhone1.Text;

            string name2 = textBoxName2.Text;
            string email2 = textBoxEmail2.Text;
            string phone2 = textBoxPhone2.Text;

            string name3 = textBoxName3.Text;
            string email3 = textBoxEmail3.Text;
            string phone3 = textBoxPhone3.Text;

            // Here you can add code to save the information, e.g., save to a file or database

            MessageBox.Show($"Name 1: {name1}\nEmail 1: {email1}\nPhone 1: {phone1}\n\n" +
                            $"Name 2: {name2}\nEmail 2: {email2}\nPhone 2: {phone2}\n\n" +
                            $"Name 3: {name3}\nEmail 3: {email3}\nPhone 3: {phone3}", "Saved Information");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
