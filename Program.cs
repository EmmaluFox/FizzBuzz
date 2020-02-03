using System;

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
            for (int i = 1; i < 101; i++)
            {
                
                int[] divisors = {3, 5, 7, 11, 13, 17};
                
                if (testRemainder == 0)
                {
                    for (int ix = 0; ix < 6; ix++)
                    {
                        int positionCount = ix;
                        int testRemainder = divisors[positionCount]; 
                        
                        string[] namesPrint = new string[6];
                        namesPrint[0] = "Fizz";
                        namesPrint[1] = "Buzz";
                        namesPrint[2] = "Bang";
                        namesPrint[3] = "Bong";
                        namesPrint[4] = "Fezz";
                        namesPrint[5] = "X";

                        string ConcatStr()
                        {
                            string nameTemp = "";
                            if (i % divisors[ix] == 0)
                            {
                                string name = namesPrint[ix];
                                nameTemp += name;
                            }

                            return nameTemp;
                        }

                        text += ConcatStr();
                        Console.WriteLine(text);
                    }
                }
                else {

                        Console.WriteLine(i);
                }
            }
        }
        }

    }
