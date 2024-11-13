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
    public partial class RegistrationForm : TemplateForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            BirthDatePicker.MaxDate = DateTime.Today;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar 
                = ConfirmTextBox.UseSystemPasswordChar 
                = !ShowPasswordCheckBox.Checked;
            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
