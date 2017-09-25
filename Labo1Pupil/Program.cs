using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Pupil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("Christophe", "Schepmans", new DateTime(1994,9,8));

            //Console.WriteLine(person1);
            //Console.ReadKey();

            //Activity activity1 = new Activity("Mathématiques", true);
            //Activity activity2 = new Activity("Français", true);
            //Activity activity3 = new Activity("Sciences appliquées", true);
            //Activity activity4 = new Activity("Géographie", true);
            //Activity activity5 = new Activity("Histoire", true);
            //Activity activity6 = new Activity("Religion", false);
            //Activity activity7 = new Activity("Morale", false);
            //Activity activity8 = new Activity("Anglais", false);
            //Activity activity9 = new Activity("Néerlandais", true);
            //Activity activity10 = new Activity("Ordinateur", false);
            //Activity activity11 = new Activity("Droit à rien faire", false);
            
            //Pupil pupil1 = new Pupil("Martin", "Rouffiange", new DateTime(1994, 9, 16), 4);
            //pupil1.AddActivity(activity1);
            //pupil1.AddActivity(activity2);
            //pupil1.AddActivity(activity3);
            //pupil1.AddActivity(activity4);
            //pupil1.AddActivity(activity5);
            //pupil1.AddActivity(activity6);
            //pupil1.AddActivity(activity7);
            //pupil1.AddActivity(activity8);
            //pupil1.AddActivity(activity9);
            //pupil1.AddActivity(activity10);
            //pupil1.AddActivity(activity11);
            //pupil1.AddEvaluation(activity1.Title);
            //pupil1.AddEvaluation(evaluation: Parameter.Evaluation.T, title: "Anglais");

            //Console.WriteLine(pupil1);
            //Console.ReadKey();

            //Pupil pupil2 = new Pupil("Sebastien", "Lagneaux", new DateTime(1993, 10, 21));
            //pupil2.AddActivity(activity1);
            //pupil2.AddActivity(activity2);
            //pupil2.AddActivity(activity3);
            //pupil2.AddActivity(activity4);
            //pupil2.AddActivity(activity5);
            //pupil2.AddActivity(activity9);
            //pupil2.AddActivity(activity7);

            //Console.WriteLine(pupil2);
            //Console.ReadKey();

            //List<Pupil> lstPupils = new List<Pupil>()
            //{
            //    new Pupil("Loïc","Cheron",new DateTime(1993,10,18),3),
            //    new Pupil("Loïc","Michelet",new DateTime(2011,10,21),1),
            //    new Pupil("Loïc","Zimba",new DateTime(1994,10,18),2),
            //    new Pupil("Loïc","Cheron",new DateTime(2011,08,18),2),
            //    new Pupil("Loïc","Hyalol",new DateTime(1999,10,18),1),
            //};

            ////LINQ
            ///*var pupilGradeEqual1Birthday2011 = from pupil in lstPupils
            //                                   where pupil.Birthday().Year == 2011 && pupil.Grade == 1
            //                                   select pupil;
            //*/

            //var pupilGradeEqual1Birthday2011 = lstPupils.Where(pupil => pupil.Birthday().Year == 2011 && pupil.Grade == 1);

            //if (pupilGradeEqual1Birthday2011 != null)
            //{
            //    foreach(var pupil12011 in pupilGradeEqual1Birthday2011)
            //    {
            //        Console.WriteLine(pupil12011);
                    
            //    }
            //}
            //Console.ReadKey();

            //List<Person> lstPersons = new List<Person>()
            //{
            //    new Person("Mathilde","Cheron",new DateTime(1998,05,13)),
            //    new Person("Annick","Michelet",new DateTime(1142,10,21)),
            //    new Person("Bwé","Zimba",new DateTime(1994,01,7)),
            //    new Person("Bastienne","Cheron",new DateTime(1987,08,24)),
            //    new Person("Clovis","Hyalol",new DateTime(1994,09,25)),
            //};

            //var listFusion = lstPersons.Union(lstPupils);

            //if(listFusion != null)
            //{
            //    foreach(var fusion in listFusion)
            //    {
            //        Console.WriteLine(fusion);
            //    }
            //}

            //Console.ReadKey();

            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Loic","Cheron",new DateTime(1993,10,18),3),
                new Pupil("Loic","Michelet",new DateTime(2011,10,21),1),
                new Pupil("Loic","Zimba",new DateTime(1994,10,18),2),
                new Pupil("Loic","Cheron",new DateTime(1993,10,18),3),
                new Pupil("Loic","Michelet",new DateTime(2011,10,21),1),
            };

            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            if(listPupilsNoDuplicated != null)
            {
                foreach (Pupil PupilsNoDuplicated in listPupilsNoDuplicated)
                {
                    Console.WriteLine(PupilsNoDuplicated);
                }

            }

            Console.ReadKey();

        }
    }
}
