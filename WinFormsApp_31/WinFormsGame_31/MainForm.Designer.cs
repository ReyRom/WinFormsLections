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
            ScoreMenuItem = new ToolStripMenuItem();
            HealthPointsMenuItem = new ToolStripMenuItem();
            GameCycleTimer = new System.Windows.Forms.Timer(components);
            FieldPanel = new Panel();
            _hero = new Hero();
            MainMenuStrip.SuspendLayout();
            FieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { NewGameMenuItem, ScoreMenuItem, HealthPointsMenuItem });
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
            NewGameMenuItem.Click += NewGameMenuItem_Click;
            // 
            // ScoreMenuItem
            // 
            ScoreMenuItem.Name = "ScoreMenuItem";
            ScoreMenuItem.Size = new Size(54, 20);
            ScoreMenuItem.Text = "Score: ";
            // 
            // HealthPointsMenuItem
            // 
            HealthPointsMenuItem.Name = "HealthPointsMenuItem";
            HealthPointsMenuItem.Size = new Size(87, 20);
            HealthPointsMenuItem.Text = "HealthPoints";
            // 
            // GameCycleTimer
            // 
            GameCycleTimer.Interval = 40;
            GameCycleTimer.Tick += GameCycleTimer_Tick;
            // 
            // FieldPanel
            // 
            FieldPanel.Controls.Add(_hero);
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.ForeColor = SystemColors.ActiveCaptionText;
            FieldPanel.Location = new Point(0, 24);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(471, 479);
            FieldPanel.TabIndex = 2;
            // 
            // _hero
            // 
            _hero.BackColor = Color.Blue;
            _hero.HealthPoint = 3;
            _hero.Location = new Point(63, 209);
            _hero.Name = "_hero";
            _hero.Size = new Size(43, 54);
            _hero.TabIndex = 2;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.Timer GameCycleTimer;
        private Panel FieldPanel;
        private Hero _hero;
        private ToolStripMenuItem ScoreMenuItem;
        private ToolStripMenuItem HealthPointsMenuItem;
    }
}
