using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_009
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a=1; a<1000; a++)
            {
                for(int b=1; b<1000; b++)
                {
                    for(int c=1; c<1000; c++)
                    {
                        if(a+b+c == 1000)
                        {
                            if((Math.Pow(a,2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                            {
                                Console.WriteLine(String.Format("A={0}, B={1}, C={2}, Product : {3}", a, b, c, a * b * c));
                                Console.ReadKey();
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
