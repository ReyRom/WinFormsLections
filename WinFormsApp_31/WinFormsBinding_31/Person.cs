using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBinding_31
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }

        public override string ToString()
        {
            return $"Меня зовут {Name}, мне {Age}";
        }
    }
}
