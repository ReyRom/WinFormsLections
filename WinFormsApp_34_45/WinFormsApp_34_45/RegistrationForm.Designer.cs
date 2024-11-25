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
            EmailTextBox = new TextBox();
            label5 = new Label();
            BirthDatePicker = new DateTimePicker();
            label6 = new Label();
            FullNameTextBox = new TextBox();
            ConfirmCheckBox = new CheckBox();
            MaleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            RegistrationCaptcha = new Captcha();
            RenewButton = new Button();
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
            LoginTextBox.Margin = new Padding(4);
            LoginTextBox.MaxLength = 30;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(454, 29);
            LoginTextBox.TabIndex = 3;
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(13, 92);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.MaxLength = 30;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(454, 29);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmTextBox
            // 
            ConfirmTextBox.Location = new Point(13, 150);
            ConfirmTextBox.Margin = new Padding(4);
            ConfirmTextBox.MaxLength = 30;
            ConfirmTextBox.Name = "ConfirmTextBox";
            ConfirmTextBox.Size = new Size(454, 29);
            ConfirmTextBox.TabIndex = 5;
            ConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // RegButton
            // 
            RegButton.Enabled = false;
            RegButton.Location = new Point(293, 599);
            RegButton.Margin = new Padding(4);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(189, 32);
            RegButton.TabIndex = 6;
            RegButton.Text = "Зарегистрироваться";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
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
            label4.Location = new Point(13, 271);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 8;
            label4.Text = "Электронная почта";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(13, 295);
            EmailTextBox.MaxLength = 256;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(454, 29);
            EmailTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 327);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 10;
            label5.Text = "Дата рождения";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(13, 351);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(200, 29);
            BirthDatePicker.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 214);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 12;
            label6.Text = "ФИО";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(13, 238);
            FullNameTextBox.MaxLength = 300;
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(454, 29);
            FullNameTextBox.TabIndex = 13;
            FullNameTextBox.KeyPress += FullNameTextBox_KeyPress;
            // 
            // ConfirmCheckBox
            // 
            ConfirmCheckBox.AutoSize = true;
            ConfirmCheckBox.Location = new Point(12, 567);
            ConfirmCheckBox.Name = "ConfirmCheckBox";
            ConfirmCheckBox.Size = new Size(320, 25);
            ConfirmCheckBox.TabIndex = 14;
            ConfirmCheckBox.Text = "Согласиться с условиями использования";
            ConfirmCheckBox.UseVisualStyleBackColor = true;
            ConfirmCheckBox.CheckedChanged += ConfirmCheckBox_CheckedChanged;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Checked = true;
            MaleRadioButton.Location = new Point(241, 351);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(42, 25);
            MaleRadioButton.TabIndex = 15;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "М";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(289, 351);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(42, 25);
            FemaleRadioButton.TabIndex = 16;
            FemaleRadioButton.Text = "Ж";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationCaptcha
            // 
            RegistrationCaptcha.BackColor = SystemColors.ControlLightLight;
            RegistrationCaptcha.Location = new Point(13, 418);
            RegistrationCaptcha.Name = "RegistrationCaptcha";
            RegistrationCaptcha.Size = new Size(300, 100);
            RegistrationCaptcha.TabIndex = 17;
            // 
            // RenewButton
            // 
            RenewButton.Location = new Point(347, 450);
            RenewButton.Name = "RenewButton";
            RenewButton.Size = new Size(108, 33);
            RenewButton.TabIndex = 18;
            RenewButton.Text = "Обновить";
            RenewButton.UseVisualStyleBackColor = true;
            RenewButton.Click += RenewButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 644);
            Controls.Add(RenewButton);
            Controls.Add(RegistrationCaptcha);
            Controls.Add(FemaleRadioButton);
            Controls.Add(MaleRadioButton);
            Controls.Add(ConfirmCheckBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(label6);
            Controls.Add(BirthDatePicker);
            Controls.Add(label5);
            Controls.Add(EmailTextBox);
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
        private TextBox EmailTextBox;
        private Label label5;
        private DateTimePicker BirthDatePicker;
        private Label label6;
        private TextBox FullNameTextBox;
        private CheckBox ConfirmCheckBox;
        private RadioButton MaleRadioButton;
        private RadioButton FemaleRadioButton;
        private Captcha RegistrationCaptcha;
        private Button RenewButton;
    }
}