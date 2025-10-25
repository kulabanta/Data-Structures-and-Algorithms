namespace DsaPreparation.Arrays
{
    public class SubArraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> dt = new();
            int n = nums.Length;
            int res = 0;
            int temp = 0;
            dt.Add(0, 1);
            for (int i = 0; i < n; i++)
            {
                temp += nums[i];
                if (dt.ContainsKey(temp - k))
                    res += dt[temp - k];
                if (dt.ContainsKey(temp))
                    dt[temp]++;
                else
                    dt.Add(temp, 1);
            }
            return res;
        }
    }
}