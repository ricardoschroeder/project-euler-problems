using System;

namespace even_fibonacci_numbers
{
    class Program
    {
        const int maxNumber = 4000000;

        static void Main(string[] args)
        {
            Console.WriteLine($"Total sum of even numbers of the Fibonacci sequence that does not exceed {maxNumber}");

            int total = FibonacciEvenNumber(1, 2, 0);
            Console.WriteLine($"Total: {total}");
        }

        static int FibonacciEvenNumber(int previousValue, int currentValue, int total)
        {
            int nextValue = previousValue + currentValue;

            if (currentValue % 2 == 0)
            {
                total += currentValue;
            }

            if (nextValue <= maxNumber) 
            {
                return FibonacciEvenNumber(currentValue, nextValue, total);
            }

            return total;
        }
    }
}
