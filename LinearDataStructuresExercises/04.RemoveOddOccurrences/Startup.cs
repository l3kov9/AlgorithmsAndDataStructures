using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RemoveOddOccurrences
{
    public class Startup
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            list.Sort();

            var counter = 1;
            var result = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    counter++;
                }
                else
                {
                    if (counter % 2 == 0)
                    {
                        for (int j = 0; j < counter; j++)
                        {
                            result.Add(list[i-1]);
                        }
                    }
                    counter = 1;
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
