using System;
using System.Numerics;

namespace AlgorithmsPrometheus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Karatsuby multiplying 2 digits.\n");
            BigInteger firstMultiplier = BigInteger.Parse("1685287499328328297814655639278583667919355849391453456921116729");
            BigInteger secondMultiplier = BigInteger.Parse("7114192848577754587969744626558571536728983167954552999895348492");
            BigInteger product = _1_MethodKaratsuby.CalculateProduct(firstMultiplier, secondMultiplier);
            Helper.WriteResultsToFile(product);
        }
    }
}
