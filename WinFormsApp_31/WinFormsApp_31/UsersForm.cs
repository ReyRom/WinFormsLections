using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
