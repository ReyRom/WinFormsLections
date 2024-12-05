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
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            ScoreStatusLabel = new ToolStripStatusLabel();
            FieldPanel = new Panel();
            CoolHero = new Hero();
            statusStrip1.SuspendLayout();
            FieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Interval = 40;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ScoreStatusLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // ScoreStatusLabel
            // 
            ScoreStatusLabel.Name = "ScoreStatusLabel";
            ScoreStatusLabel.Size = new Size(33, 17);
            ScoreStatusLabel.Text = "Счет";
            // 
            // FieldPanel
            // 
            FieldPanel.Controls.Add(CoolHero);
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.Location = new Point(0, 24);
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Size = new Size(800, 404);
            FieldPanel.TabIndex = 2;
            FieldPanel.MouseClick += FieldPanel_MouseClick;
            // 
            // CoolHero
            // 
            CoolHero.BackColor = Color.Blue;
            CoolHero.Location = new Point(381, 180);
            CoolHero.Name = "CoolHero";
            CoolHero.Size = new Size(30, 30);
            CoolHero.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FieldPanel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Моя крутая игра";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            FieldPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private Panel FieldPanel;
        private Hero CoolHero;
        private ToolStripStatusLabel ScoreStatusLabel;
    }
}
