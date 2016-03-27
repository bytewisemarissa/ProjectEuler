using ProjectEulerCommon.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_010
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallPrimeGenerator generator = new SmallPrimeGenerator(2000000);
            double primeSum = 0;
            foreach (int prime in generator)
            {
                Console.WriteLine(String.Format("Adding prime {0}", prime));
                primeSum = primeSum + prime;
            }

            Console.WriteLine(String.Format("Sum of all primes under 2,000,000 is {0}", primeSum));
            Console.ReadKey();
        }
    }
}
