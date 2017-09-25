using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1Pupil
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person person1, Person person2)
        {
            if(GetHashCode(person1) == GetHashCode(person2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Person person)
        {
            return person.LastName.GetHashCode()^person.FirstName.GetHashCode();
        }
    }
}
