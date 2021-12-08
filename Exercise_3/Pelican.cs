using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Pelican : Bird
    {
        public double BeakSize { get; }

        public Pelican(string name, int weight, int age, double wingSpan, double beakSize) : base(name, weight, age, wingSpan)
        {
            BeakSize = beakSize;
        }

    }
}
