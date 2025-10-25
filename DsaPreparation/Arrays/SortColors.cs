namespace DsaPreparation.Arrays
{
    public class SortColor
    {
        public void SortColors(int[] nums)
        {
            int n = nums.Length;
            int i = 0;
            int l = 0;
            int r = n - 1;

            while (i <= r)
            {
                if (nums[i] == 0)
                {
                    int x = nums[i];
                    nums[i] = nums[l];
                    nums[l] = x;

                    if (i == l)
                        i++;
                    l++;
                }
                else if (nums[i] == 2)
                {
                    int x = nums[i];
                    nums[i] = nums[r];
                    nums[r] = x;
                    r--;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}