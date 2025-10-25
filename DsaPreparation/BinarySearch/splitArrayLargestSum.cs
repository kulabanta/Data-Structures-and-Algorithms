namespace DsaPreparation.BinarySearch
{
    public class SplitArrayLargestSum
    {
        public bool feasible(int[] nums, int k, int m)
        {
            int n = nums.Length;
            int temp = 0;
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                temp += nums[i];
                if (temp > m)
                {
                    temp = nums[i];
                    p++;
                    if (p > k)
                        return false;
                }
            }
            return true;
        }
        public int SplitArray(int[] nums, int k)
        {
            int n = nums.Length;
            int l = 0;
            int r = 0;

            for (int i = 0; i < n; i++)
            {
                l = Math.Max(l, nums[i]);
                r += nums[i];
            }

            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (feasible(nums, k, m))
                    r = m;
                else
                    l = m + 1;
            }
            return l;
        }
    }
}