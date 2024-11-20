using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace WinFormsApp_34_45
{
    public partial class UserListForm : TemplateForm
    {
        private UserService _userService;
        public UserListForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = _userService.Users;
        }

        private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = UsersDataGridView.Rows[e.RowIndex].DataBoundItem as User;
            UserInfoForm form = new UserInfoForm(user);

            Navigate(this, form);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (UsersSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = JsonSerializer.Serialize(_userService.Users, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) });

                File.WriteAllText(UsersSaveFileDialog.FileName, data);

                MessageBox.Show("Файл успешно сохранен");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (UsersOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = File.ReadAllText(UsersOpenFileDialog.FileName);
                var users = JsonSerializer.Deserialize<List<User>>(data);
                _userService.Users = users ?? new List<User>();

                MessageBox.Show("Данные загружены");
                UsersDataGridView.DataSource = _userService.Users;
            }
        }
    }
}
