namespace DsaPreparation.Mathematics_Algo.Prime_Numbers
{
    internal class SegmentedSeive
    {
        public List<int> PrimeNumbersSegmentedSeive(int L,int R)
        {
            int rootR = (int)Math.Floor(Math.Sqrt(R));
            List<int> res = new();

            List<int> primes = PrimeNumbersSeive(rootR);

            bool[] isPrimes = Enumerable.Repeat<bool>(true, (R - L + 1)).ToArray();

            foreach(var prime in primes)
            {
                int x = (int)Math.Ceiling(1.0 * L / prime)*prime;
                x = x - L;
                while(x<(R-L+1))
                {
                    isPrimes[x] = false;
                    x += prime;
                }
            }
            for(int i = 0;i<(R-L+1);i++)
            {
                if (isPrimes[i])
                {
                    res.Add(L + i);
                }
            }
            return res;
        }
        private List<int> PrimeNumbersSeive(int n)
        {
            List<int> res = new();
            int rootN = (int)Math.Floor(Math.Sqrt(n));
            bool[] prime = Enumerable.Repeat<bool>(true, n + 1).ToArray();

            for(int i= 2;i<=rootN;i++)
            {
                if (prime[i])
                {
                    for(int j = i*i; j<=n; j++)
                    {
                        prime[j] = false;
                    }
                }
            }
            for(int i=2;i<=n;i++)
            {
                if (prime[i])
                    res.Add(i);

            }
            return res;
        }
    }
}
