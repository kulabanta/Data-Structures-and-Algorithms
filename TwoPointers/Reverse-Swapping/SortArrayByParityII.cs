namespace TwoPointers.Reverse_Swapping
{
    public class SortArrayByParityII
    {
        public int[] sortArrayByParityII(int[] nums)
        {
            int i = 0;
            int j = 1;
            int n = nums.Length;
            while (i < n && j < n)
            {
                if ((nums[i] & 1) == 0)
                {
                    i += 2;
                }
                else if ((nums[j] & 1) == 1)
                {
                    j += 2;
                }
                else
                {
                    int p = nums[i];
                    nums[i] = nums[j];
                    nums[j] = p;
                    i += 2;
                    j += 2;
                }
            }
            return nums;
        }
    }
}
