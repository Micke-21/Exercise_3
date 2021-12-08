using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int weight, int age, bool wild) : base(name, weight, age, wild)
        {
        }

        public void Talk()
        {
            //this.DoSound();
            //
            Console.WriteLine($"Wolfman says Hello!");// vilken metod skall skriva ut?
        }
    }
}
