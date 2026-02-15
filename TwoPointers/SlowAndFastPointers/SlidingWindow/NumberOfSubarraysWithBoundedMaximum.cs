namespace TwoPointers.SlowAndFastPointers.SlidingWindow
{
    internal class NumberOfSubarraysWithBoundedMaximum
    {
        public int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {
            int n = nums.Length;
            int i = 0, j = 0, mx = 0, res = 0;
            while (j < n)
            {
                if (nums[j] >= left && nums[j] <= right)
                {
                    /**
                        mx will keep track of latest number on the right which is inside the bound
                        so that if we start from that number , we are sure that we have at least on number which 
                        is in the bound 
                    **/
                    mx = j;
                }
                if (nums[j] > right)
                {
                    /**if current num is greate than the right
                        we cannot form any subarray on the left side
                        so we move to the next element
                    **/
                    j++;
                    i = j;
                    mx = j;
                }
                else
                {

                    if (mx != i)
                    {
                        //Here we are sure , we have at least one number in the range from [i,mx], which satisfy the bound
                        res += (mx - i + 1);
                    }
                    //if there is only one number , we need to check if it really satisfy the condition
                    else if (nums[mx] >= left && nums[mx] <= right)
                        res++;
                    j++;
                }
            }
            return res;
        }
    }
}
