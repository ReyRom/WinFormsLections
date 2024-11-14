using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_31
{
    public class UserService
    {
        public static UserService Instance { get; set; } = new UserService();
        private List<User> _users = [
            new User() {
                Login = "admin",
                Password = "admin",
                BirthDate = new DateTime(2000,1,1),
                Gender = Gender.Male,
                Email = "admin@admin.com",
                FullName = "Админ Админович",
                Role = Role.Administrator,
            },
            new User(){
                Login = "user",
                Password = "user",
                BirthDate = new DateTime(2000,1,1),
                Gender = Gender.Male,
                Email = "user@user.com",
                FullName = "Юзер Юзерович",
                Role = Role.User,
            }
        ];

        public void Registrate(User user)
        {
            _users.Add(user);
        }

        public bool Authorize(string login, string password)
        {
            return _users.FirstOrDefault(user => user.Login == login && user.Password == password) != null;
        }

        public List<User> Users { get { return _users.Where(x=>x.Role == Role.User).ToList(); } }
        public List<User> Admins { get { return _users.Where(x => x.Role == Role.Administrator).ToList(); } }
    }
}
