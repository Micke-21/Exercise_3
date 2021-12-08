using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Dog : Animal
    {
        public int Tail { get; }

        public Dog(string name, int weight, int age, int tail) : base(name, weight, age)
        {
            Tail = tail;
        }


        public override void DoSound()
        {
            Console.WriteLine("Voff voff");
        }

        //3.3.2
        public override string Stats()
        {
            return base.Stats() + " the tail is " + Tail;
        }

        //3.3.15
        public string SittFint()
        {
            return $"Hunden sitter fint";
        }
    }
}
