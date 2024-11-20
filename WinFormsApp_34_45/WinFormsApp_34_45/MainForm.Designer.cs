
namespace WinFormsApp_34_45
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
            ToAuthorizationButton = new Button();
            ToRegistrationButton = new Button();
            ToColorsButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ToAuthorizationButton
            // 
            ToAuthorizationButton.Location = new Point(121, 182);
            ToAuthorizationButton.Margin = new Padding(4);
            ToAuthorizationButton.Name = "ToAuthorizationButton";
            ToAuthorizationButton.Size = new Size(131, 32);
            ToAuthorizationButton.TabIndex = 0;
            ToAuthorizationButton.Text = "Авторизация";
            ToAuthorizationButton.UseVisualStyleBackColor = true;
            ToAuthorizationButton.Click += ToAuthorizationButton_Click;
            // 
            // ToRegistrationButton
            // 
            ToRegistrationButton.Location = new Point(350, 182);
            ToRegistrationButton.Margin = new Padding(4);
            ToRegistrationButton.Name = "ToRegistrationButton";
            ToRegistrationButton.Size = new Size(131, 32);
            ToRegistrationButton.TabIndex = 0;
            ToRegistrationButton.Text = "Регистрация";
            ToRegistrationButton.UseVisualStyleBackColor = true;
            ToRegistrationButton.Click += ToRegistrationButton_Click;
            // 
            // ToColorsButton
            // 
            ToColorsButton.Location = new Point(239, 242);
            ToColorsButton.Margin = new Padding(4);
            ToColorsButton.Name = "ToColorsButton";
            ToColorsButton.Size = new Size(131, 32);
            ToColorsButton.TabIndex = 0;
            ToColorsButton.Text = "Colors";
            ToColorsButton.UseVisualStyleBackColor = true;
            ToColorsButton.Click += ToColorsButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(239, 116);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(131, 32);
            button1.TabIndex = 0;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 406);
            Controls.Add(ToColorsButton);
            Controls.Add(button1);
            Controls.Add(ToRegistrationButton);
            Controls.Add(ToAuthorizationButton);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Моя крутая программа";
            Controls.SetChildIndex(ToAuthorizationButton, 0);
            Controls.SetChildIndex(ToRegistrationButton, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(ToColorsButton, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button ToAuthorizationButton;
        private Button ToRegistrationButton;
        private Button ToColorsButton;
        private Button button1;
    }
}
