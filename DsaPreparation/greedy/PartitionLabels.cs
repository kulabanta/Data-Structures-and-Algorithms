public class SortColors {
    public IList<int> PartitionLabels(string s) {
        int[] li = new int[26];
        Array.Fill(li,0);
        int n = s.Length;
        for(int i =0;i<n;i++)
        {
            li[(int)s[i]-(int)'a']=i;
        }

        List<int> res = new();
        int mx = 0;
        int j = 0;
        for(int i=0;i<n;i++)
        {
            mx = Math.Max(mx,li[(int)s[i]-(int)'a']);
            if(mx == i)
            {
                res.Add(mx-j+1);
                j=i+1;
            }
        }
        return res;
    }
}