using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Horse : Animal
    {
        public HorsType HorsType { get; }

        public Horse(string name, int weight, int age, HorsType horsType) : base(name, weight, age)
        {
            HorsType = horsType;
        }


        public override void DoSound()
        {
            Console.WriteLine("Gnääägg");
        }

        //3.3.2
        public override string Stats()
        {
            return base.Stats() + $" this horse is of type {HorsType}";
        }
    }
}
