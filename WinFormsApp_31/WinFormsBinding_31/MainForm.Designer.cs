namespace WinFormsBinding_31
{
    partial class MainForm
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            PersonLabel = new Label();
            PersonsListBox = new ListBox();
            CounterButton = new Button();
            CounterLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(18, 48);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(38, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "label1";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(18, 12);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(341, 23);
            NameTextBox.TabIndex = 1;
            // 
            // PersonLabel
            // 
            PersonLabel.AutoSize = true;
            PersonLabel.Location = new Point(18, 174);
            PersonLabel.Name = "PersonLabel";
            PersonLabel.Size = new Size(38, 15);
            PersonLabel.TabIndex = 2;
            PersonLabel.Text = "label1";
            // 
            // PersonsListBox
            // 
            PersonsListBox.FormattingEnabled = true;
            PersonsListBox.ItemHeight = 15;
            PersonsListBox.Location = new Point(18, 77);
            PersonsListBox.Name = "PersonsListBox";
            PersonsListBox.Size = new Size(341, 94);
            PersonsListBox.TabIndex = 3;
            // 
            // CounterButton
            // 
            CounterButton.Location = new Point(284, 269);
            CounterButton.Name = "CounterButton";
            CounterButton.Size = new Size(75, 23);
            CounterButton.TabIndex = 4;
            CounterButton.Text = "Нажми";
            CounterButton.UseVisualStyleBackColor = true;
            // 
            // CounterLabel
            // 
            CounterLabel.AutoSize = true;
            CounterLabel.Location = new Point(300, 236);
            CounterLabel.Name = "CounterLabel";
            CounterLabel.Size = new Size(38, 15);
            CounterLabel.TabIndex = 5;
            CounterLabel.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 304);
            Controls.Add(CounterLabel);
            Controls.Add(CounterButton);
            Controls.Add(PersonsListBox);
            Controls.Add(PersonLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Name = "MainForm";
            Text = "Главная";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Label PersonLabel;
        private ListBox PersonsListBox;
        private Button CounterButton;
        private Label CounterLabel;
    }
}
