using System;
using System.Collections;
using System.Collections.Generic;

namespace _02.CalculateSequence
{
    public class Startup
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            queue.Enqueue(firstNumber);

            for (int i = 0; i < 16; i++)
            {
                queue.Enqueue(firstNumber+1);
                queue.Enqueue(firstNumber * 2 + 1);
                queue.Enqueue(firstNumber + 2);

                firstNumber = firstNumber + 1;
            }

            Console.WriteLine(string.Join(" ",queue));
        }
    }
}
