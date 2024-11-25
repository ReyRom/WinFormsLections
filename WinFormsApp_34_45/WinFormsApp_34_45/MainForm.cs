namespace WinFormsApp_34_45
{
    public partial class MainForm : TemplateForm
    {
        private AuthorizationForm _authorizationForm;
        public AuthorizationForm AuthorizationForm
        {
            get
            {
                bool isNull = _authorizationForm == null || _authorizationForm.IsDisposed;
                return isNull ? _authorizationForm = new AuthorizationForm() { MdiParent = this } : _authorizationForm;
            }
        }

        private RegistrationForm _registrationForm;
        public RegistrationForm RegistrationForm
        {
            get
            {
                bool isNull = _registrationForm == null || _registrationForm.IsDisposed;
                return isNull ? _registrationForm = new RegistrationForm() { MdiParent = this } : _registrationForm;
            }
        }

        private ColorForm _colorForm;
        public ColorForm ColorForm
        {
            get
            {
                bool isNull = _colorForm == null || _colorForm.IsDisposed;
                return isNull ? _colorForm = new ColorForm() { MdiParent = this } : _colorForm;
            }
        }
        private UserListForm _usersForm;
        public UserListForm UsersForm
        {
            get
            {
                bool isNull = _usersForm == null || _usersForm.IsDisposed;
                return isNull ? _usersForm = new UserListForm() { MdiParent = this } : _usersForm;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ToAuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm.Show();
        }

        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm.Show();
        }

        private void ToColorsButton_Click(object sender, EventArgs e)
        {
            ColorForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = $"{DateTime.Now}";
            MainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = $"{DateTime.Now}";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainTimer.Stop();
        }

        private void UserListMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm.Show();
        }
    }
}
