using System;
using Statistics;

namespace PartFourProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Statistics.Statistics statistics = new Statistics.Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(6);
            statistics.AddNumber(1);
            statistics.AddNumber(2);
            Console.WriteLine($"Count: {statistics.Count}");
            Console.WriteLine($"Sum: {statistics.Sum}");
            Console.WriteLine($"Average: {statistics.Average()}");
        }
    }
}
