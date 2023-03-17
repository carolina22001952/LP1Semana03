using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            char userChar;

            Console.WriteLine("String: ");
            userString = Console.ReadLine();

            Console.WriteLine("Char: ");
            userChar = char.Parse(Console.ReadLine());

            foreach (char c in userString)
            {
                if (c != userChar)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
