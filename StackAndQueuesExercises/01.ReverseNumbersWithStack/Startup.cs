using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbersWithStack
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<int>();
            foreach (var num in numbers)
            {
                stack.Push(num);
            }

            Console.WriteLine(string.Join(" ",stack));
        }
    }
}
