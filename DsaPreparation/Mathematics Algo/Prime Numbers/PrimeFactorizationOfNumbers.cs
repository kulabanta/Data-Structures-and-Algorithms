namespace DsaPreparation.Mathematics_Algo.Prime_Numbers
{
    internal class PrimeFactorizationOfNumbers
    {
        public List<List<int>> PrimeFactorizations(List<int> queries)
        {
            List<List<int>> res = new();
            var spfObj = new SmallestPrimeFactors();
            int[] spfs = spfObj.smallestPrimeFactors(100000);
            foreach (int q in queries)
            {
                List<int> temp = new();
                int n = q;
                while (n != 1)
                {
                    temp.Add(spfs[n]);
                    n /= spfs[n];
                }
                res.Add(temp);
            }
            return res;
        }
    }
}
