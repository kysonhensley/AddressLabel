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
            DisplayLabel();
        }

        string EvaluateUserInput()
        {
            string message = "";

            if (FirstNameTextBox.Text == "")
            {
                FirstNameTextBox.Focus();
                message += "First name is required.\n";
            }

            if (LastNameTextBox.Text == "")
            {
                LastNameTextBox.Focus();
                message += "Last name is required.\n";
            }

            if (StreetAddressTextBox.Text == "")
            {
                StreetAddressTextBox.Focus();
                message += "Street is required.\n";
            }

            if (CityTextBox.Text == "")
            {
                CityTextBox.Focus();
                message += "City is required.\n";
            }

            if (StateTextBox.Text == "")
            {
                StateTextBox.Focus();
                message += "State is required.\n";
            }

            if (ZipCodeTextBox.Text == "")
            {
                ZipCodeTextBox.Focus();
                message += "Zip code is required.\n";
            }

            try
            {
                int.Parse(ZipCodeTextBox.Text);
            }
            catch (Exception)
            {
                ZipCodeTextBox.Focus();
                message += "Zip code must be a number.\n";
            }

            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                DisplayAddressLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n{StreetAddressTextBox.Text}\n{CityTextBox.Text}, {StateTextBox.Text} {ZipCodeTextBox.Text}";
            }

            return message;
        }

        void DisplayLabel()
        {
            if (EvaluateUserInput() != "")
            {
                MessageBox.Show(EvaluateUserInput());
            }
            else
            {
                DisplayAddressLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n{StreetAddressTextBox.Text}\n{CityTextBox.Text}, {StateTextBox.Text} {ZipCodeTextBox.Text}";
            }
        }

        private void SetDefualuts()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StreetAddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
            DisplayAddressLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefualuts();
        }
    }
}
