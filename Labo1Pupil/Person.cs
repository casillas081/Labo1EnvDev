using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Pupil
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;

        // Propriété 

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public DateTime Birthday() => this.birthday;

        public Person(string firstName,string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            this.birthday = birthday;
        }

        //public string GetFirstName()
        //{
        //    return this.firstName;
        //}

        //public void SetFirstName(string firstName)
        //{
        //    this.firstName = firstName;
        //}

        //public string GetCoord()
        //{
        //    return this.firstName + " " + this.lastName;
        //}        

        // Chaine de caractères de la date

        public string GetStringBirthday()
        {
            string chaine = Birthday().Day.ToString() + " / " + Birthday().Month.ToString() + " / " + Birthday().Year.ToString();

            return chaine; 
        }

        // Methode ToString

        public override string ToString()
        {
            string output = "Nom et prénom : " + this.LastName + " " + this.FirstName + "\n";

            output += "Date de naissance : " + this.GetStringBirthday() + "\n";

            return output;
        }

    }
}
