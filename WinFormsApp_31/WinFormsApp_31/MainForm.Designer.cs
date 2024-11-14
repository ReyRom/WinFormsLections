namespace WinFormsApp_31
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
            ToColorButton = new Button();
            RolesButton = new Button();
            SuspendLayout();
            // 
            // ToAuthorizationButton
            // 
            ToAuthorizationButton.Location = new Point(199, 155);
            ToAuthorizationButton.Margin = new Padding(4);
            ToAuthorizationButton.Name = "ToAuthorizationButton";
            ToAuthorizationButton.Size = new Size(159, 41);
            ToAuthorizationButton.TabIndex = 0;
            ToAuthorizationButton.Text = " Авторизация";
            ToAuthorizationButton.UseVisualStyleBackColor = true;
            ToAuthorizationButton.Click += ToAuthorizationButton_Click;
            // 
            // ToRegistrationButton
            // 
            ToRegistrationButton.Location = new Point(199, 204);
            ToRegistrationButton.Margin = new Padding(4);
            ToRegistrationButton.Name = "ToRegistrationButton";
            ToRegistrationButton.Size = new Size(159, 39);
            ToRegistrationButton.TabIndex = 1;
            ToRegistrationButton.Text = "Регистрация";
            ToRegistrationButton.UseVisualStyleBackColor = true;
            ToRegistrationButton.Click += ToRegistrationButton_Click;
            // 
            // ToColorButton
            // 
            ToColorButton.Location = new Point(199, 251);
            ToColorButton.Margin = new Padding(4);
            ToColorButton.Name = "ToColorButton";
            ToColorButton.Size = new Size(159, 39);
            ToColorButton.TabIndex = 1;
            ToColorButton.Text = "RGB";
            ToColorButton.UseVisualStyleBackColor = true;
            ToColorButton.Click += ToColorButton_Click;
            // 
            // RolesButton
            // 
            RolesButton.Location = new Point(199, 298);
            RolesButton.Margin = new Padding(4);
            RolesButton.Name = "RolesButton";
            RolesButton.Size = new Size(159, 39);
            RolesButton.TabIndex = 1;
            RolesButton.Text = "Роли";
            RolesButton.UseVisualStyleBackColor = true;
            RolesButton.Click += RolesButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 456);
            Controls.Add(RolesButton);
            Controls.Add(ToColorButton);
            Controls.Add(ToRegistrationButton);
            Controls.Add(ToAuthorizationButton);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Моя крутая программа";
            Controls.SetChildIndex(ToAuthorizationButton, 0);
            Controls.SetChildIndex(ToRegistrationButton, 0);
            Controls.SetChildIndex(ToColorButton, 0);
            Controls.SetChildIndex(RolesButton, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button ToAuthorizationButton;
        private Button ToRegistrationButton;
        private Button ToColorButton;
        private Button RolesButton;
    }
}
