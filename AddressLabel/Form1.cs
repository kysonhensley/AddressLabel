namespace AddressLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //this.Text = FirstNameTextBox.Text;
            DisplayLabel.Text = $" {FirstNameTextBox.Text} {LastNameTextBox.Text} \n Age: {AgeTextBox.Text} \n Phone: {PhoneTextBox.Text}";
        }
    }
}
