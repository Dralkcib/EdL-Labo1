using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Activity
    {
        public string Name { get; set; }
        public bool Obligatory { get; set; }

        public Activity(string name, bool obligatory)
        {
            Name = name;
            Obligatory = obligatory;
        }

        public override string ToString()
        {
            string output = Name;
            if(Obligatory)
            {
                output += "(obligatoire)";
            }
            return output;
        }
    }
}
