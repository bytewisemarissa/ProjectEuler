using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCommon.Factoring
{
    public static class PrimeFactorTool
    {
        public static List<double> GetPrimeFactors(double numberToFactor)
        {
            List<Double> returnValue = new List<double>();
            double largestRemainder = numberToFactor;
            while(!NumberSense.NumberSenseTools.IsAPrime(largestRemainder))
            {
                double divider = 2;
                while(largestRemainder % divider != 0)
                {
                    divider = divider + 1;
                }
                returnValue.Add(divider);
                largestRemainder = largestRemainder / divider;
            }

            returnValue.Add(largestRemainder);

            return returnValue;
        }
    }
}
