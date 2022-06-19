using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public abstract class Operation
    {
        private string _firstOper;
        private string _secondOper;

        protected string FirstOper
        {
            get { return _firstOper; }
            set { _firstOper = value; }
        }
        protected string SecondOper
        {
            get { return _secondOper; }
            set { _secondOper = value; }
        }

        protected Operation(string firstOper, string secondOper)
        {
            this.FirstOper = firstOper;
            this.SecondOper = secondOper;
        }

        public dynamic ParseNum(string input)
        {
            if (long.TryParse(input, out _))
            {
                return long.Parse(input);
            }
            else 
            {
                return decimal.Parse(input);
            }

        }

    }
}
