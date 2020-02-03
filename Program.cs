using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
        PrintNums();
        }

        private static void PrintNums()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}