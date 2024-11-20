namespace WinFormsApp_34_45
{
    public partial class UserInfoForm : TemplateForm
    {
        private User _user;
        public UserInfoForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text = _user.FullName;
            AgeLabel.Text = GetAge(_user.BirthDate).ToString();
            foreach (var item in _user.Hobby)
            {
                HobbyListBox.Items.Add(item);
            }
        }

        public int GetAge(DateTime birth)
        {
            DateTime current = DateTime.Now;
            var result = current.Year - birth.Year;
            if (birth > current.AddYears(-result)) result--;

            return result;
        }

        private void AddHobbyButton_Click(object sender, EventArgs e)
        {
            HobbyListBox.Items.Add(HobbyTextBox.Text);
            _user.Hobby.Add(HobbyTextBox.Text);

            HobbyTextBox.Text = String.Empty;
        }
    }
}
