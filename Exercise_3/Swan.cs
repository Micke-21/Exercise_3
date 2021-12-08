using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Swan : Bird
    {
        public double NeckLength { get; }

        public Swan(string name, int weight, int age, double wingSpan, double neckLength) : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }

    }
}
