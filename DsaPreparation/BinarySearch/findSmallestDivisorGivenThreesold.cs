namespace DsaPreparation.BinarySearch
{
    public class findSmallestDivisorGivenThreesold
    {
        public int DivisionResult(int[] nums, int d)
        {
            int n = nums.Length;
            double res = 0;
            foreach (int p in nums)
            {
                res += Math.Ceiling((double)p / d);
            }
            return (int)res;
        }
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int n = nums.Length;
            int l = 1;
            int r = 1;
            for (int i = 0; i < n; i++)
                r = Math.Max(r, nums[i]);

            while (l < r)
            {
                int mid = l + (r - l) / 2;

                if (DivisionResult(nums, mid) <= threshold)
                    r = mid;
                else
                    l = mid + 1;
            }
            return l;

        }
    }
}