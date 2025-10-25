public class SortColors {
    public int Jump(int[] nums) {
        int n = nums.Length;
        if(n<=1)
            return 0;
        int res = 1;
        int i = 0;
        int mx = nums[0];
        int mxn = nums[0];

        while(i<n-1)
        {
            mxn = Math.Max(mxn , i+nums[i]);
            if(i==mx)
            {
                res++;
                mx = mxn;
            }
            i++;
        }
        return res;
    }
}