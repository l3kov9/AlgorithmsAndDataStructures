using System;
using System.Collections.Generic;

public class ArrayList<T>
{
    private List<T> data;

    public ArrayList()
    {
        this.data = new List<T>();
    }

    public int Count => this.data.Count;

    public T this[int index]
    {
        get
        {
            return this.data[index];
        }

        set
        {
            this.data[index] = value;
        }
    }

    public void Add(T item)
    {
        this.data.Add(item);
    }

    public T RemoveAt(int index)
    {
        T element = this.data[index];
        this.data.RemoveAt(index);
        return element;
    }
}
