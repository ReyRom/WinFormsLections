namespace WinFormsApp_34_45
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmTextBox = new TextBox();
            RegButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            BirthDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 2;
            label3.Text = "Подтверждение пароля";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(13, 34);
            LoginTextBox.Margin = new Padding(4, 4, 4, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(454, 29);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(13, 92);
            PasswordTextBox.Margin = new Padding(4, 4, 4, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(454, 29);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmTextBox
            // 
            ConfirmTextBox.Location = new Point(13, 150);
            ConfirmTextBox.Margin = new Padding(4, 4, 4, 4);
            ConfirmTextBox.Name = "ConfirmTextBox";
            ConfirmTextBox.Size = new Size(454, 29);
            ConfirmTextBox.TabIndex = 5;
            ConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(292, 469);
            RegButton.Margin = new Padding(4, 4, 4, 4);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(189, 32);
            RegButton.TabIndex = 6;
            RegButton.Text = "Зарегистрироваться";
            RegButton.UseVisualStyleBackColor = true;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Location = new Point(13, 186);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(150, 25);
            ShowPasswordCheckBox.TabIndex = 7;
            ShowPasswordCheckBox.Text = "Показать пароль";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 214);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 8;
            label4.Text = "Электронная почта";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 29);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 270);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 10;
            label5.Text = "Дата рождения";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(13, 294);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(200, 29);
            BirthDatePicker.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 553);
            Controls.Add(BirthDatePicker);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(RegButton);
            Controls.Add(ConfirmTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RegistrationForm";
            Text = "Регистрация";
            Load += RegistrationForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(LoginTextBox, 0);
            Controls.SetChildIndex(PasswordTextBox, 0);
            Controls.SetChildIndex(ConfirmTextBox, 0);
            Controls.SetChildIndex(RegButton, 0);
            Controls.SetChildIndex(ShowPasswordCheckBox, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(BirthDatePicker, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmTextBox;
        private Button RegButton;
        private CheckBox ShowPasswordCheckBox;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private DateTimePicker BirthDatePicker;
    }
}