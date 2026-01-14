namespace TwoPointers.TwoSumProblems
{
    public class NumberOfSubsequenceThatSatisfygivenCondition
    {
        private int modulo = (int)1000000007;
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);
            int i = 0;
            int j = nums.Length - 1;
            int n = nums.Length;
            int res = 0;
            int[] power = new int[n];
            power[0] = 1;
            for (int k = 1; k < n; k++)
            {
                power[k] = (power[k - 1] * 2) % modulo;
            }
            while (i <= j)
            {
                if (nums[i] + nums[j] <= target)
                {
                    res = ((res % modulo) + power[j - i]) % modulo;
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return res;
        }
    }
}
