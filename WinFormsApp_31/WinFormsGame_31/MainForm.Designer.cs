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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenuStrip = new MenuStrip();
            NewGameMenuItem = new ToolStripMenuItem();
            ScoreMenuItem = new ToolStripMenuItem();
            HighScoreMenuItem = new ToolStripMenuItem();
            HealthPointsMenuItem = new ToolStripMenuItem();
            GameCycleTimer = new System.Windows.Forms.Timer(components);
            FieldPanel = new Panel();
            enemy1 = new Enemy();
            _hero = new Hero();
            MainMenuStrip.SuspendLayout();
            FieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { NewGameMenuItem, ScoreMenuItem, HighScoreMenuItem, HealthPointsMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1071, 24);
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
            // HighScoreMenuItem
            // 
            HighScoreMenuItem.Name = "HighScoreMenuItem";
            HighScoreMenuItem.Size = new Size(58, 20);
            HighScoreMenuItem.Text = "Рекорд";
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
            FieldPanel.BackColor = Color.Navy;
            FieldPanel.Controls.Add(enemy1);
            FieldPanel.Controls.Add(_hero);
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.ForeColor = SystemColors.ActiveCaptionText;
            FieldPanel.Location = new Point(0, 24);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(1071, 479);
            FieldPanel.TabIndex = 2;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.BackgroundImage = (Image)resources.GetObject("enemy1.BackgroundImage");
            enemy1.BackgroundImageLayout = ImageLayout.Zoom;
            enemy1.Location = new Point(1016, 17);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(40, 40);
            enemy1.TabIndex = 3;
            // 
            // _hero
            // 
            _hero.BackColor = Color.Transparent;
            _hero.HealthPoint = 3;
            _hero.Location = new Point(523, 192);
            _hero.Name = "_hero";
            _hero.Size = new Size(50, 50);
            _hero.TabIndex = 2;
            _hero.Paint += Hero_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 503);
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
        private ToolStripMenuItem ScoreMenuItem;
        private ToolStripMenuItem HealthPointsMenuItem;
        private ToolStripMenuItem HighScoreMenuItem;
        private Enemy enemy1;
        private Hero _hero;
    }
}
