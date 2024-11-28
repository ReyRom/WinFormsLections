using System.Collections.ObjectModel;

namespace WinFormsApp_31
{
    public sealed class UserService
    {
        private UserService() { }
        private static UserService? _instance;
        public static UserService Instance { get => _instance ??= new UserService(); }


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
            },
            new User(){
                Login = "reyrom",
                Password = "reyrom",
                BirthDate = new DateTime(2000,1,1),
                Gender = Gender.Male,
                Email = "reyrom@reyrom.com",
                FullName = "Роман Садовский",
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

        public List<User> Users { get => _users.Where(x => x.Role == Role.User).ToList(); }
        public List<User> Admins { get => _users.Where(x => x.Role == Role.Administrator).ToList(); }
        public List<User> AllUsers { get => _users; set => _users = value; }
    }
}
