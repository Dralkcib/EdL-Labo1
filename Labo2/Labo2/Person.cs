using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
        {
            string output = Name + " " + LastName;
            if (HasHisBirthday())
            {
                output += " a son anniversaire aujourd'hui";
            }
            return output;
        }
        public abstract bool HasHisBirthday();

    }
}
