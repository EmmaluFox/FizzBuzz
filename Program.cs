using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        private static void Main(string[] args)
        {
            PrintNums();
        }

        private static void PrintNums()
        {
            string text = "";
            for (int i = 0; i <= 100; i++)
            {
                int[] divisorsX = {3, 5, 7, 11, 13, 17};
                int testRemainderX = i % divisorsX[i];
                for (int ix = 0; ix < 6; ix++)
                {
                    int[] divisors = {3, 5, 7, 11, 13, 17};
                    int testRemainder = testRemainderX;
                    string nameTemp = "";

                    if (testRemainder == 0)
                    {
                        string[] namesPrint = new string[6];
                        namesPrint[0] = "Fizz";
                        namesPrint[1] = "Buzz";
                        namesPrint[2] = "Bang";
                        namesPrint[3] = "Bong";
                        namesPrint[4] = "Fezz";
                        namesPrint[5] = "X";

                        string textTemp = namesPrint[divisors[ix]];
                        nameTemp += textTemp;
                    }
                    Console.WriteLine(nameTemp);
                }


                static List<string> GetParts(int number)
                {
                    var parts = new List<string>();
                    if (number % 11 == 0)

                    {
                        if (number % 13 == 0)
                        {
                            parts.Add("Fezz");
                        }

                        parts.Add("Bong");
                        return parts;
                    }

                    if (number % 3 == 0)
                    {
                        parts.Add("Fizz");
                    }

                    if (number % 13 == 0)
                    {
                        parts.Add("Fezz");
                    }

                    if (number % 5 == 0)
                    {
                        parts.Add("Buzz");
                    }

                    if (number % 7 == 0)
                    {
                        parts.Add("Bang");
                    }

                    return parts;

                }
            }
        }
    }
}

