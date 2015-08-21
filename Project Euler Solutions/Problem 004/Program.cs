using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_004
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepSize = 111;
            int currentLimit = 888;

            while (currentLimit > 0)
            {
                for (int i = currentLimit + stepSize; i > currentLimit; i--)
                {
                    for (int j = currentLimit + stepSize; j > currentLimit; j--)
                    {
                        int product = i * j;
                        char[] number = product.ToString().ToCharArray();
                        bool isPalladrome = true;
                        for (int l = 0; l < number.Length / 2; l++)
                        {
                            if (number[l] != number[number.Length - 1 - l])
                            {
                                isPalladrome = false;
                                break;
                            }
                        }
                        if (isPalladrome)
                        {
                            Console.WriteLine(String.Format("The anwser is {0}.", product.ToString()));
                            Console.ReadKey();
                            return;
                        }
                    }
                }

                currentLimit = currentLimit - stepSize;
            }
        }
    }
}
