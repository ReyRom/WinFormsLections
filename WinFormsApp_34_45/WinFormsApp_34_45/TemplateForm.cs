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
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
            DateTimeTimer.Start();
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void TemplateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DateTimeTimer.Stop();
        }
        protected void Navigate(Form fromForm, Form toForm)
        {
            fromForm.Hide();

            toForm.ShowDialog();

            fromForm.Show();
        }
    }
}
