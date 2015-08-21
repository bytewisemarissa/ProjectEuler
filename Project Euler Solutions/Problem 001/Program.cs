using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_001
{
    class Program
    {
        private static int TARGET_NUMBER = 1000;

        static void Main(string[] args)
        {
            int runningTotal = 0;
            for (int i = 0; i < TARGET_NUMBER; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    runningTotal += i;
                }
            }

            Console.WriteLine(String.Format("The awnser is {0}.", runningTotal));
            Console.ReadKey();
        }
    }
}
