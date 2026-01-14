namespace TwoPointers.TwoSumProblems
{
    internal class MinimizeMaximumPairSumInArray
    {
        public int MinPairSum(int[] nums)
        {
            int n = nums.Length;
            int res = 0;
            int i = 0;
            int j = n - 1;
            Array.Sort(nums);
            while (i < j)
            {
                int s = nums[i] + nums[j];
                res = Math.Max(res, s);
                i++;
                j--;
            }
            return res;
        }
    }
}
