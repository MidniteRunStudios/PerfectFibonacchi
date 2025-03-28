using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = f(2000000000);
            Console.WriteLine(n);
            Console.ReadKey();
        }
        public static BigInteger f(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }
            //return f(i - 1) + f(i - 2);
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 0;
            for (int n = 2; n <= i; ++n)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;

        }
    }
}
