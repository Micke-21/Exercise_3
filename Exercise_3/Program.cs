using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            try
            {
                person.Age = 55;
                person.FName = "Pelle";
                person.LName = "Karlsson";
                person.Height = 180;
                person.Weight = 50;
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine( ae.Message ); 
            }
        }
    }
}
