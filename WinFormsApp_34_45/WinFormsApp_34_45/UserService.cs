using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_34_45
{
    public class UserService
    {
        public static UserService Instance { get; } = new UserService();

        public List<User> Users { get; set; } = new List<User>();

        public void Registrate(User user)
        {
            Users.Add(user);
        }
    }
}
