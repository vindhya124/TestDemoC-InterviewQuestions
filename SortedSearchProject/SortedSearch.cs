using System;

namespace SortedSearchProject
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            var i = Array.BinarySearch(sortedArray, lessThan);
            if (i < 0)
                return -i - 1;
            return i;
        }

    }
}
