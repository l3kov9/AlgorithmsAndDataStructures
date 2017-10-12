using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LongestSubsequence
{
    public class Startup
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var counter = 1;
            var maxCounter = 1;
            var elementToRepeat = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        elementToRepeat = list[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            var result = new List<int>();
            for (int i = 0; i < maxCounter; i++)
            {
                result.Add(elementToRepeat);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
