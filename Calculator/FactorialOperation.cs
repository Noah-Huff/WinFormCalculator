using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculator
{
    internal class FactorialOperation : Operation
    {
        public FactorialOperation(string firstOperand, string secondOperand)
            : base(firstOperand, secondOperand) { }

        public string Calculate()
        {
            var value = ParseNum(FirstOper);
            if (value % 1 != 0) return "Must be a whole number for factorial";
            //if (value > 20) return "Value must be less than 21 for this operation";
            else
            {
                BigInteger bigTotal = value;
                long total = value;
                for (long i = value; i > 1; i--)
                {
                    bigTotal *= (i - 1);
                }

                if (bigTotal.ToString().Length < 25) return bigTotal.ToString("N");
                else return bigTotal.ToString("E15");

            }
        }
    }
}
