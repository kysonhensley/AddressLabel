namespace AddressLabel
{
    partial class Form1
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
            ExitButton = new Button();
            SubmitButton = new Button();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            DisplayLabel = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(308, 245);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(114, 82);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(428, 245);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(114, 82);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(12, 58);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(109, 58);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(125, 27);
            FirstNameTextBox.TabIndex = 3;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(109, 157);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(125, 27);
            PhoneTextBox.TabIndex = 5;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(12, 160);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 4;
            PhoneLabel.Text = "Phone";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(109, 124);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 7;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(12, 127);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 6;
            AgeLabel.Text = "Age";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(109, 91);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(125, 27);
            LastNameTextBox.TabIndex = 9;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(12, 91);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 8;
            LastNameLabel.Text = "Last Name";
            // 
            // DisplayLabel
            // 
            DisplayLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(240, 58);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(302, 126);
            DisplayLabel.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 339);
            Controls.Add(DisplayLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private Label DisplayLabel;
    }
}
