using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
