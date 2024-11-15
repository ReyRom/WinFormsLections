namespace WinFormsApp_31
{
    public partial class RoleForm : Form
    {
        private UserService _userService;
        public RoleForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            _userService.Users.ForEach(u => UsersListBox.Items.Add(u));
            _userService.Admins.ForEach(a => AdminsListBox.Items.Add(a));
        }

        private void ToAdminButton_Click(object sender, EventArgs e)
        {
            var item = UsersListBox.SelectedItem as User;
            if (item != null)
            {
                item.Role = Role.Administrator;
                UsersListBox.Items.Remove(item);
                AdminsListBox.Items.Add(item);
            }
        }

        private void ToUserButton_Click(object sender, EventArgs e)
        {
            var item = AdminsListBox.SelectedItem as User;
            if (item != null)
            {
                item.Role = Role.User;
                AdminsListBox.Items.Remove(item);
                UsersListBox.Items.Add(item);
            }
        }
    }
}
