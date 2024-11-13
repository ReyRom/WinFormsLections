namespace WinFormsApp_31
{
    public partial class AuthorizationForm : TemplateForm
    {
        string _login = "admin";
        string _password = "qwerty";
        public AuthorizationForm()
        {
            InitializeComponent();
            _title = Text;
            SetStyle(this);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == _login && PasswordTextBox.Text == _password)
            {
                MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
