namespace WinFormsGame_34_45
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
            GameTimer = new System.Windows.Forms.Timer(components);
            GameMenuStrip = new MenuStrip();
            NewGameMenuItem = new ToolStripMenuItem();
            GameStatusStrip = new StatusStrip();
            ScoreStatusLabel = new ToolStripStatusLabel();
            HealthPointsStatusLabel = new ToolStripStatusLabel();
            HighScoreStatusLabel = new ToolStripStatusLabel();
            FieldPanel = new Panel();
            CoolHero = new Hero();
            GameMenuStrip.SuspendLayout();
            GameStatusStrip.SuspendLayout();
            FieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Interval = 40;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // GameMenuStrip
            // 
            GameMenuStrip.Items.AddRange(new ToolStripItem[] { NewGameMenuItem });
            GameMenuStrip.Location = new Point(0, 0);
            GameMenuStrip.Name = "GameMenuStrip";
            GameMenuStrip.Size = new Size(800, 24);
            GameMenuStrip.TabIndex = 0;
            GameMenuStrip.Text = "menuStrip1";
            // 
            // NewGameMenuItem
            // 
            NewGameMenuItem.Name = "NewGameMenuItem";
            NewGameMenuItem.Size = new Size(81, 20);
            NewGameMenuItem.Text = "Новая игра";
            NewGameMenuItem.Click += NewGameMenuItem_Click;
            // 
            // GameStatusStrip
            // 
            GameStatusStrip.Items.AddRange(new ToolStripItem[] { ScoreStatusLabel, HealthPointsStatusLabel, HighScoreStatusLabel });
            GameStatusStrip.Location = new Point(0, 428);
            GameStatusStrip.Name = "GameStatusStrip";
            GameStatusStrip.Size = new Size(800, 22);
            GameStatusStrip.TabIndex = 1;
            GameStatusStrip.Text = "statusStrip1";
            // 
            // ScoreStatusLabel
            // 
            ScoreStatusLabel.Name = "ScoreStatusLabel";
            ScoreStatusLabel.Size = new Size(45, 17);
            ScoreStatusLabel.Text = "Счет: 0";
            // 
            // HealthPointsStatusLabel
            // 
            HealthPointsStatusLabel.Name = "HealthPointsStatusLabel";
            HealthPointsStatusLabel.Size = new Size(35, 17);
            HealthPointsStatusLabel.Text = "HP: 3";
            // 
            // HighScoreStatusLabel
            // 
            HighScoreStatusLabel.Name = "HighScoreStatusLabel";
            HighScoreStatusLabel.Size = new Size(58, 17);
            HighScoreStatusLabel.Text = "Рекорд: 0";
            // 
            // FieldPanel
            // 
            FieldPanel.Controls.Add(CoolHero);
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.Location = new Point(0, 24);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(800, 404);
            FieldPanel.TabIndex = 2;
            // 
            // CoolHero
            // 
            CoolHero.BackColor = Color.Transparent;
            CoolHero.BackgroundImageLayout = ImageLayout.Zoom;
            CoolHero.HealthPoints = 3;
            CoolHero.Location = new Point(381, 180);
            CoolHero.Name = "CoolHero";
            CoolHero.Size = new Size(30, 30);
            CoolHero.TabIndex = 0;
            CoolHero.Paint += CoolHero_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FieldPanel);
            Controls.Add(GameStatusStrip);
            Controls.Add(GameMenuStrip);
            MainMenuStrip = GameMenuStrip;
            Name = "MainForm";
            Text = "Моя крутая игра";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            GameMenuStrip.ResumeLayout(false);
            GameMenuStrip.PerformLayout();
            GameStatusStrip.ResumeLayout(false);
            GameStatusStrip.PerformLayout();
            FieldPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private MenuStrip GameMenuStrip;
        private StatusStrip GameStatusStrip;
        private Panel FieldPanel;
        private Hero CoolHero;
        private ToolStripStatusLabel ScoreStatusLabel;
        private ToolStripStatusLabel HealthPointsStatusLabel;
        private ToolStripMenuItem NewGameMenuItem;
        private ToolStripStatusLabel HighScoreStatusLabel;
    }
}
