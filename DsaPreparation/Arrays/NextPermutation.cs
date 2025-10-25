namespace DsaPreparation.Arrays
{
    public class NextPermutation
    {
        public int MaxSubArray(int[] nums)
        {
            int n = nums.Length;
            int res = int.MinValue;
            int temp = 0;
            int ansStart = 0, ansEnd = 0;
            int start = 0;
            for (int i = 0; i < n; i++)
            {
                temp += nums[i];
                if (temp > res)
                {
                    res = temp;
                    ansStart = start;
                    ansEnd = i;
                }
                if (temp < 0)
                {
                    start = i + 1;
                    temp = 0;
                }

            }
            for (int i = ansStart; i <= ansEnd; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            return res;
        }
    }
}