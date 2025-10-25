//pending solution
namespace DsaPreparation.BinarySearch
{
    public class UglyNumberIII
    {
        public int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
        public int ElementsBefore(int n, int a, int b, int c)
        {
            double ab = a * b / gcd(a, b);
            double bc = b * c / gcd(b, c);
            double ac = a * c / gcd(a, c);
            double abc = a * bc / gcd(a, (int)bc);
            return n / a + n / b + n / c - n / (int)ab - n / (int)ac - n / (int)bc + n / (int)abc;
        }
        public int NthUglyNumber(int n, int a, int b, int c)
        {
            int l = 1;
            int r = 2000000000;

            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (ElementsBefore(mid, a, b, c) >= n)
                    r = mid;
                else
                    l = mid + 1;
            }
            return l;
        }
    }
}