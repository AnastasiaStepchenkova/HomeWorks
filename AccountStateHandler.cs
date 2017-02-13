using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        //the message about the event
        public string Message { get; private set; }
        //the result of operations
        public decimal Expression { get; private set; }

        public AccountEventArgs(string _mes, decimal _expression)
        {
            Message = _mes;
            Expression = _expression;
        }
    }
}