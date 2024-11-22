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
    public partial class TemplateForm : Form
    {
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

        private void TemplateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        protected void Navigate(Form fromForm, Form toForm)
        {
            fromForm.Hide();

            toForm.ShowDialog();

            fromForm.Show();
        }
    }
}
