using ProjectEulerCommon.Factoring;
using ProjectEulerCommon.NumberSense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_003
{
    class Program
    {
        private static readonly long testValue = 600851475143;

        static void Main(string[] args)
        {
            FactorEnumerator factors = new FactorEnumerator(testValue);
            List<long> foundFactors = factors.ToList();

            long highestCurrentPrime = 0;
            foreach (long factor in foundFactors)
            {
                if (NumberSenseTools.IsAPrime(factor))
                {
                    if (factor > highestCurrentPrime)
                    {
                        highestCurrentPrime = factor;
                    }
                }
            }

            Console.WriteLine(String.Format("Anwser is {0}.", highestCurrentPrime));
            Console.ReadKey();
        }
    }
}
