namespace WinFormsApp_31
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void Color_ValueChanged(object sender, EventArgs e)
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
            BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
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
    }
}
