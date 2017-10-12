using System;
using System.Linq;

namespace _01.SumАndAverage
{
    public class Startup
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine($"Sum={elements.Sum()}; Average={elements.Average():f2}");
        }
    }
}
