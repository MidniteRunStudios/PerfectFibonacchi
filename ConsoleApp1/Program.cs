using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 2000000; // Modify this value as needed
                BigInteger result = CalculateFibonacci(n);
                Console.WriteLine($"The {n}th Fibonacci number is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();
        }

        public static BigInteger CalculateFibonacci(int i)
        {
            if (i < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }

            if (i == 0) return 0;
            if (i == 1) return 1;

            BigInteger previous = 0;
            BigInteger current = 1;

            for (int n = 2; n <= i; ++n)
            {
                BigInteger nextNumber = previous + current;
                previous = current;
                current = nextNumber;
            }

            return current;
        }
    }
}