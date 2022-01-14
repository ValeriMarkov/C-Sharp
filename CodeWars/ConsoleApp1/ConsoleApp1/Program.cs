using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.
            //For example:

            //summation(2)-> 3
            //1 + 2

            //summation(8)-> 36
            //1 + 2 + 3 + 4 + 5 + 6 + 7 + 8

            int num = summation(1);
            Console.WriteLine(num);
            num = summation(8);
            Console.WriteLine(num);
            num = summation(22);
            Console.WriteLine(num);
            num = summation(100);
            Console.WriteLine(num);
            num = summation(213);
            Console.WriteLine(num);
        }

        static public int summation(int num)
        {
            return num * (num + 1) / 2;
        }
    }
}
