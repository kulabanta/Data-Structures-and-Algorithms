namespace DsaPreparation.Mathematics_Algo.Prime_Numbers
{
    internal class LargestPrimeFactor
    {
        public int largestPrimeFactor(int n)
        {
            int res = 2;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
            {
                if ((n % i) == 0)
                {
                    res = i;
                    while ((n % i) == 0)
                    {
                        n = n / i;
                    }
                }
            }
            if (n != 1)
                res = n;
            return res;

        }
    }
}
