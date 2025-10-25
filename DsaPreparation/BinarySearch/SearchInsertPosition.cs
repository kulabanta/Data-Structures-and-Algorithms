namespace DsaPreparation.BinarySearch
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int n = nums.Length;
            int l = 0;
            int r = n;

            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (nums[m] >= target)
                    r = m;
                else
                    l = m + 1;
            }
            return l;
        }
    }
}
// find the smallest for all elements which is greater than target
