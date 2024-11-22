using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_34_45
{
    public partial class ColorForm : Form
    {
        private Settings _settings;
        public ColorForm()
        {
            InitializeComponent();
            _settings = Settings.Instance;
        }

        private void Color_Changed(object sender, EventArgs e)
        {
            if (sender is TrackBar)
            {
                RedNumericUpDown.Value = RedTrackBar.Value;
                GreenNumericUpDown.Value = GreenTrackBar.Value;
                BlueNumericUpDown.Value = BlueTrackBar.Value;
            }
            else
            {
                RedTrackBar.Value = (int)RedNumericUpDown.Value;
                GreenTrackBar.Value = (int)GreenNumericUpDown.Value;
                BlueTrackBar.Value = (int)BlueNumericUpDown.Value;
            }

            this.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            ColorComboBox.DataSource = typeof(Color).GetProperties()
                .Where(x => x.PropertyType == typeof(Color))
                .Select(x => x.GetValue(null)).ToList();
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = (Color)ColorComboBox.SelectedItem != Color.Transparent ? (Color)ColorComboBox.SelectedItem : Color.White;

            RedTrackBar.Value = color.R;
            GreenTrackBar.Value = color.G;
            BlueTrackBar.Value = color.B;
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            if (SelectColorDialog.ShowDialog() == DialogResult.OK)
            {
                RedTrackBar.Value = SelectColorDialog.Color.R;
                GreenTrackBar.Value = SelectColorDialog.Color.G;
                BlueTrackBar.Value = SelectColorDialog.Color.B;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            _settings.Color = BackColor;
        }
    }
}
