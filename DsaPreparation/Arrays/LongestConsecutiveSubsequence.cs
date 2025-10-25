namespace DsaPreparation.Arrays
{
    public class LongestConsecutive
    {
        public int LongestConsecutive(int[] nums)
        {
            int n = nums.Length;
            if (n <= 1)
                return n;

            int temp = 1;
            int res = 0;
            int i = 1;
            Array.Sort(nums);
            while (i < n)
            {
                if (nums[i] == nums[i - 1])
                {
                    i++;
                    continue;
                }
                if (nums[i] - nums[i - 1] > 1)
                {
                    Console.WriteLine($"i:{i},temp:{temp}");
                    res = Math.Max(res, temp);
                    temp = 1;
                }
                else
                    temp++;
                i++;
            }
            res = Math.Max(res, temp);
            return res;
        }
    }
}