namespace WinFormsApp_34_45
{
    partial class UserInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLabel = new Label();
            AgeLabel = new Label();
            HobbyListBox = new ListBox();
            HobbyTextBox = new TextBox();
            AddHobbyButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 13);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 21);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "label1";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(15, 46);
            AgeLabel.Margin = new Padding(4, 0, 4, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(52, 21);
            AgeLabel.TabIndex = 1;
            AgeLabel.Text = "label2";
            // 
            // HobbyListBox
            // 
            HobbyListBox.FormattingEnabled = true;
            HobbyListBox.ItemHeight = 21;
            HobbyListBox.Location = new Point(15, 173);
            HobbyListBox.Name = "HobbyListBox";
            HobbyListBox.Size = new Size(490, 151);
            HobbyListBox.TabIndex = 2;
            // 
            // HobbyTextBox
            // 
            HobbyTextBox.Location = new Point(15, 138);
            HobbyTextBox.Name = "HobbyTextBox";
            HobbyTextBox.Size = new Size(357, 29);
            HobbyTextBox.TabIndex = 3;
            // 
            // AddHobbyButton
            // 
            AddHobbyButton.Location = new Point(378, 138);
            AddHobbyButton.Name = "AddHobbyButton";
            AddHobbyButton.Size = new Size(127, 29);
            AddHobbyButton.TabIndex = 4;
            AddHobbyButton.Text = "Добавить";
            AddHobbyButton.UseVisualStyleBackColor = true;
            AddHobbyButton.Click += AddHobbyButton_Click;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 365);
            Controls.Add(AddHobbyButton);
            Controls.Add(HobbyTextBox);
            Controls.Add(HobbyListBox);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Name = "UserInfoForm";
            Text = "Пользователь";
            Load += UserInfoForm_Load;
            Controls.SetChildIndex(NameLabel, 0);
            Controls.SetChildIndex(AgeLabel, 0);
            Controls.SetChildIndex(HobbyListBox, 0);
            Controls.SetChildIndex(HobbyTextBox, 0);
            Controls.SetChildIndex(AddHobbyButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label AgeLabel;
        private ListBox HobbyListBox;
        private TextBox HobbyTextBox;
        private Button AddHobbyButton;
    }
}