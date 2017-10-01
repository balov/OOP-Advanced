namespace Custom_List
{
    public interface ICustomList<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        void Print();

        int CountGreaterThan(T element);

        T Max();

        T Min();
    }
}