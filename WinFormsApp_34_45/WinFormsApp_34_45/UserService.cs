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
            },
            new User
            {
                Login="user",
                Password="qwerty",
                Email="user@mail.ru",
                FullName="Юзер Юзерович",
                BirthDate=new DateTime(2000,1,1),
                Gender=Gender.Male
            },
            new User
            {
                Login="fuser",
                Password="asd123",
                Email="fuser@mail.ru",
                FullName="Юзерка Юзеровна",
                BirthDate=new DateTime(2000,1,1),
                Gender=Gender.Female
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
