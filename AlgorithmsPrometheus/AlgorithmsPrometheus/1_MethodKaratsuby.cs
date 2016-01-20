using System.Numerics;

namespace AlgorithmsPrometheus
{
    class _1_MethodKaratsuby
    {
        public static BigInteger CalculateProduct(BigInteger firstMultiplier, BigInteger secondMultiplier)
        {
            int n = firstMultiplier.ToString().Length;

            BigInteger a = System.Numerics.BigInteger.Parse(firstMultiplier.ToString().Substring(0, n / 2));
            BigInteger b = BigInteger.Parse(firstMultiplier.ToString().Substring(n / 2));
            BigInteger c = BigInteger.Parse(secondMultiplier.ToString().Substring(0, n / 2));
            BigInteger d = BigInteger.Parse(secondMultiplier.ToString().Substring(n / 2));

            BigInteger ac = a * c;
            BigInteger bd = b * d;
            return BigInteger.Pow(10, n) * ac + BigInteger.Pow(10, n / 2) * ((a + b) * (c + d) - ac - bd) + bd;
        }
    }
}
