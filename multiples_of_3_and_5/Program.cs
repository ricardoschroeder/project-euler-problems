using System;
using System.Diagnostics;

namespace multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total sum of multiples of 3 and 5");

            while (true)
            {
                Console.Write("Max number (write any letter to exit): ");

                string result = Console.ReadLine();

                if (int.TryParse(result, out int max))
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int sum = FindSum(max);
                    stopwatch.Stop();
                    Console.WriteLine($"Sum: {sum}. Time elapsed: {stopwatch.Elapsed}");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }

        static int FindSum(int max)
        {
            int sum = 0;

            for (int i = 0; i < max; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
