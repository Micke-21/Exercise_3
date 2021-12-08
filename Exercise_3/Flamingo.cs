using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Flamingo : Bird
    {
        public double LegLenght { get; }

        public Flamingo(string name, int weight, int age, double wingSpan, double legLenght) : base(name, weight, age, wingSpan)
        {
            LegLenght = legLenght;
        }

    }
}
