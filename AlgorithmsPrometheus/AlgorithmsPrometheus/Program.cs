using AlgorithmsPrometheus.Coursera.UnionFind;

namespace AlgorithmsPrometheus
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
           // Console.WriteLine("Method Karatsuby multiplying 2 digits.\n");
           // BigInteger firstMultiplier = BigInteger.Parse("1685287499328328297814655639278583667919355849391453456921116729");
           // BigInteger secondMultiplier = BigInteger.Parse("7114192848577754587969744626558571536728983167954552999895348492");
           // BigInteger product = _1_MethodKaratsuby.CalculateProduct(firstMultiplier, secondMultiplier);


           //// BigInteger product2 = _1_MethodKaratsuby.CalculateProductRecursive(BigInteger.Parse("1234"), BigInteger.Parse("5678"));


           // int[] arrayForSort = {10, 5, 2, 4, 9, 6, 7, 8};
           // _2_MergeSort.MergeSort(arrayForSort, 0, arrayForSort.Length - 1);

           // for (int i = 0; i < arrayForSort.Length; i++)
           // {
           //     Console.WriteLine(arrayForSort[i]);
           // }
           // Helper.WriteResultsToFile(product);


            //QuickFindAlgorithm quickFindAlgorithm = new QuickFindAlgorithm(10);
            //quickFindAlgorithm.Union(9, 4);
            //quickFindAlgorithm.Union(2, 4);
            //quickFindAlgorithm.Union(3, 5);
            //quickFindAlgorithm.Union(1, 2);
            //quickFindAlgorithm.Union(8, 1);
            //quickFindAlgorithm.Union(0, 3);
            //quickFindAlgorithm.PrintArray();

            QuickUnionAlgorithm quickUnionAlgorithm = new QuickUnionAlgorithm(10);
            quickUnionAlgorithm.Union(6, 9);//6-9 8-2 5-9 0-6 9-1 5-4 3-7 8-7 4-3 
            quickUnionAlgorithm.Union(8, 2);
            quickUnionAlgorithm.Union(5, 9);
            quickUnionAlgorithm.Union(0, 6);
            quickUnionAlgorithm.Union(9, 1);
            quickUnionAlgorithm.Union(5, 4);
            quickUnionAlgorithm.Union(3, 7);
            quickUnionAlgorithm.Union(8, 7);
            quickUnionAlgorithm.Union(4, 3);
            quickUnionAlgorithm.PrintArray();
=======
            Console.WriteLine("Method Karatsuby multiplying 2 digits.\n");
            BigInteger firstMultiplier = BigInteger.Parse("1685287499328328297814655639278583667919355849391453456921116729");
            BigInteger secondMultiplier = BigInteger.Parse("7114192848577754587969744626558571536728983167954552999895348492");
            BigInteger product = _1_MethodKaratsuby.CalculateProduct(firstMultiplier, secondMultiplier);
            Helper.WriteResultsToFile(product);

            Console.WriteLine("Binary search algorithm.\n");
            int[] array = { 1, 2, 3, 5, 6, 7, 8, 9 };
            Console.WriteLine(String.Concat("Index of key is : " + BinarySearch.SearchArrayKey(array, 9).ToString()));
>>>>>>> 5948153d55443a20d4467c7f26d422f66c791e76
        }
    }
}
