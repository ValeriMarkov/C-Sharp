using System;

namespace Sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long nth = rowSumOddNumbers(1);
            Console.WriteLine(nth);
            nth = rowSumOddNumbers(42);
            Console.WriteLine(nth);
        }

        public static long rowSumOddNumbers(long n)
        {
            return n * n * n;
        }
    }
}
