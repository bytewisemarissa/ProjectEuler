using ProjectEulerCommon.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_002
{
    class Program
    {
        private static int MAX_VALUE = 4000000;

        static void Main(string[] args)
        {
            int runningTotal = 0;
            FibonacciGenerator generator = new FibonacciGenerator(MAX_VALUE);
            foreach(int nextInSeq in generator)
            {
                if (nextInSeq % 2 == 0)
                {
                    runningTotal += nextInSeq;
                }
            }

            Console.WriteLine(String.Format("The anwser is {0}.", runningTotal));
            Console.ReadKey();
        }
    }

    
}
