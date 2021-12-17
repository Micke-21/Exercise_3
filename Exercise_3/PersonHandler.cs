using System;

namespace Exercise_3
{
    public class PersonHandler
    {

        public Person CratePerson(int age, string fname, string lname, double height, double weight)
        {
            var newPerson = new Person(fname, lname)
            {
                Age = age,
                //FName = fname,
                //LName = lname,
                Height = height,
                Weight = weight
            };

            return newPerson;
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string name)
        {
            pers.FName = name;
        }

        public void SetLName(Person pers, string name)
        {
            pers.LName = name;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public string GetFullName(Person person)
        {
            return $"{person.FName} {person.LName}";
        }


        public int GetAge(Person person)
        {
            return person.Age;
        }

        public double GetHeight(Person person)
        {
            return person.Height;
        }

        public double GetWeight(Person person)
        {
            return person.Weight;
        }


        public void PrintPerson(Person pers)
        {
            //Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Age} year, {pers.Height}, {pers.Weight}. ");
            Console.WriteLine(pers);
        }

    }
}
