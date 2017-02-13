using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    interface IAccount
    {
        //add new number to expression
        void Adding(decimal expression);
        //subtract new number from expression
        decimal Subtracted(decimal expression);
        //multiply new number to expression
        decimal Multiplyed(decimal expression);
        //divide the expression on new number
        decimal Divided(decimal expression);

    }
}
