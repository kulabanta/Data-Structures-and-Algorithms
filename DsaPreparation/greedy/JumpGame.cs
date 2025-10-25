public class SortColors {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        bool[] feasible = new bool[n];
        Array.Fill(feasible,false);
        feasible[n-1]=true;
        for(int i=n-2;i>=0;i--)
        {
            int j = Math.Min(n-1,i+nums[i]);
            while(j>i)
            {
                if(feasible[j])
                {
                    feasible[i]=true;
                    break;
                }
                j--;
            }
        }
        return feasible[0];
    }
}