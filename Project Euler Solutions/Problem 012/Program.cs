using ProjectEulerCommon.CustomTypes;
using ProjectEulerCommon.Factoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_012
{
    class Program
    {
        static void Main(string[] args)
        {
            long factorCount = 0;
            long triangleNumberSequenceIndex = 1;
            long runningSum = 0;

            while (factorCount < 501)
            {
                runningSum = runningSum + triangleNumberSequenceIndex;
                Console.Write(String.Format("Testing {0}...Total {1}...", triangleNumberSequenceIndex, runningSum));
                FactorEnumerator factoringTool = new FactorEnumerator(runningSum);
                factorCount = factoringTool.Count();
                Console.WriteLine(String.Format("{0} divisors.", factorCount));
                triangleNumberSequenceIndex = triangleNumberSequenceIndex + 1;
            }

            Console.WriteLine(String.Format("The Trianglenumber is {0} its value is {1}. It has {2} factors.", triangleNumberSequenceIndex, runningSum, factorCount));
            Console.ReadKey();
        }
    }
}
