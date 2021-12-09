using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    //3.4.5
    public class TextInputError : UserError
    {
        //3.4.6
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field. This fired an error";
        }
    }
}
