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
                int fizzRemainder = i % 3;
                int buzzRemainder = i % 5;
                if (fizzRemainder == 0)
                {
                    Console.WriteLine("Fizz");
                } else if(buzzRemainder == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}