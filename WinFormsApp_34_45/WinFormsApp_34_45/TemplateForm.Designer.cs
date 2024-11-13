namespace WinFormsApp_34_45
{
    partial class TemplateForm
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
            components = new System.ComponentModel.Container();
            FooterPanel = new Panel();
            TimeLabel = new Label();
            DateTimeTimer = new System.Windows.Forms.Timer(components);
            FooterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FooterPanel
            // 
            FooterPanel.Controls.Add(TimeLabel);
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 387);
            FooterPanel.Margin = new Padding(4);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(551, 30);
            FooterPanel.TabIndex = 0;
            // 
            // TimeLabel
            // 
            TimeLabel.Dock = DockStyle.Left;
            TimeLabel.Location = new Point(0, 0);
            TimeLabel.Margin = new Padding(4, 0, 4, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(222, 30);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "label1";
            TimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DateTimeTimer
            // 
            DateTimeTimer.Interval = 1000;
            DateTimeTimer.Tick += DateTimeTimer_Tick;
            // 
            // TemplateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(551, 417);
            Controls.Add(FooterPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "TemplateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TemplateForm";
            FormClosed += TemplateForm_FormClosed;
            Load += TemplateForm_Load;
            FooterPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel FooterPanel;
        private Label TimeLabel;
        private System.Windows.Forms.Timer DateTimeTimer;
    }
}