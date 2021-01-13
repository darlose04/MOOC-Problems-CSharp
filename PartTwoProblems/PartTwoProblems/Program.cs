﻿using System;

namespace PartTwoProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumOfNumbers();
            //AverageOfNumbers();
            int output = Greatest(6, 2, 5);
            Console.WriteLine($"Greatest: {output}");
        }

        public static void SumOfNumbers()
        {
            int total = 0;

            while (true)
            {
                Console.WriteLine("Give a number: ");
                int userInput = Int32.Parse(Console.ReadLine());

                total += userInput;

                if (userInput == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Sum of the numbers: {total}");
        }

        public static void AverageOfNumbers()
        {
            int total = 0;
            int count = 0;

            while (true)
            {
                Console.WriteLine("Give a number: ");
                int userInput = Int32.Parse(Console.ReadLine());

                total += userInput;
                count += 1;

                if (userInput == 0)
                {
                    break;
                }
            }

            var average = total / count;

            Console.WriteLine($"Average of the numbers: {average}");
        }

        public static int Greatest(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }

            if (num2 > num1 && num2 > num3)
            {
                return num2;
            }

            return num3;
        }
    }
}
