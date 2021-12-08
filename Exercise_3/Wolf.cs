using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Wolf : Animal
    {
        public bool Wild { get; }

        public Wolf(string name, int weight, int age, bool wild ) : base(name, weight, age)
        {
            Wild = wild;
        }


        public override void DoSound()
        {
            Console.WriteLine("Oooyyyyyyllll");
        }

        //3.3.2
        public override string Stats()
        {
            return base.Stats() + " this wolf is " + (Wild?"Wild": "Domestic");
        }
    }
}
