using ProjectEulerCommon.NumberSense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_014
{
    class Program
    {
        private static object lockObj = new object();
        private static int longestChain = 0;
        private static long longestChainNumber = 0;

        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
           
            for (long i = 1; i < 999999; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    long workNumber = i;
                    List<long> sequence = new List<long>();
                    NumberSenseTools.CollatzSequence(workNumber, sequence);
                    int sequenceCount = sequence.Count();
                    lock(lockObj)
                    {
                        if (sequence.Count() > longestChain)
                        {
                            longestChain = sequenceCount;
                            longestChainNumber = workNumber;
                        }
                    }
                }));
            }

            while (true)
            {
                bool finished = true;
                foreach(Task task in tasks)
                {
                    if(task.IsCompleted)
                    {
                        continue;
                    }
                    else
                    {
                        finished = false;
                        break;
                    }
                }

                if(finished)
                {
                    break;
                }
            }
            
            Console.WriteLine(String.Format("The longest sequence is {0}, the starting number was {1}", longestChain, longestChainNumber));
            Console.ReadKey();
        }
    }
}
