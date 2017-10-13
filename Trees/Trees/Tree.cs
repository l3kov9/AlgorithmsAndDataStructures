using System;
using System.Collections.Generic;

public class Tree<T>
{
    public T Value { get; set; }

    public List<Tree<T>> Children;

    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = new List<Tree<T>>();

        foreach (var child in children)
        {
            this.Children.Add(child);
        }
    }

    public void Print(int indent = 0)
    {
        Console.WriteLine(new string(' ',indent*2)+ this.Value);

        foreach (var child in this.Children)
        {
            child.Print(indent + 1);
        }
    }

    public void Each(Action<T> action)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> OrderDFS()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> OrderBFS()
    {
        throw new NotImplementedException();
    }
}
