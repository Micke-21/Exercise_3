using System;

namespace Exercise_3
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(string firstName, string lastName)
        {
            FName = firstName;
            LName = lastName;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0.");
                }
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be min 2 and max 10 chars");
                }
                else
                {
                    fName = value;
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be min 3 and mas 15 chars");
                }
                else
                { lName = value; }
            }
        }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public override string ToString()
        {
            //return base.ToString();
            return $"{FName} {LName} is {Age} year {Height} {Weight}. ";
        }
    }
}
