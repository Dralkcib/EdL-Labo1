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

            List<Pupil> lstPupil = new List<Pupil>();
            lstPupil.Add(new Pupil("Mathieux", 6, 1));
            lstPupil.Add(new Pupil("Maxime", 9, 3));
            lstPupil.Add(new Pupil("Alexandre", 7, 1));
            lstPupil.Add(new Pupil("Jason", 4, 1));
            lstPupil.Add(new Pupil("Randomer", 5, 2));

            var pupilGrade1Plus6 = from pupil in lstPupil
                                   where pupil.Grade == 1 && pupil.Age >= 6
                                   select pupil;

            if(pupilGrade1Plus6 != null)
            {
                foreach(Pupil pupil in pupilGrade1Plus6)
                {
                    System.Console.WriteLine(pupil);
                }
            }
            System.Console.Read();
        }
    }
}
