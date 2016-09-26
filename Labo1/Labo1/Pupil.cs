using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        public delegate string DelegatePrintActivityCompulsory(Activity activity);
        public int Grade { get; set; }
        private List<Activity> lstActivities;

        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }

        private char[] pupilEvaluations;

        public char[] PupilEvaluations
        {
            get { return pupilEvaluations; }
            set { pupilEvaluations = value; }
        }

        private Dictionary<String, char> pupilActivities = new Dictionary<String, char>();

        public Dictionary<String, char> PupilActivities { get; set; }

        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            PupilActivities = new Dictionary<string, char>();
            LstActivities = new List<Activity>();
            PupilEvaluations = new char[Parameter.nbMaxActivity];
        }

        public Pupil(string name, int age) : this(name, age, 1)
        {

        }

        /*public void AddActivity(String activityTitle, char eval = 'S')
        {
            PupilActivities.Add(activityTitle, eval);
        }*/


        /* public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            if (title != null) PupilActivities[title] = evaluation;
        }*/

        private string PrintActivitiesPupil()
        {
            string output = "";
            for(int i= 0; i < PupilActivities.Count; i++)
            {
                output += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : " + PupilActivities.ElementAt(i).Value;
            }
            return output;
        }

        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }

        public override string ToString()
        {
            return HeaderPupil() + PrintActivitiesPupil();
        }
        private string HeaderPupil()
        {
            if (PupilActivities.Count() == 0)
            {
                return base.ToString() + " n'a pas choisi d'activité";
            }
            else
            {
                return base.ToString() +" a choisi les activités suivantes:\n";
            }
        }

        /*private string PrintActivitiesPupil()
        {
            string output = "";
            foreach (Activity activity in LstActivities)
            {
                output += activity.ToString() + "\n";
            }

            return output;
        }*/

        /*public void AddEvaluation(string title = null, char evaluation = 'S')
        {
            if (title != null)
            {
                PupilEvaluations[LstActivities.IndexOf(LstActivities.Find(activity => activity.Name.Equals(title)))] = evaluation;
            }
        }*/

        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numAct = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires : \n";
            foreach (Activity activity in LstActivities)
                if (activity.Obligatory)
                    ch += (++numAct) + " " + MyPrintActivity(activity);
            return ch;
        }
    }

}
