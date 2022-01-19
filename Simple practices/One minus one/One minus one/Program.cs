using System;
using static System.Console;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i += 2)
            {
                int j = i - (i * 2) + 1;
                Write($"{j} {i} ");
            }
        }
    }
}