namespace AddressLabel
{
    partial class AddressLabelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MailingAddressGroupBox = new GroupBox();
            AddressLabelGroupBox = new GroupBox();
            DisplayLabelButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            StreetAddressTextBox = new TextBox();
            StreetAddressLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            StateTextBox = new TextBox();
            StateLabel = new Label();
            textBox6 = new TextBox();
            ZipCodeLabel = new Label();
            MailingAddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MailingAddressGroupBox
            // 
            MailingAddressGroupBox.Controls.Add(textBox6);
            MailingAddressGroupBox.Controls.Add(ZipCodeLabel);
            MailingAddressGroupBox.Controls.Add(StateTextBox);
            MailingAddressGroupBox.Controls.Add(StateLabel);
            MailingAddressGroupBox.Controls.Add(CityTextBox);
            MailingAddressGroupBox.Controls.Add(CityLabel);
            MailingAddressGroupBox.Controls.Add(StreetAddressTextBox);
            MailingAddressGroupBox.Controls.Add(StreetAddressLabel);
            MailingAddressGroupBox.Controls.Add(LastNameTextBox);
            MailingAddressGroupBox.Controls.Add(LastNameLabel);
            MailingAddressGroupBox.Controls.Add(FirstNameTextBox);
            MailingAddressGroupBox.Controls.Add(FirstNameLabel);
            MailingAddressGroupBox.Location = new Point(12, 12);
            MailingAddressGroupBox.Name = "MailingAddressGroupBox";
            MailingAddressGroupBox.Size = new Size(373, 426);
            MailingAddressGroupBox.TabIndex = 0;
            MailingAddressGroupBox.TabStop = false;
            MailingAddressGroupBox.Text = "Mailing Address";
            // 
            // AddressLabelGroupBox
            // 
            AddressLabelGroupBox.Location = new Point(391, 12);
            AddressLabelGroupBox.Name = "AddressLabelGroupBox";
            AddressLabelGroupBox.Size = new Size(397, 370);
            AddressLabelGroupBox.TabIndex = 1;
            AddressLabelGroupBox.TabStop = false;
            AddressLabelGroupBox.Text = "AddressLabel";
            // 
            // DisplayLabelButton
            // 
            DisplayLabelButton.Location = new Point(391, 388);
            DisplayLabelButton.Name = "DisplayLabelButton";
            DisplayLabelButton.Size = new Size(133, 50);
            DisplayLabelButton.TabIndex = 0;
            DisplayLabelButton.Text = "&Display Label";
            DisplayLabelButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(530, 388);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(126, 50);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(662, 388);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(126, 50);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(19, 38);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(19, 56);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(19, 114);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(19, 96);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Last Name";
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.Location = new Point(19, 174);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(100, 23);
            StreetAddressTextBox.TabIndex = 5;
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.Location = new Point(19, 156);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(82, 15);
            StreetAddressLabel.TabIndex = 4;
            StreetAddressLabel.Text = "Street Address";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(19, 235);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 23);
            CityTextBox.TabIndex = 7;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(19, 217);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(19, 299);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(100, 23);
            StateTextBox.TabIndex = 9;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(19, 281);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(33, 15);
            StateLabel.TabIndex = 8;
            StateLabel.Text = "State";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(19, 361);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            textBox6.Text = "Zip Code";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(19, 343);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(55, 15);
            ZipCodeLabel.TabIndex = 10;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // AddressLabelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayLabelButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(AddressLabelGroupBox);
            Controls.Add(MailingAddressGroupBox);
            Name = "AddressLabelForm";
            Text = "Address Label Viewer";
            MailingAddressGroupBox.ResumeLayout(false);
            MailingAddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MailingAddressGroupBox;
        private GroupBox AddressLabelGroupBox;
        private Button DisplayLabelButton;
        private Button ClearButton;
        private Button ExitButton;
        private TextBox textBox6;
        private Label ZipCodeLabel;
        private TextBox StateTextBox;
        private Label StateLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox StreetAddressTextBox;
        private Label StreetAddressLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox FirstNameTextBox;
        private Label FirstNameLabel;
    }
}
