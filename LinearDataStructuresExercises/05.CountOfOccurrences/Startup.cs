using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountOfOccurrences
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var dictionary = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!dictionary.ContainsKey(num))
                {
                    dictionary[num] = 0;
                }
                dictionary[num]++;
            }

            foreach (var kvp in dictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times.");
            }
        }
    }
}
