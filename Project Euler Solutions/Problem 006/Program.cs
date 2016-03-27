using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_006
{
    class Program
    {
        private static double _sumOfSquaresResult, _squareOfSumResult; 
        static void Main(string[] args)
        {
            Task sumOfSquaresTask = new Task(() =>
            {
                double sumOfSquares = 0;
                for(int i = 1; i <= 100; i++)
                {
                    sumOfSquares += Math.Pow(i, 2);
                }
                _sumOfSquaresResult = sumOfSquares;
            });

            Task squareOfSumTask = new Task(() =>
            {
                double squareOfSum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    squareOfSum += i;
                }
                _squareOfSumResult = Math.Pow(squareOfSum, 2);
            });

            sumOfSquaresTask.Start();
            squareOfSumTask.Start();

            while (!sumOfSquaresTask.IsCompleted && !sumOfSquaresTask.IsCompleted) { }

            Console.WriteLine(String.Format("The result is {0}.", _squareOfSumResult - _sumOfSquaresResult));
            Console.ReadKey();
        }
    }
}
