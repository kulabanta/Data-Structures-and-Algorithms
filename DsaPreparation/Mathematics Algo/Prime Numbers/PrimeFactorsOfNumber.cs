namespace DsaPreparation.Mathematics_Algo.Prime_Numbers
{
    internal class PrimeFactorsOfNumber
    {
        public List<int> PrimeFactors(int n)
        {
            List<int> res = new();
            for (int i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    res.Add(i);
                    while (n % i == 0)
                    {
                        n = n / i;
                    }
                }
            }
            if (n != 1)
                res.Add(n);
            return res;
        }
    }
}
