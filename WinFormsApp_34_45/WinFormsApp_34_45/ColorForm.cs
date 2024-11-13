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
        public ColorForm()
        {
            InitializeComponent();
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
    }
}
