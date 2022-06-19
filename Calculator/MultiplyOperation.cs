using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MultiplyOperation : Operation
    {
        public MultiplyOperation(string firstOper, string secondOper) 
            : base(firstOper, secondOper) { }

        public string Calculate()
        {
            return _calculate(ParseNum(FirstOper), ParseNum(SecondOper)).ToString("N");
        }

        private long _calculate(long a, long b)
        {
            return a * b;
        }
        private decimal _calculate(decimal a, decimal b)
        {
            return a * b;
        }

    }
}
