namespace WinFormsApp_31
{
    partial class ColorForm
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
            RedTrackBar = new TrackBar();
            GreenTrackBar = new TrackBar();
            BlueTrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RedNumericUpDown = new NumericUpDown();
            GreenNumericUpDown = new NumericUpDown();
            BlueNumericUpDown = new NumericUpDown();
            ColorComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)RedTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // RedTrackBar
            // 
            RedTrackBar.Location = new Point(52, 37);
            RedTrackBar.Margin = new Padding(4);
            RedTrackBar.Maximum = 255;
            RedTrackBar.Name = "RedTrackBar";
            RedTrackBar.Size = new Size(451, 45);
            RedTrackBar.TabIndex = 0;
            RedTrackBar.ValueChanged += Color_ValueChanged;
            // 
            // GreenTrackBar
            // 
            GreenTrackBar.Location = new Point(52, 89);
            GreenTrackBar.Maximum = 255;
            GreenTrackBar.Name = "GreenTrackBar";
            GreenTrackBar.Size = new Size(451, 45);
            GreenTrackBar.TabIndex = 1;
            GreenTrackBar.ValueChanged += Color_ValueChanged;
            // 
            // BlueTrackBar
            // 
            BlueTrackBar.Location = new Point(52, 140);
            BlueTrackBar.Maximum = 255;
            BlueTrackBar.Name = "BlueTrackBar";
            BlueTrackBar.Size = new Size(451, 45);
            BlueTrackBar.TabIndex = 2;
            BlueTrackBar.ValueChanged += Color_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 3;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 4;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 140);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // RedNumericUpDown
            // 
            RedNumericUpDown.Location = new Point(529, 35);
            RedNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            RedNumericUpDown.Name = "RedNumericUpDown";
            RedNumericUpDown.Size = new Size(67, 29);
            RedNumericUpDown.TabIndex = 6;
            RedNumericUpDown.ValueChanged += Color_ValueChanged;
            // 
            // GreenNumericUpDown
            // 
            GreenNumericUpDown.Location = new Point(529, 87);
            GreenNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            GreenNumericUpDown.Name = "GreenNumericUpDown";
            GreenNumericUpDown.Size = new Size(67, 29);
            GreenNumericUpDown.TabIndex = 7;
            GreenNumericUpDown.ValueChanged += Color_ValueChanged;
            // 
            // BlueNumericUpDown
            // 
            BlueNumericUpDown.Location = new Point(529, 138);
            BlueNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            BlueNumericUpDown.Name = "BlueNumericUpDown";
            BlueNumericUpDown.Size = new Size(67, 29);
            BlueNumericUpDown.TabIndex = 8;
            BlueNumericUpDown.ValueChanged += Color_ValueChanged;
            // 
            // ColorComboBox
            // 
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(185, 191);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(275, 29);
            ColorComboBox.TabIndex = 9;
            ColorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
            // 
            // ColorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 245);
            Controls.Add(ColorComboBox);
            Controls.Add(BlueNumericUpDown);
            Controls.Add(GreenNumericUpDown);
            Controls.Add(RedNumericUpDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BlueTrackBar);
            Controls.Add(GreenTrackBar);
            Controls.Add(RedTrackBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "ColorForm";
            Text = "Цвета";
            Load += ColorForm_Load;
            ((System.ComponentModel.ISupportInitialize)RedTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar RedTrackBar;
        private TrackBar GreenTrackBar;
        private TrackBar BlueTrackBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown RedNumericUpDown;
        private NumericUpDown GreenNumericUpDown;
        private NumericUpDown BlueNumericUpDown;
        private ComboBox ColorComboBox;
    }
}