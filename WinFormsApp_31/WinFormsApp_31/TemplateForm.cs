﻿using System;
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
        public TemplateForm()
        {
            InitializeComponent();
            _title = this.Text;
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Text = $"{_title} - {DateTime.Now}";
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
