using System;

namespace Tuple
{
    public class Threeuple<TKey, TFirstValue, TSecondValue>
    {
        private TKey key;
        private TFirstValue firstValue;
        private TSecondValue secondValue;

        public Threeuple(TKey key, TFirstValue firstValue, TSecondValue secondValue)
        {
            this.key = key;
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        public void Print()
        {
            Console.WriteLine($"{key} -> {firstValue} -> {secondValue}");
        }
    }
}