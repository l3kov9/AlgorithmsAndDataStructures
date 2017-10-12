using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private List<T> data;

    public DoublyLinkedList()
    {
        this.data = new List<T>();
    }

    public int Count => this.data.Count;

    public void AddFirst(T element)
    {
        this.data.Insert(0, element);
    }

    public void AddLast(T element)
    {
        this.data.Insert(this.data.Count - 1, element);
    }

    public T RemoveFirst()
    {
        var elementToRemove = this.data[0];
        this.data.RemoveAt(0);
        return elementToRemove;
    }

    public T RemoveLast()
    {
        var elementToRemove = this.data[this.data.Count-1];
        this.data.RemoveAt(this.data.Count - 1);
        return elementToRemove;
    }

    public void ForEach(Action<T> action)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < data.Count; i++)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    public T[] ToArray()
    {
        return this.data.ToArray();
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}
