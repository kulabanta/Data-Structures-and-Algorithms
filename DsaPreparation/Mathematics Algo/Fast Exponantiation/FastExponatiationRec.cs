namespace FastExponantiation
{
    public class FastExponatiationRec
    {
        public long Power(long x, int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 0)
            {
                long halfPower = Power(x, n / 2);
                return halfPower * halfPower;
            }
            else
            {
                return x * Power(x, n - 1);
            }
        }
    }
}