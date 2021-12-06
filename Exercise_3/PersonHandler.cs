using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CratePerson(int age, string fname,string lname, double height, double weight)
        {
            var newPerson = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };

            return newPerson;
        }
    }
}
