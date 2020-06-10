using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Ado.Entities
{
    public class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        public User(string name, DateTime dateOfBirth, int age)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;
        }
    }
}
