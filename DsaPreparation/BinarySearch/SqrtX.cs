//find the smallest element whose square is greater than x
// just below the number is the sqrt of x
namespace DsaPreparation.BinarySearch
{
    public class SqrtX
    {
        public int MySqrt(int x)
        {
            if (x <= 1)
                return x;
            double l = 0;
            double r = x;

            while (l < r)
            {
                double m = l + Math.Floor((r - l) / 2);
                double p = Math.Floor(x / m);
                if (p < m)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return (int)l - 1;
        }
    }
}