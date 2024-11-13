namespace WinFormsApp_34_45
{
    public partial class AuthorizationForm : TemplateForm
    {
        string _login = "admin";
        string _password = "qwerty";

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == _login && PasswordTextBox.Text == _password)
            {
                MessageBox.Show("Вы авторизованы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
