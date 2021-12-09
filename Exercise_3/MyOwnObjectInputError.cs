using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    //3.4.9
    public class MyOwnObjectInputError : UserError
    {
        public override string UEMessage()
        {
            return "Object input Error";
        }
    }
}
