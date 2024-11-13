namespace WinFormsApp_31
{
    public partial class MainForm : TemplateForm
    {
        public MainForm()
        {
            InitializeComponent();
            _title = Text;
            SetStyle(this);
        }

        private void ToAuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            Navigate(this, form);
        }


        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            Navigate(this, form);
        }
    }
}
