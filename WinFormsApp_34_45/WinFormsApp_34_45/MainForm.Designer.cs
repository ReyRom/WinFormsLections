
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
            components = new System.ComponentModel.Container();
            MainMenuStrip = new MenuStrip();
            RegistrateMenuItem = new ToolStripMenuItem();
            AuthorizationMenuItem = new ToolStripMenuItem();
            ColorMenuItem = new ToolStripMenuItem();
            MainStatusStrip = new StatusStrip();
            TimeStatusLabel = new ToolStripStatusLabel();
            MainTimer = new System.Windows.Forms.Timer(components);
            MainMenuStrip.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { RegistrateMenuItem, AuthorizationMenuItem, ColorMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(919, 29);
            MainMenuStrip.TabIndex = 1;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // RegistrateMenuItem
            // 
            RegistrateMenuItem.Name = "RegistrateMenuItem";
            RegistrateMenuItem.Size = new Size(112, 25);
            RegistrateMenuItem.Text = "Регистрация";
            RegistrateMenuItem.Click += ToRegistrationButton_Click;
            // 
            // AuthorizationMenuItem
            // 
            AuthorizationMenuItem.Name = "AuthorizationMenuItem";
            AuthorizationMenuItem.Size = new Size(65, 25);
            AuthorizationMenuItem.Text = "Войти";
            AuthorizationMenuItem.Click += ToAuthorizationButton_Click;
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(57, 25);
            ColorMenuItem.Text = "Цвет";
            ColorMenuItem.Click += ToColorsButton_Click;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { TimeStatusLabel });
            MainStatusStrip.Location = new Point(0, 483);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(919, 26);
            MainStatusStrip.TabIndex = 2;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // TimeStatusLabel
            // 
            TimeStatusLabel.Name = "TimeStatusLabel";
            TimeStatusLabel.Size = new Size(105, 21);
            TimeStatusLabel.Text = "Дата и время";
            // 
            // MainTimer
            // 
            MainTimer.Interval = 1000;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 509);
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
        private StatusStrip MainStatusStrip;
        private System.Windows.Forms.Timer MainTimer;
        private ToolStripMenuItem RegistrateMenuItem;
        private ToolStripMenuItem AuthorizationMenuItem;
        private ToolStripMenuItem ColorMenuItem;
        private ToolStripStatusLabel TimeStatusLabel;
    }
}
