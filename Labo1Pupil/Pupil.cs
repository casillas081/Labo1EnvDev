using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Pupil
{
    class Pupil : Person
    {
        private int grade;

        public int Grade { get => grade; set => grade = value; }

        private List<Activity> lstActivities;
        private Dictionary<String, char> pupilActivities = new Dictionary<string, char>();
        

        public Pupil(string firstName, string lastName, DateTime birthday, int grade) : base(firstName,lastName,birthday)
        {
            this.grade = grade;
            lstActivities = new List<Activity>();
            //tabEval = new char[Parameter.NB_MAX_ACTIVITIES];
        }

        public Pupil(string firstName, string lastName, DateTime birthday): base(firstName, lastName,birthday)
        {
            grade = 1;
            lstActivities = new List<Activity>();
            //tabEval = new char[Parameter.NB_MAX_ACTIVITIES];
        }

        public void AddActivity(String activityTitle)
        {
            /*if (!lstActivities.Contains(activity) && lstActivities.Count() < Parameter.NB_MAX_ACTIVITIES)
            {
                lstActivities.Add(activity);
            }*/
            pupilActivities.Add(activityTitle, (char)0);
        }

        public string PrintActivity(string output)
        {
            int i = 0;
            output += "Activités suivies : \n";
            foreach (Activity activity in lstActivities)
            {
                output += activity.LibelleActivity() + " " + pupilActivities.ElementAt(i).Value + "\n";
                i++;
            }
            return output;
        }

        public void AddEvaluation(String title = " ",Parameter.Evaluation evaluation = Parameter.Evaluation.S)
        {
            int nbEval = 0;
            foreach(Activity activity in lstActivities)
            {
                nbEval++;
                if (activity.Title.Equals(title))
                    break;
            }
            pupilActivities[title] = (char)evaluation.ToString()[0];
        }

        public override string ToString()
        {
            string output = base.ToString();
            if(lstActivities.Count != 0)
            {
                output = PrintActivity(output);
            }
            return output;
        }

    }
}
