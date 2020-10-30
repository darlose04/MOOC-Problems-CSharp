using System;

namespace Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            int square = number * number;

            Console.WriteLine($"The square of {number} is {square}.");
        }
    }
}
