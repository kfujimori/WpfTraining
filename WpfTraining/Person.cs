using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTraining
{

    public enum Gender
    {
        none,
        men,
        women
    }

    class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public bool AuthMember { get; set; }

        public Person() { }

        public Person(Person source)
        {
            this.Name = source.Name;
            this.Gender = source.Gender;
            this.Age = source.Age;
            this.AuthMember = source.AuthMember;
        }

    }
}
