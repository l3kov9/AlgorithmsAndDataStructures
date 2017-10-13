using System;
using System.Collections.Generic;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            var tree = new Tree<int>(4, new Tree<int>(9, new Tree<int>(6), new Tree<int>(5)), new Tree<int>(14)
                , new Tree<int>(15, new Tree<int>(8)));
            tree.Print();

            IncreaseWithOne(tree);

            tree.Print();
        }

        private static void IncreaseWithOne(Tree<int> tree)
        {
            tree.Value++;
            foreach (var child in tree.Children)
            {
                IncreaseWithOne(child);
            }
        }

        private static List<int> GetElements(Tree<int> tree)
        {
            var list = new List<int>();
            list.Add(tree.Value);

            foreach (var child in tree.Children)
            {
            }

            return list;
        }
    }
}
