using System;

namespace Puzzles
{
    class Arrays
    {
        /// <summary>
        /// Find common elements in three sorted arrays
        /// Given three arrays sorted in non-decreasing order, print all common elements in these arrays.
        /// </summary>
        public void FindCommonElementsInThreeArrays()
        {
            int[] array1 = { 0, 2, 3 };
            int[] array2 = { 1, 2, 3, 5, 10 };
            int[] array3 = { 1, 3, 5, 10 };
            int i = 0, j = 0, k = 0;

            while (i != array1.Length && j != array2.Length && k != array3.Length)
            {
                if (array1[i] == array2[j] && array2[j] == array3[k])
                {
                    Console.WriteLine(String.Concat("The common elements are : ", array1[i]));
                    i++;
                    j++;
                    k++;
                }
                else
                {
                    if (array1[i] < array2[j])
                    {
                        i++;
                    }
                    else if (array2[j] < array3[k])
                    {
                        j++;
                    }
                    else
                    {
                        k++;
                    }
                }
            }
        }

        /// <summary>
        /// Count pairs with given sum
        /// Given an array of integers, and a number ‘sum’, find the number of pairs of integers in the array whose sum is equal to sum.
        /// </summary>
        public void CountpairsWithGivenSum()
        {
            int[] array1 = { 0, 5, 2, 3 };
            int sum = 5;

        }

        /// <summary>
        /// Find missing element
        /// Given two arrays which are duplicates of each other except one element, that is one element from one of the array is missing, we need to find that missing element.
        /// </summary>
        public void FindMissingElementInDuplicateArray()
        {
            int[] array1 = { 1, 5, 7, 9 };
            int[] array2 = { 5, 7, 9 };

            int x;
            int start = 0, end = array1.Length - 1;
            bool elemIsMissedFromFirstArray = array1.Length < array2.Length;

            if (array1[0] != array2[0])
            {
                x = elemIsMissedFromFirstArray ? array2[0] : array1[0];
            }
            else
            {
                while (start < end)
                {
                    var mid = (end - start) / 2 + start;
                    if (array1[mid] == array2[mid]) //go to right side of array
                    {
                        start = mid;
                    }
                    else // go to left side of array
                    {
                        end = mid;
                    }
                    if (start == end - 1)
                        break;
                }
                x = elemIsMissedFromFirstArray ? array2[end] : array1[end];
            }

            Console.WriteLine(String.Concat("Missing element = ", x));
        }
    }
}
