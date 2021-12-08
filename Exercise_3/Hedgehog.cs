using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Hedgehog : Animal
    {
        public int NoOfSpikes { get; }

        public Hedgehog(string name, int weight, int age, int noOfSpikes) : base(name, weight, age)
        {
            NoOfSpikes = noOfSpikes;
        }


        public override void DoSound()
        {
            Console.WriteLine("Klick klick frääässsss");
        }

        //3.3.2
        public override string Stats()
        {
            return base.Stats() + " no of spikes " + NoOfSpikes;
        }
    }
}
