using System;
using System.Linq;

namespace Custom_List
{
    public class CostomListSorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> list)
            where T : IComparable<T>
        {
            var temp = list.List.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}