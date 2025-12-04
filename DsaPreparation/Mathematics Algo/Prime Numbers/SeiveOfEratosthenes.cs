namespace FastExponantiation
{
    /**
        TC : O(nlog(log(n)))
        SC : O(n)
    **/
    public class SeiveOfEratosthenes
    {
        public List<int> sieve(int n)
        {
            List<int> res = new List<int>();
            var primes = Enumerable.Repeat<bool>(true, n + 1).ToList();
            for (int i = 2; i <= Math.Floor(Math.Sqrt((double)n)); i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
            for (int k = 2; k <= n; k++)
            {
                if (primes[k])
                    res.Add(k);
            }
            return res;
        }
    }
}