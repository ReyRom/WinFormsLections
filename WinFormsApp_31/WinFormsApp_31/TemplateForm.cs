using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_31
{
    public partial class TemplateForm : Form
    {
        protected string _title;
        private Settings _settings;
        public TemplateForm()
        {
            InitializeComponent();
            _settings = Settings.Instance;
            _settings.ColorChanged += Settings_ColorChanged;
        }

        private void Settings_ColorChanged(object? sender, EventArgs e)
        {
            BackColor = _settings.Color;
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            BackColor = _settings.Color;
        }

        public void SetStyle(Control element)
        {
            foreach (Control control in element.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }

        public void Navigate(Form formFrom, Form formTo)
        {
            formFrom.Hide();

            formTo.ShowDialog();

            formFrom.Show();
        }
    }
}
