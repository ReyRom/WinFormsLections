namespace WinFormsApp_34_45
{
    public partial class AuthorizationForm : TemplateForm
    {
        private UserService _userService;

        public AuthorizationForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            User? user;
            if (_userService.Authorize(LoginTextBox.Text, PasswordTextBox.Text, out user))
            {
                MessageBox.Show("Вы авторизованы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserInfoForm form = new UserInfoForm(user);
                Navigate(this, form);
            }
            else
            {
                MessageBox.Show("Ошибка авторизации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
