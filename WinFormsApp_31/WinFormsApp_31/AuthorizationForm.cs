namespace WinFormsApp_31
{
    public partial class AuthorizationForm : TemplateForm
    {
        private UserService _userService;
        public AuthorizationForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
            _title = Text;
            SetStyle(this);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (_userService.Authorize(LoginTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsersForm form = new UsersForm();
                Navigate(this, form);
                Close();
            }
            else
            {
                MessageBox.Show("Доступ запрещен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else 
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
