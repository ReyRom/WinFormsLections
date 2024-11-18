namespace WinFormsApp_34_45
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
            RedNumericUpDown = new NumericUpDown();
            GreenNumericUpDown = new NumericUpDown();
            BlueNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ColorComboBox = new ComboBox();
            SelectColorDialog = new ColorDialog();
            SelectColorButton = new Button();
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
            RedTrackBar.Location = new Point(63, 17);
            RedTrackBar.Margin = new Padding(4);
            RedTrackBar.Maximum = 255;
            RedTrackBar.Name = "RedTrackBar";
            RedTrackBar.Size = new Size(523, 45);
            RedTrackBar.TabIndex = 0;
            RedTrackBar.ValueChanged += Color_Changed;
            // 
            // GreenTrackBar
            // 
            GreenTrackBar.Location = new Point(63, 88);
            GreenTrackBar.Margin = new Padding(4);
            GreenTrackBar.Maximum = 255;
            GreenTrackBar.Name = "GreenTrackBar";
            GreenTrackBar.Size = new Size(523, 45);
            GreenTrackBar.TabIndex = 0;
            GreenTrackBar.ValueChanged += Color_Changed;
            // 
            // BlueTrackBar
            // 
            BlueTrackBar.Location = new Point(63, 160);
            BlueTrackBar.Margin = new Padding(4);
            BlueTrackBar.Maximum = 255;
            BlueTrackBar.Name = "BlueTrackBar";
            BlueTrackBar.Size = new Size(523, 45);
            BlueTrackBar.TabIndex = 0;
            BlueTrackBar.ValueChanged += Color_Changed;
            // 
            // RedNumericUpDown
            // 
            RedNumericUpDown.Location = new Point(609, 14);
            RedNumericUpDown.Margin = new Padding(4);
            RedNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            RedNumericUpDown.Name = "RedNumericUpDown";
            RedNumericUpDown.Size = new Size(77, 29);
            RedNumericUpDown.TabIndex = 1;
            RedNumericUpDown.ValueChanged += Color_Changed;
            // 
            // GreenNumericUpDown
            // 
            GreenNumericUpDown.Location = new Point(609, 85);
            GreenNumericUpDown.Margin = new Padding(4);
            GreenNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            GreenNumericUpDown.Name = "GreenNumericUpDown";
            GreenNumericUpDown.Size = new Size(77, 29);
            GreenNumericUpDown.TabIndex = 1;
            GreenNumericUpDown.ValueChanged += Color_Changed;
            // 
            // BlueNumericUpDown
            // 
            BlueNumericUpDown.Location = new Point(609, 160);
            BlueNumericUpDown.Margin = new Padding(4);
            BlueNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            BlueNumericUpDown.Name = "BlueNumericUpDown";
            BlueNumericUpDown.Size = new Size(77, 29);
            BlueNumericUpDown.TabIndex = 1;
            BlueNumericUpDown.ValueChanged += Color_Changed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 2;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 2;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 2;
            label3.Text = "B";
            // 
            // ColorComboBox
            // 
            ColorComboBox.FormattingEnabled = true;
            ColorComboBox.Location = new Point(15, 227);
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(299, 29);
            ColorComboBox.TabIndex = 3;
            ColorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(418, 229);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(268, 27);
            SelectColorButton.TabIndex = 4;
            SelectColorButton.Text = "Выбрать";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // ColorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 288);
            Controls.Add(SelectColorButton);
            Controls.Add(ColorComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BlueNumericUpDown);
            Controls.Add(GreenNumericUpDown);
            Controls.Add(RedNumericUpDown);
            Controls.Add(BlueTrackBar);
            Controls.Add(GreenTrackBar);
            Controls.Add(RedTrackBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "ColorForm";
            Text = "ColorForm";
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
        private NumericUpDown RedNumericUpDown;
        private NumericUpDown GreenNumericUpDown;
        private NumericUpDown BlueNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox ColorComboBox;
        private ColorDialog SelectColorDialog;
        private Button SelectColorButton;
    }
}