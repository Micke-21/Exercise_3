using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.1.1
            Person person = new();

            try
            {
                person.Age = 55;
                person.FName = "Pelle";
                person.LName = "Karlsson";
                person.Height = 180;
                person.Weight = 50;

                Console.WriteLine(person);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


            // 3.1.2-5
            PersonHandler personHandler = new();
            Person phPerson1;
            Person phPerson2, phPerson3, phPerson4, phPerson5;
            try
            {
                phPerson1 = personHandler.CratePerson(
                age: 25,
                fname: "FiaLisa",
                lname: "Wagner",
                height: 165,
                weight: 45);

                personHandler.PrintPerson(phPerson1);

                // Change the person
                personHandler.SetAge(phPerson1, 7);
                personHandler.SetFName(phPerson1, "Ellen");// Kriminellen to long!
                personHandler.SetLName(phPerson1, "Knyckertz");
                personHandler.SetHeight(phPerson1, 120);
                personHandler.SetWeight(phPerson1, 35);
                Console.WriteLine("Person changed:");
                personHandler.PrintPerson(phPerson1);

                Console.WriteLine("\nnew persons added");

                phPerson2 = personHandler.CratePerson(45, "Bove", "Knyckertz", 181, 80);
                phPerson3 = personHandler.CratePerson(40, "Fia", "Knyckertz", 165, 65);
                phPerson4 = personHandler.CratePerson(12, "Ture", "Knyckertz", 130, 40);
                phPerson5 = personHandler.CratePerson(55, "Paul", "Isman", 175, 90);

                personHandler.PrintPerson(phPerson1); 
                personHandler.PrintPerson(phPerson2); 
                personHandler.PrintPerson(phPerson3); 
                personHandler.PrintPerson(phPerson4);
                personHandler.PrintPerson(phPerson5);

                Console.WriteLine("\nCalling some getters in the PersonHandler");
                Console.WriteLine("Full name: {0}", personHandler.GetFullName(phPerson2));
                Console.WriteLine("Age: {0}", personHandler.GetAge(phPerson3));
                Console.WriteLine("Height: {0}", personHandler.GetHeight(phPerson4));
                Console.WriteLine("Weight: {0}", personHandler.GetWeight(phPerson5));

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
