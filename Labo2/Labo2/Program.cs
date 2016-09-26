using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
             PrivateContact contact1 = new PrivateContact("Po Ojoure", "Dui :(", 081659835, "PoOjoureDui@gmail.com");
             PrivateContact contact2 = new PrivateContact("Ojoure", "Dui", 081659836, "OjoureDui@gmail.com", new DateTime(2016, 9, 26));
             ProfessionalContact consultant1 = new ProfessionalContact("Kons'ul", "Tanun", "Consultant", 081796859, "KonsulTanun@gmail.com");
             ProfessionalContact consultant2 = new ProfessionalContact("Quons'ul", "TanDeu", "Consultant", 081796859, "QuonsulTandue@gmail.com");
             ProfessionalContact independant = new ProfessionalContact("Undé", "Panden", "Independant", 081796859, "UndéPanden@gmail.com");


             List<ProfessionalContact> lstProfessionalContact = new List<ProfessionalContact>();
             lstProfessionalContact.Add(consultant1);
             lstProfessionalContact.Add(consultant2);
             lstProfessionalContact.Add(independant);

             Entreprise entreprise1 = new Entreprise("Antro Prise", "Andenne");
             Entreprise entreprise2 = new Entreprise("Antr'O Prize", "Liège");

             consultant1.EnterpriseAdd(entreprise1);
             consultant1.EnterpriseAdd(entreprise2);
             consultant2.EnterpriseAdd(entreprise1);

             var lstInde = from ProfessionalContact in lstProfessionalContact
                           where ProfessionalContact.LstEntreprise.Count == 0
                           select ProfessionalContact;

             var lstConsultantEntrepise1 = lstProfessionalContact.FindAll(c => c.LstEntreprise.Contains(entreprise1));


            /*Console.WriteLine(contact1);
            Console.WriteLine(contact2);*/

            /*foreach(ProfessionalContact contact in lstInde)
            {
                Console.WriteLine(contact + "\n");
            }*/

            Car car1 = new Labo2.Car(22);
            ContacCar contactCar1 = new ContacCar(car1, consultant1);
            contactCar1.DynamicPrint();

            Car car2 = new Labo2.Car(48);
            ContacCar contactCar2 = new ContacCar(car1, contact1);
            contactCar2.DynamicPrint();

            Console.Read();
        }
    }
}
