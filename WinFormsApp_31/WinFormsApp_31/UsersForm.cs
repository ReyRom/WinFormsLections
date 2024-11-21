using System.Collections.ObjectModel;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace WinFormsApp_31
{
    public partial class UsersForm : TemplateForm
    {
        private UserService _userService;
        public UsersForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = _userService.AllUsers;
        }

        private void RolesButton_Click(object sender, EventArgs e)
        {
            RoleForm form = new RoleForm();
            Navigate(this, form);
        }

        private void SaveUsersButton_Click(object sender, EventArgs e)
        {
            if (UsersSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = JsonSerializer.Serialize(_userService.AllUsers,
                    new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) });
                try
                {
                    File.WriteAllText(UsersSaveFileDialog.FileName, data);
                    MessageBox.Show("Данные сохранены", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void LoadUsersButton_Click(object sender, EventArgs e)
        {
            if (UsersOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = File.ReadAllText(UsersOpenFileDialog.FileName);
                    var users = JsonSerializer.Deserialize<List<User>>(data);
                    _userService.AllUsers = users ?? new List<User>();
                    MessageBox.Show("Данные загружены", "Успех");
                    UsersDataGridView.DataSource = _userService.AllUsers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersDataGridView.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                var user = UsersDataGridView.Rows[e.RowIndex].DataBoundItem as User;
                _userService.AllUsers.Remove(user);
                UsersDataGridView.DataSource = null;
                UsersDataGridView.DataSource = _userService.AllUsers;
            }
        }

        private void UsersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
