namespace _06.ReversedList
{
    public interface IReversedList<T>
    {
        void Add(T item);

        int Count { get; }

        T this[int index]{get;}

        void RemoveAT(int index);
    }
}