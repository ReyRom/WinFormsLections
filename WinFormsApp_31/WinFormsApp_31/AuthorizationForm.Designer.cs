namespace WinFormsApp_31
{
    partial class AuthorizationForm
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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            AuthButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.Location = new Point(32, 45);
            LoginTextBox.Margin = new Padding(4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(352, 29);
            LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(32, 103);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(352, 29);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AuthButton
            // 
            AuthButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AuthButton.Location = new Point(304, 159);
            AuthButton.Margin = new Padding(4);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(97, 32);
            AuthButton.TabIndex = 4;
            AuthButton.Text = "Войти";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Location = new Point(32, 139);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(150, 25);
            ShowPasswordCheckBox.TabIndex = 5;
            ShowPasswordCheckBox.Text = "Показать пароль";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 236);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(AuthButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(LoginTextBox, 0);
            Controls.SetChildIndex(PasswordTextBox, 0);
            Controls.SetChildIndex(AuthButton, 0);
            Controls.SetChildIndex(ShowPasswordCheckBox, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button AuthButton;
        private CheckBox ShowPasswordCheckBox;
    }
}