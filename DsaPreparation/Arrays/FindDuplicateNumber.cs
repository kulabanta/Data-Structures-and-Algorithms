namespace DsaPreparation.Arrays
{
    public class FindDuplicate
    {
        public int FindDuplicateImpl(int[] nums)
        {
            int n = nums.Length;
            int s = 0;
            int f = 0;

            do
            {
                s = nums[s];
                f = nums[nums[f]];
            } while (s != f);

            int s1 = 0;

            while (s1 != s)
            {
                s1 = nums[s1];
                s = nums[s];
            }
            return s;
        }
    }
}