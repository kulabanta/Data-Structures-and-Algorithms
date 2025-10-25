public class SortColors {
    public int WiggleMaxLength(int[] nums) {
        int n = nums.Length;
        if(n<2)
            return n;
        List<int> res = new();
        res.Add(nums[0]);

        for(int i=1;i<n;i++)
        {
            int d = nums[i]-res[res.Count()-1];
            if(d==0)
                continue;
            if(res.Count()<2)
            {
                res.Add(nums[i]);
                continue;
            }
            int pd = res[res.Count()-1]-res[res.Count()-2];
            if((pd>0 && d>0) || (pd<0 && d<0))
                res[res.Count()-1]=nums[i];
            else
                res.Add(nums[i]);
        }
        return res.Count();
    }
}