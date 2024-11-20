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
        private UserService _userService;
        public RegistrationForm()
        {
            InitializeComponent();

            _userService = UserService.Instance;

            BirthDatePicker.MaxDate = DateTime.Today;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar
                = ConfirmTextBox.UseSystemPasswordChar
                = !ShowPasswordCheckBox.Checked;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                LoginTextBox.BackColor = Color.Coral;
            }
            else
            {
                LoginTextBox.BackColor = Color.White;
            }
        }

        private void ConfirmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RegButton.Enabled = ConfirmCheckBox.Checked;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Login = LoginTextBox.Text;
            user.Password = PasswordTextBox.Text;
            user.Email = EmailTextBox.Text;
            user.BirthDate = BirthDatePicker.Value;
            user.Gender = MaleRadioButton.Checked ? Gender.Male : Gender.Female;
            user.FullName = FullNameTextBox.Text;

            _userService.Registrate(user);
            MessageBox.Show("Вы зарегистрированы");
        }
    }
}
