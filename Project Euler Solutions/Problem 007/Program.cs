using ProjectEulerCommon.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_007
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallPrimeGenerator generator = new SmallPrimeGenerator(Int32.MaxValue/4096);

            int i = 1;
            int currentPrime = 1;
            foreach (int prime in generator)
            {
                currentPrime = prime;
                //Console.WriteLine(String.Format("{0} prime is {1}", i, currentPrime));
                if(i == 10001)
                {
                    break;
                }
                i = i + 1;
            }

            Console.WriteLine("10,001st prime {0}.", currentPrime);
            Console.ReadKey();
        }
    }
}
