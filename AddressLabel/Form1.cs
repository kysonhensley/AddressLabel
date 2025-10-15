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
            string message = "";

            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.Focus();
                message += "Phone number is required.\n";
            }

            if (AgeTextBox.Text == "")
            {
                AgeTextBox.Focus();
                message += "Age is required.\n";
            }

            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.Focus();
                message += "Last Name is required.\n";
            }

            if (FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.Focus();
                message += "FIrst Name is required.\n";
            }

            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                DisplayLabel.Text = ($"{FirstNameTextBox.Text} {LastNameTextBox.Text}\nAge: {AgeTextBox.Text}\nPhone: {PhoneTextBox.Text}");
            }
        }

        static void EvaluateField()
        {
            
        }
        static void DisplayContent(string text)
        {
            
        }
    }
}
