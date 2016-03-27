using ProjectEulerCommon.Factoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, List<double>> primeFactoration = new Dictionary<double, List<double>>();
            for(int i = 2; i <= 20; i++)
            {
                primeFactoration.Add(i, PrimeFactorTool.GetPrimeFactors(i));
            }

            List<KeyValuePair<double, int>> factorCountsGlobal = new List<KeyValuePair<double, int>>();
            foreach (List<Double> primeFactors in primeFactoration.Values)
            {
                List<KeyValuePair<double, int>> factorCounts = (from pF in primeFactors
                                                                  group pF by pF into factorGroup
                                                                  let count = factorGroup.Count()
                                                                  orderby count descending
                                                                  select new KeyValuePair<double, int>(factorGroup.Key, count)).ToList();

                foreach (KeyValuePair<double, int> factorCount in factorCounts)
                {
                    factorCountsGlobal.Add(factorCount);
                }
            }

            double product = 1;
            foreach (double primeFactor in factorCountsGlobal.Select(fc => fc.Key).Distinct())
            {
                KeyValuePair<double, int> maxPowerOfPrime = factorCountsGlobal.Where(fc => fc.Key == primeFactor).OrderByDescending(fc => fc.Value).First();
                product = product * Math.Pow(maxPowerOfPrime.Key, maxPowerOfPrime.Value);
            }
            Console.WriteLine(String.Format("The soulution is {0}.", product));
            Console.ReadKey();
        }
    }
}
