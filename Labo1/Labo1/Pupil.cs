using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        public int Grade { get; set; }
        private List<Activity> lstActivities;

        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }

        private char[] tabEval;

        public char[] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }

        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[Parameter.nbMaxActivity];
        }

        public Pupil(string name, int age) : this(name, age, 1)
        {

        }

        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }

        public override string ToString()
        {
            string output = base.ToString();
            if (LstActivities.Count() == 0)
            {
                output += " n'a pas choisi d'activité";
            }
            else
            {
                output += " a choisi les activités suivantes:\n";
                foreach (Activity activity in LstActivities)
                {
                    output += activity.ToString() + "\n";
                }

            }
            return output;
        }

        public void AddEvaluation(string title = null, char evaluation = 'S')
        {
            if (title != null)
            {
                Activity activity = LstActivities.Find(x => x.Name.Equals(title));
                TabEval[LstActivities.IndexOf(activity)] = evaluation;
            }
        }
    }
    
}
