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
            components = new System.ComponentModel.Container();
            MainMenuStrip = new MenuStrip();
            AuthorizationMenuItem = new ToolStripMenuItem();
            RegistrateMenuItem = new ToolStripMenuItem();
            ColorMenuItem = new ToolStripMenuItem();
            MainStatusStrip = new StatusStrip();
            DateTimeStatusLabel = new ToolStripStatusLabel();
            CurrentTimeTimer = new System.Windows.Forms.Timer(components);
            MainMenuStrip.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { AuthorizationMenuItem, RegistrateMenuItem, ColorMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1010, 29);
            MainMenuStrip.TabIndex = 1;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // AuthorizationMenuItem
            // 
            AuthorizationMenuItem.Name = "AuthorizationMenuItem";
            AuthorizationMenuItem.Size = new Size(65, 25);
            AuthorizationMenuItem.Text = "Войти";
            AuthorizationMenuItem.Click += ToAuthorizationButton_Click;
            // 
            // RegistrateMenuItem
            // 
            RegistrateMenuItem.Name = "RegistrateMenuItem";
            RegistrateMenuItem.Size = new Size(167, 25);
            RegistrateMenuItem.Text = "Зарегистрироваться";
            RegistrateMenuItem.Click += ToRegistrationButton_Click;
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(57, 25);
            ColorMenuItem.Text = "Цвет";
            ColorMenuItem.Click += ToColorButton_Click;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { DateTimeStatusLabel });
            MainStatusStrip.Location = new Point(0, 546);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(1010, 26);
            MainStatusStrip.TabIndex = 2;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // DateTimeStatusLabel
            // 
            DateTimeStatusLabel.Name = "DateTimeStatusLabel";
            DateTimeStatusLabel.Size = new Size(105, 21);
            DateTimeStatusLabel.Text = "Дата и время";
            // 
            // CurrentTimeTimer
            // 
            CurrentTimeTimer.Interval = 1000;
            CurrentTimeTimer.Tick += CurrentTimeTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 572);
            Controls.Add(MainStatusStrip);
            Controls.Add(MainMenuStrip);
            IsMdiContainer = true;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Моя крутая программа";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem AuthorizationMenuItem;
        private StatusStrip MainStatusStrip;
        private ToolStripMenuItem RegistrateMenuItem;
        private ToolStripMenuItem ColorMenuItem;
        private System.Windows.Forms.Timer CurrentTimeTimer;
        private ToolStripStatusLabel DateTimeStatusLabel;
    }
}
