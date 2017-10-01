using System;

namespace Tuple
{
    public class Tuple<TKey, TValue>
    {
        private TKey item1;
        private TValue item2;

        public Tuple(TKey item1, TValue item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public void Print()
        {
            Console.WriteLine($"{item1} -> {item2}");
        }
    }
}