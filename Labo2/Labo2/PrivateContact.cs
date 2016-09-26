using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class PrivateContact : Person
    {
        public int Tel { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public PrivateContact(string name, string lastName, int tel, string email, DateTime birthday) : this(name, lastName, tel, email)
        {
            Birthday = birthday;
        }
        public PrivateContact(string name, string lastName, int tel, string email) : base(name, lastName)
        {
            Tel = tel;
            Email = email;
            Birthday = new DateTime();
        }
        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == Birthday.Month && DateTime.Today.Day == Birthday.Day);
        }

        public override string ToString()
        {
            return base.ToString() + " " + Tel + " " + Email;
        }

        public string Print()
        {
            return Name + LastName + " est un contact privé";
        }
    }
}
