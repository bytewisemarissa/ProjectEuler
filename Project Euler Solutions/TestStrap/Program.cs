using ProjectEulerCommon.Factoring;
using ProjectEulerCommon.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStrap
{
    class Program
    {
        static void Main(string[] args)
        {
            //SmallPrimeGenerator primeTestGen = new SmallPrimeGenerator(50);
            //foreach (int prime in primeTestGen)
            //{
            //    Console.WriteLine(prime);
            //}

            FactorEnumerator factorTestGen = new FactorEnumerator(600851475143);
            foreach (long factor in factorTestGen)
            {
                Console.WriteLine(factor);
            }

            Console.WriteLine("DONE");
            Console.ReadKey();
        }
    }
}
