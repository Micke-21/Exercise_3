using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Worm : Animal
    {
        public bool IsPoisonuous { get; }

        public Worm(string name, int weight, int age, bool isPoisonuous) : base(name, weight, age)
        {
            IsPoisonuous = isPoisonuous;
        }

        public override void DoSound()
        {
            Console.WriteLine("    .");
        }

        //3.3.2
        public override string Stats()
        {
            return base.Stats() + " the worm is " + (IsPoisonuous?"poisonous":"non-toxic");
        }
    }
}
