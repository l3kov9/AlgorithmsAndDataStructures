using System.Collections.Generic;

namespace _03.ArrayStack
{
    public class ArrayStack<T>
    {
        private List<T> data;
        private const int InitialCapacity = 16;
        private T[] elements;

        private void Grow() { }

        public ArrayStack()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;
        public ArrayStack(int capacity = InitialCapacity) { };

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            var element = this.data[0];
            this.data.RemoveAt(this.data.Count-1);
            return element;
        }

        public T[] ToArray() => this.data.ToArray();

    }
}
