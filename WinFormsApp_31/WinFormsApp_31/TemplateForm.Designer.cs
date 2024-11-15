namespace WinFormsApp_31
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
            timer = new System.Windows.Forms.Timer(components);
            TimeLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += Timer_Tick;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = Color.Transparent;
            TimeLabel.Location = new Point(12, 7);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(52, 21);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(TimeLabel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 40);
            panel1.TabIndex = 2;
            // 
            // TemplateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(464, 299);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "TemplateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TemplateForm";
            Load += TemplateForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Label TimeLabel;
        private Panel panel1;
    }
}