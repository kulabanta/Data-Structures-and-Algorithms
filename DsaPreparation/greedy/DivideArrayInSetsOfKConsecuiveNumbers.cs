public class SortColors {
    public bool IsPossibleDivide(int[] nums, int k) {
        int n = nums.Length;
        Dictionary<int,int> sd = new();
        for(int i=0;i<n;i++)
        {
            if(!sd.ContainsKey(nums[i]))
                sd.Add(nums[i],1);
            else
                sd[nums[i]]++;
        }
        List<int> keys = sd.Keys.ToList();
        keys.Sort();
        foreach(int p in keys)
        {
            if(sd[p]==0)
                continue;
            for(int i=1;i<k;i++)
            {
                if(sd.ContainsKey(p+i) && sd[p+i]>=sd[p])
                {
                    sd[p+i]-=sd[p];
                }
                else
                    return false;
            }
            sd[p]=0;
        }
        return true;
    }
}