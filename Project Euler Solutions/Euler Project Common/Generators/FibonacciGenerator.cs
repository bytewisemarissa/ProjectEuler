using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.Generators
{
    public class FibonacciGenerator : IEnumerable<int>
    {
        private int maxValue = 0, firstOperand = 0, secondOperand = 1;

        public FibonacciGenerator(int inMaxValue)
        {
            maxValue = inMaxValue;
        }

        public IEnumerator<int> GetEnumerator()
        {
            while (secondOperand < maxValue)
            {
                int returnValue = firstOperand + secondOperand;
                firstOperand = secondOperand;
                secondOperand = returnValue;

                yield return returnValue;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
