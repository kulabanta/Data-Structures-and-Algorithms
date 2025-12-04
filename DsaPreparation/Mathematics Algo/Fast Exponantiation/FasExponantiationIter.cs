namespace FastExponantiation
{
    public class FastExponatiationIter
    {
        public double Power(long x, int n)
        {
            double ans = 1;
            int m = n;
            n = Math.Abs(n);
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    ans = ans * x;
                }
                x = x * x;
                n = n / 2;
            }
            return m<0 ? 1/ans:ans;
        }
    }
}