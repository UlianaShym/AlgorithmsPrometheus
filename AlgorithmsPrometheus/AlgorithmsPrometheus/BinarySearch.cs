using System;

namespace AlgorithmsPrometheus
{
    class BinarySearch
    {
        /// <summary>
        /// Implemets binary search
        /// </summary>
        /// <param name="array">Sorted Array of integers</param>
        /// <param name="key">Key, index of which we want to know</param>
        /// <returns>Index of Key if it exists, else '-1'</returns>
        public static Int32 SearchArrayKey(Int32[] array, Int32 key)
        {
            int start = 0, end = array.Length - 1;
            int mid;
            while (start <= end)
            {
                mid = (end - start) / 2 + start;
                if (key < array[mid])
                {
                    end = mid - 1;
                }
                else if (key > array[mid])
                {
                    start = mid + 1;
                }
                else
                    return mid;
            }
            return -1;
        }
    }
}
