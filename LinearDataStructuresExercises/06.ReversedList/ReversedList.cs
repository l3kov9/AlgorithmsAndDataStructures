using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.ReversedList
{
    public class ReversedList<T> : IReversedList<T>, IEnumerable<T>
    {
        private List<T> data;

        public ReversedList()
        {
            this.data = new List<T>();
        }

        public T this[int index] => this.data[index];

        public int Count => this.data.Count;

        
        public void Add(T item)
        {
            this.data.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        public void RemoveAT(int index)
        {
            this.data.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
