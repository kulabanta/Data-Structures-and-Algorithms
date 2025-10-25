namespace DsaPreparation.Arrays
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dt = new();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (dt.ContainsKey(nums[i]))
                {
                    dt[nums[i]] = i;
                }
                else
                {
                    dt.Add(nums[i], i);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (dt.ContainsKey(target - nums[i]) && i != dt[target - nums[i]])
                {
                    return new int[] { i, dt[target - nums[i]] };
                }
            }
            return [];
        }
    }
}