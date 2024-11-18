namespace WinFormsApp_34_45
{
    public class UserService
    {
        public static UserService Instance { get; } = new UserService();

        public List<User> Users { get; set; } = [
            new User
            {
                Login="admin",
                Password="admin",
                Email="admin@mail.ru",
                FullName="Админ Админович",
                BirthDate=new DateTime(2000,1,1), 
                Gender=Gender.Male 
            }
        ];

        public void Registrate(User user)
        {
            Users.Add(user);
        }

        public bool Authorize(string login, string password, out User? user)
        {
            user = Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            return user != null;
        }
    }
}
