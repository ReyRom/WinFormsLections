namespace WinFormsGame_31
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
            NewGameMenuItem = new ToolStripMenuItem();
            GameCycleTimer = new System.Windows.Forms.Timer(components);
            FieldPanel = new Panel();
            HeroPictureBox = new PictureBox();
            MainMenuStrip.SuspendLayout();
            FieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HeroPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { NewGameMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(471, 24);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // NewGameMenuItem
            // 
            NewGameMenuItem.Name = "NewGameMenuItem";
            NewGameMenuItem.Size = new Size(81, 20);
            NewGameMenuItem.Text = "Новая игра";
            // 
            // GameCycleTimer
            // 
            GameCycleTimer.Interval = 40;
            GameCycleTimer.Tick += GameCycleTimer_Tick;
            // 
            // FieldPanel
            // 
            FieldPanel.Controls.Add(HeroPictureBox);
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.ForeColor = SystemColors.ActiveCaptionText;
            FieldPanel.Location = new Point(0, 24);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(471, 479);
            FieldPanel.TabIndex = 2;
            // 
            // HeroPictureBox
            // 
            HeroPictureBox.BackColor = Color.Blue;
            HeroPictureBox.Location = new Point(221, 386);
            HeroPictureBox.Name = "HeroPictureBox";
            HeroPictureBox.Size = new Size(50, 58);
            HeroPictureBox.TabIndex = 1;
            HeroPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 503);
            Controls.Add(FieldPanel);
            Controls.Add(MainMenuStrip);
            Name = "MainForm";
            Text = "Главная";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            FieldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HeroPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.Timer GameCycleTimer;
        private Panel FieldPanel;
        private PictureBox HeroPictureBox;
    }
}
