using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class DivideOperation : Operation
    {
        public DivideOperation(string firstOperand, string secondOperand)
            : base(firstOperand, secondOperand) { }

        public string Calculate()
        {
            if (ParseNum(SecondOper) != 0)
            {
                return _calculate(ParseNum(FirstOper), ParseNum(SecondOper)).ToString("N");
            }
            else
            {
                return "Uh oh, can't divide by zero.";
            }
        }

        private long _calculate(long a, long b)
        {
            return a / b;
        }
        private decimal _calculate(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
