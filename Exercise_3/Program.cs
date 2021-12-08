using System;
using System.Collections.Generic;

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


            //----------------------------------------------------------------------------

            Console.WriteLine("\n\nSome animals");
            //3.3.3
            List<Animal> animals = new List<Animal>();

            //3.3.4 add animals to the list
            animals.Add(new Horse("Polle", 500, 20, HorsType.Trotter));
            animals.Add(new Dog("Fläcken", 35, 2, 40));
            animals.Add(new Hedgehog("Pigge", 2, 4, 30000));
            animals.Add(new Worm("Max", 20, 2, true));
            animals.Add(new Wolf("Devil", 23, 3, false));

            animals.Add(new Bird("Polly", 12, 1, 23));
            animals.Add(new Flamingo("Flamingo", 2, 3, 120, 40));
            animals.Add(new Swan("Svan", 3, 1, 200, 45));
            animals.Add(new Pelican("Pelle", 4, 2, 300, 20));
            animals.Add(new Wolfman("Wolf man", 78, 35, false));

            //3.3.5 Skriv ut vilka djur som finns i listan
            foreach(var a in animals)
            {
                Console.WriteLine( a.Stats());
                a.DoSound(); //3.3.6 
                //3.3.7
                if(a is IPerson)
                {
                    var p = a as IPerson;
                    p.Talk();

                }
            }

            //3.3.8 List of dogs
            List<Dog> dogs = new List<Dog>();

            //3.3.9 F: En häst är ju ingen hund
            //dogs.Add(new Horse("Hästen ´Polle", 450, 23, HorsType.Ridinghorse));
            //3.3.10 F Listan måste vara av typen Animal för att alla djur skall kunna ligga i den 

            // 3.3.11
            Console.WriteLine("\nAlla Stats()");

            foreach (var a in animals)
            {
                Console.WriteLine( $"Stats: {a.Stats()}"); 
            }

            //3.3.13 F: Förklar vad det är som händer?
            //ToDo Svara!

            //3.3.14
            Console.WriteLine("\n3.3.14 Dog.Stats()");
            foreach(var a in animals)
            {
                if(a is Dog){
                    Console.WriteLine($"Dog.Stats: {a.Stats()}");
                }
            }


            //3.3.16 Kommer du åt Dog.SittFint() i animalslistan? Svar nej.
            foreach( var a in animals)
            {
                //Console.WriteLine( a.SittFint()); // Kommer inte åt den
                //3.3.17 Varför inte? SittFint är inte en medlem i Animals!

                //3.3.18 
                if(a is Dog)
                {
                    var d = a as Dog;
                    Console.WriteLine($"Dog in Animals is sitting nice: {d.SittFint()}");

                }
            }

            //



        }
    }
}
