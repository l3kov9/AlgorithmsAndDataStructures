using System;
using System.Linq;

namespace _02.SortWords
{
    public class Startup
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();
            words.Sort();
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
