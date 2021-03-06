﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person p1, Person p2)
        {
            if(p1.Name == p2.Name && p1.Age == p2.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Person p)
        {
            return p.Name.GetHashCode() ^ p.Age.GetHashCode();
        }
    }
}
