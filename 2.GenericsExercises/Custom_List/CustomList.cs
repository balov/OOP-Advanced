using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Custom_List
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private IList<T> list;

        public IList<T> List
        {
            get { return this.list; }
            private set { this.list = List; }
        }

        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.list = new List<T>(collection);
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove(int index)
        {
            T temp = this.list[index];
            this.list.RemoveAt(index);
            return temp;
        }

        public bool Contains(T element)
        {
            if (this.list.Contains(element))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Swap(int index1, int index2)
        {
            T element = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = element;
        }

        public int CountGreaterThan(T element)
        {
            int result = this.list.Count(b => b.CompareTo(element) > 0);
            return result;
        }

        public T Max()
        {
            T temp = this.list[0];

            for (int i = 1; i < this.list.Count; i++)
            {
                if (temp.CompareTo(this.list[i]) < 0)
                {
                    temp = this.list[i];
                }
            }
            return temp;
        }

        public T Min()
        {
            T temp = this.list[0];

            for (int i = 1; i < this.list.Count; i++)
            {
                if (temp.CompareTo(this.list[i]) > 0)
                {
                    temp = this.list[i];
                }
            }
            return temp;
        }

        public void Print()
        {
            foreach (var t in this.list)
            {
                Console.WriteLine(t);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}