using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsBinding_31
{
    public class MainViewModel:ViewModelBase
    {
        

        public MainViewModel()
        {
            Persons = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name = "Foo",
                    Age = 1,
                },
                new Person()
                {
                    Id = 2,
                    Name = "Bar",
                    Age = 3,
                },
                new Person()
                {
                    Id = 3,
                    Name = "FooBar",
                    Age = 4,
                },
            };

            IncrementCommand = new Command(_ =>
            {
                Count++;
            });
        }

        private int count = 0;
        public int Count
        {
            get => count; set
            {
                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }
        public string Name { get; set; }

        public Person SelectedPerson { get; set; }
        public List<Person> Persons { get; set; }

        public ICommand IncrementCommand { get; set; } 
    }
}
