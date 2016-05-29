using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTraining2
{
    class Person
    {
        public string Name { get; set; }
        public List<Person> Children { get; set; }
    }
}
