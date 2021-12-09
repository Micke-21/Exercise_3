using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    //3.4.9
    public class MyOwnToManyError : UserError
    {
        public override string UEMessage()
        {
            return "You have done to many error. Stop that. Do it right.";
        }
    }
}
