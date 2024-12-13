namespace WinFormsBinding_34_45
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Persons = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name = "Test",
                    Age = 18
                },
                new Person()
                {
                    Id= 2,
                    Name = "Test2",
                    Age = 15
                },
                new Person()
                {
                    Id= 3,
                    Name = "Test4",
                    Age = 22
                }
            };
        }

        public string Name { get; set; }

        public string Hello => $"Привет, {Name}";

        public Person Person { get; set; }

        public List<Person> Persons { get; set; }
    }
}
