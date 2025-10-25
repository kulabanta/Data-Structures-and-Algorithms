namespace DsaPreparation.BinarySearch
{
    public class KthSmallestNumberInMultiplicationTable
    {

        public int NoOfElementsBefore(int m, int n, int k)
        {
            int res = 0;
            for (int i = 1; i <= m; i++)
            {
                res += Math.Min(k / i, n);
            }
            return res;
        }
        public int FindKthNumber(int m, int n, int k)
        {
            int l = 1;
            int r = m * n;

            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (NoOfElementsBefore(m, n, mid) >= k)
                    r = mid;
                else
                    l = mid + 1;
            }
            return l;
        }
    }
}