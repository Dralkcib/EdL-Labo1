using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Entreprise
    {
        public string Name { get; set; }
        public string Locality { get; set; }

        public Entreprise(string name, string locality)
        {
            Name = name;
            Locality = locality;
        }

        public override string ToString()
        {
            return Name + " " + Locality;
        }
    }
}
