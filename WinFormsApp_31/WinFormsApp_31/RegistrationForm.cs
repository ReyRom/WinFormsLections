using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_31
{
    public partial class RegistrationForm : TemplateForm
    {
        private UserService _userService;
        public RegistrationForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void ConfirmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RegButton.Enabled = ConfirmCheckBox.Checked;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                builder.AppendLine("Логин не должен быть пустым");
            }
            if (String.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                builder.AppendLine("Пароль не должен быть пустым");
            }
            if (PasswordTextBox.Text != ConfirmTextBox.Text)
            {
                builder.AppendLine("Пароль и подтверждение пароля не совпадают");
            }
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpper = new Regex(@"[A-ZА-Я]+");
            var hasLower = new Regex(@"[a-zа-я]+");
            var hasMin8Chars = new Regex(@".{8,}");

            if (!hasNumber.IsMatch(PasswordTextBox.Text))
            {
                builder.AppendLine("Пароль должен содержать цифру");
            }
            if (!hasUpper.IsMatch(PasswordTextBox.Text))
            {
                builder.AppendLine("Пароль должен содержать символ в верхнем регистре");
            }
            if (!hasLower.IsMatch(PasswordTextBox.Text))
            {
                builder.AppendLine("Пароль должен содержать символ в нижнем регистре");
            }
            if (!hasMin8Chars.IsMatch(PasswordTextBox.Text))
            {
                builder.AppendLine("Пароль должен содержать не менее 8 символов");
            }

            var isValidEmail = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");

            if (!isValidEmail.IsMatch(EmailTextBox.Text))
            {
                builder.AppendLine("Указан некорректный email");
            }


            if (builder.Length > 0)
            {
                MessageBox.Show(builder.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            User user = new User();

            user.Login = LoginTextBox.Text;
            user.Password = PasswordTextBox.Text;
            user.Email = EmailTextBox.Text;
            user.BirthDate = BirthDateTimePicker.Value;
            user.FullName = FullNameTextBox.Text;
            user.Gender = MaleRadioButton.Checked ? Gender.Male : Gender.Female;

            _userService.Registrate(user);

            MessageBox.Show($"{user.Login}, Вы зарегистрированы");
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            RegistrationCaptcha.Renew();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            RegistrationCaptcha.Renew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegistrationCaptcha.IsCorrectText(CaptchaTextBox.Text))
            {
                MessageBox.Show("Ты кожаный мешок");
            }
            else
            {
                MessageBox.Show("Приветствую, брат");
            }
        }
    }
}
