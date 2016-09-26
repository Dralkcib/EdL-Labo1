using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ProfessionalContact : Person
    {
        public string Profession { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public List<Entreprise> LstEntreprise { get; set; }

        public ProfessionalContact(string name, string lastName, string profession, int tel, string email) : base(name, lastName)
        {
            Tel = tel;
            Email = email;
            Profession = profession;
            LstEntreprise = new List<Entreprise>();
        }

        public override bool HasHisBirthday()
        {
            return false;
        }

        public void EnterpriseAdd(Entreprise entreprise)
        {
            LstEntreprise.Add(entreprise);
        }

        public override string ToString()
        {

            return base.ToString() + "(" + Tel + ")" + "\n" + Profession + "\n" + Email;
        }

        public string Print()
        {
            return Name + LastName + " est un contact professionel";
        }
    }
}
