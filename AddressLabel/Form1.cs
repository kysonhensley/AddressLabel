namespace AddressLabel
{
    public partial class AddressLabelForm : Form
    {
        public AddressLabelForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayLabelButton_Click(object sender, EventArgs e)
        {

        }

        string EvaluateUserInput()
        {
            string message = "";

            if(FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.BackColor = Color.Red;
                message += "First name is required.\n";
            }
            
            return message;
        }
    }
}
