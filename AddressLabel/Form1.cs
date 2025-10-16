using System.Windows.Forms;

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
            DisplayContent();
        }

        string EvaluateFields()
        {
            string message = "";

            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.Focus();
                message += "Phone number is required.\n";
            }

            //validates that field is not empty and is a number
            try
            {
                int.Parse(AgeTextBox.Text);
            }
            catch (Exception)
            {
                AgeTextBox.Focus();
                message += "Valid Age is required.\n";
            }

            //Only Verifies that field is not empty
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

            return message;
        }
        void DisplayContent()
        {
            if (EvaluateFields() != "")
            {
                MessageBox.Show(EvaluateFields());
            }
            else
            {
                DisplayLabel.Text = ($"{FirstNameTextBox.Text} {LastNameTextBox.Text}\nAge: {AgeTextBox.Text}\nPhone: {PhoneTextBox.Text}");
            }
        }

        
    }
}
