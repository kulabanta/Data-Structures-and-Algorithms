namespace DsaPreparation.BinarySearch
{
    public class FindKthSmallestPairDistance
    {
        public int enough(int[] nums, int k)
        {
            int i = 0;
            int j = 1;
            int n = nums.Length;
            int res = 0;
            while (j < n)
            {
                if (nums[j] - nums[i] <= k)
                {
                    res += j - i;
                    j++;
                }
                else
                {
                    i++;
                    if (i == j)
                        j++;
                }

            }
            return res;

        }
        public int SmallestDistancePair(int[] nums, int k)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int l = 0;
            int r = 0;
            for (int i = 0; i < n; i++)
                r = Math.Max(r, nums[i]);

            while (l < r)
            {
                int mid = l + (r - l) / 2;
                int p = enough(nums, mid);
                if (p >= k)
                    r = mid;
                else
                    l = mid + 1;
            }
            return l;
        }
    }
}