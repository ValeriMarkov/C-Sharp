using System;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomPasswordGenerator = new Random();
            int passwordLength;
            int totalSymbols;
            int password;

            Console.Write("Enter the length of the password you want to randomize: ");
            passwordLength = Convert.ToInt32(Console.ReadLine());

            //If you want more symbols, you can add more elements in symbols variable bellow (,.!@#$%^&* and etc)

            char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m',
                            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L','M',
                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            totalSymbols = symbols.Length;

            Console.Write("Password: ");

            for (int i = 0; i < passwordLength; i++)
            {
                password = randomPasswordGenerator.Next(0, totalSymbols);
                Console.Write(symbols[password]);
            }
        }
    }
}