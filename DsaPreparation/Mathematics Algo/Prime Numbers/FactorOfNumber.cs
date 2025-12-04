namespace PrimeNumbers
{
    /**
        TC = O(Sqrt(n))
        Sc = O(1)
    **/
    public class FactorOfNumber
    {
        public List<int> Factors(int n)
        {
            List<int> res = new();
            for(int i=1;i*i<=n;i++)
            {
                if((n%i)==0)
                {
                    res.Add(i);
                    if(i!=(n/i))
                        res.Add(n/i);
                }
            }
            return res;
        }
    }
}