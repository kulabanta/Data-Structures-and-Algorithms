namespace DsaPreparation.Arrays
{
    public class PowXN
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return x;
            if (x == 1 || x == 0)
                return x;
            if (x < 0)
                return (n % 2 == 0 ? 1 : -1) * MyPow(-x, n);

            if (n % 2 == 0)
                return MyPow(x * x, n / 2);
            if (n < 0)
                return 1 / x * MyPow(x, n + 1);
            else
                return x * MyPow(x, n - 1);
        }
    }
}