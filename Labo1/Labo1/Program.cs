using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pupil pupil = new Pupil("Thomas", 8);
             Activity act1 = new Activity("Mathématiques", true);
             Activity act2 = new Activity("Français", true);
             Activity act3 = new Activity("Histoire", false);
             Activity coloriage = new Activity("Coloriage", true);


             pupil.AddActivity(act1);
             pupil.AddActivity(act2);
             pupil.AddActivity(act3);
             pupil.AddActivity(coloriage);
             pupil.AddEvaluation("Coloriage");
             pupil.AddEvaluation(evaluation: 'T', title: "Mathématiques");

             System.Console.Write(pupil.TabEval[3]);

             System.Console.Write(pupil);
             System.Console.Read();*/

            /*List<Pupil> lstPupil = new List<Pupil>()
            { 
                new Pupil("Mathieux", 6, 1),
                new Pupil("Maxime", 9, 3),
                new Pupil("Alexandre", 7, 1),
                new Pupil("Jason", 4, 1),
                new Pupil("Randomer", 5, 2)
            };

            List<Person> lstPerson = new List<Person>()
            {
                new Person("MathieuxP", 6),
                new Person("MaximeP", 9),
                new Person("AlexandreP", 7),
                new Person("JasonP", 4),
                new Person("RandomerP", 5)
            };

            var listFusion = lstPerson.Union(lstPupil);

            foreach(Person person in listFusion)
            {
                System.Console.WriteLine(person);
            }*/

            /* var pupilGrade1Plus6 = from pupil in lstPupil
                                    select pupil;

             pupilGrade1Plus6 = pupilGrade1Plus6.Where(pupil => pupil.Age >= 6 && pupil.Grade == 1);

             if (pupilGrade1Plus6 != null)
             {
                 foreach(Pupil pupil in pupilGrade1Plus6)
                 {
                     System.Console.WriteLine(pupil);
                 }
             }*/


            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Mathieux", 6, 1),
                new Pupil("Maxime", 9, 3),
                new Pupil("Alexandre", 7, 1),
                new Pupil("Jason", 4, 1),
                new Pupil("Randomer", 5, 2),
                new Pupil("Maxime", 9, 3),
                new Pupil("Alexandre", 7, 1),
                new Pupil("Jason", 4, 1),
            };

            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            foreach (Pupil pupil in listPupilsNoDuplicated)
            {
                System.Console.WriteLine(pupil);
            }
            System.Console.Read();
        }
    }
}
