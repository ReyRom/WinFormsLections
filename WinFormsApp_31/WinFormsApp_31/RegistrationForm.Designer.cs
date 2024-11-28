namespace WinFormsApp_31
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmTextBox = new TextBox();
            EmailTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            BirthDateTimePicker = new DateTimePicker();
            RegButton = new Button();
            MaleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            ConfirmCheckBox = new CheckBox();
            RegistrationCaptcha = new Captcha();
            RenewButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 126);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 3;
            label3.Text = "Подтверждение пароля";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 180);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 4;
            label4.Text = "Электронная почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 233);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 5;
            label5.Text = "ФИО";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 290);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 6;
            label6.Text = "Дата рождения";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.Location = new Point(14, 41);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(406, 29);
            LoginTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(14, 94);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(406, 29);
            PasswordTextBox.TabIndex = 8;
            // 
            // ConfirmTextBox
            // 
            ConfirmTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmTextBox.Location = new Point(14, 150);
            ConfirmTextBox.Name = "ConfirmTextBox";
            ConfirmTextBox.Size = new Size(406, 29);
            ConfirmTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(14, 204);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(406, 29);
            EmailTextBox.TabIndex = 10;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(14, 258);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(406, 29);
            FullNameTextBox.TabIndex = 11;
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(12, 323);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(200, 29);
            BirthDateTimePicker.TabIndex = 12;
            // 
            // RegButton
            // 
            RegButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegButton.Enabled = false;
            RegButton.Location = new Point(176, 561);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(244, 32);
            RegButton.TabIndex = 13;
            RegButton.Text = "Зарегистрироваться";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Checked = true;
            MaleRadioButton.Location = new Point(330, 327);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(42, 25);
            MaleRadioButton.TabIndex = 14;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "М";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(378, 327);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(42, 25);
            FemaleRadioButton.TabIndex = 15;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Ж";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmCheckBox
            // 
            ConfirmCheckBox.AutoSize = true;
            ConfirmCheckBox.Location = new Point(12, 530);
            ConfirmCheckBox.Name = "ConfirmCheckBox";
            ConfirmCheckBox.Size = new Size(217, 25);
            ConfirmCheckBox.TabIndex = 16;
            ConfirmCheckBox.Text = "Я прочитал(а) соглашение";
            ConfirmCheckBox.UseVisualStyleBackColor = true;
            ConfirmCheckBox.CheckedChanged += ConfirmCheckBox_CheckedChanged;
            // 
            // RegistrationCaptcha
            // 
            RegistrationCaptcha.BackColor = Color.FromArgb(128, 128, 255);
            RegistrationCaptcha.BorderStyle = BorderStyle.FixedSingle;
            RegistrationCaptcha.DotsColor = Color.Blue;
            RegistrationCaptcha.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegistrationCaptcha.ForeColor = Color.FromArgb(0, 192, 0);
            RegistrationCaptcha.Length = 5;
            RegistrationCaptcha.LinesColor = Color.Blue;
            RegistrationCaptcha.Location = new Point(13, 390);
            RegistrationCaptcha.Margin = new Padding(9);
            RegistrationCaptcha.Name = "RegistrationCaptcha";
            RegistrationCaptcha.Size = new Size(300, 100);
            RegistrationCaptcha.TabIndex = 17;
            // 
            // RenewButton
            // 
            RenewButton.Location = new Point(330, 430);
            RenewButton.Name = "RenewButton";
            RenewButton.Size = new Size(90, 29);
            RenewButton.TabIndex = 18;
            RenewButton.Text = "Обновить";
            RenewButton.UseVisualStyleBackColor = true;
            RenewButton.Click += RenewButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 653);
            Controls.Add(RenewButton);
            Controls.Add(RegistrationCaptcha);
            Controls.Add(ConfirmCheckBox);
            Controls.Add(FemaleRadioButton);
            Controls.Add(MaleRadioButton);
            Controls.Add(RegButton);
            Controls.Add(BirthDateTimePicker);
            Controls.Add(FullNameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(ConfirmTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RegistrationForm";
            Text = "Регистрация";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmTextBox;
        private TextBox EmailTextBox;
        private TextBox FullNameTextBox;
        private DateTimePicker BirthDateTimePicker;
        private Button RegButton;
        private RadioButton MaleRadioButton;
        private RadioButton FemaleRadioButton;
        private CheckBox ConfirmCheckBox;
        private Captcha RegistrationCaptcha;
        private Button RenewButton;
    }
}