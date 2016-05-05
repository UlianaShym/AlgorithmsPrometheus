using System;
using System.Numerics;

namespace AlgorithmsPrometheus
{
    class _1_MethodKaratsuby
    {
        private static int i = 0;
        private static BigInteger result;
        static BigInteger a;
        static BigInteger b;
        static BigInteger c;
        static BigInteger d;

        public static BigInteger CalculateProduct(BigInteger firstMultiplier, BigInteger secondMultiplier)
        {
            int n = firstMultiplier.ToString().Length;

            a = BigInteger.Parse(firstMultiplier.ToString().Substring(0, n / 2));
            b = BigInteger.Parse(firstMultiplier.ToString().Substring(n / 2));
            c = BigInteger.Parse(secondMultiplier.ToString().Substring(0, n / 2));
            d = BigInteger.Parse(secondMultiplier.ToString().Substring(n / 2));

            BigInteger ac = a * c;
            BigInteger bd = b * d;
            return BigInteger.Pow(10, n) * ac + BigInteger.Pow(10, n / 2) * ((a + b) * (c + d) - ac - bd) + bd;
        }

        static BigInteger ac = 1;
        static BigInteger bd = 1;
        static BigInteger longProduct = 1;

        //public static BigInteger CalculateProductRecursive(BigInteger firstMultiplier, BigInteger secondMultiplier)
        //{
        //    i++;
        //    Console.WriteLine("\nIteration = " + i);
        //    int n = firstMultiplier.ToString().Length;
        //    if (n != 1)
        //    {
        //        a = BigInteger.Parse(firstMultiplier.ToString().Substring(0, n / 2));
        //        c = BigInteger.Parse(secondMultiplier.ToString().Substring(0, n / 2));               
        //        Console.WriteLine("a = " + a);
        //        Console.WriteLine("c = " + c);
        //        ac = CalculateProductRecursive(a, c);
        //    }
        //    else
        //    {
        //        ac = a*c;
        //    }

        //    //if (secondMultiplier.ToString().Length != 1)
        //    //{
        //    //    b = BigInteger.Parse(firstMultiplier.ToString().Substring(n/2));
        //    //    d = BigInteger.Parse(secondMultiplier.ToString().Substring(n / 2));
        //    //    Console.WriteLine("c = " + c);
        //    //    Console.WriteLine("d = " + d);
        //    //    bd = CalculateProductRecursive(b, d);
        //    //}
        //    //else
        //    //{
        //    //    bd = b * d;
        //    //    if ((a + b).ToString().Length != 1 || (c + d).ToString().Length != 1)
        //    //    {
        //    //        CalculateProductRecursive(a + b, c + d);
        //    //    }
        //    //    longProduct = (a + b) * (c + d);
        //    //    Console.WriteLine("ac = " + ac);
        //    //    Console.WriteLine("bd = " + bd);
        //    //    return longProduct - ac - bd;
        //    //}

        //    //ac = ac*CalculateProductRecursive(a, c);
        //    //bd = CalculateProductRecursive(b, d);

        //   // result = (a + b) * (c + d) - CalculateProductRecursive(a, c) - CalculateProductRecursive(b, d); //BigInteger.Pow(10, n)*ac + BigInteger.Pow(10, n/2)*((a + b)*(c + d) - ac - bd) + bd;
        //    //Console.WriteLine("ac = " + ac);
        //    //Console.WriteLine("bd = " + bd);
        //    //Console.WriteLine("result = " + result);
        //     return ac;
        //}
    }
}
