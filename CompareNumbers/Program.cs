using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number: ");
            var y = Int32.Parse(Console.ReadLine());

            CompareTwoNumbers(x, y);
        }

        public static void CompareTwoNumbers(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            } else if (x < y)
            {
                Console.WriteLine($"{x} is smaller than {y}");
            } else
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
        }
    }
}
