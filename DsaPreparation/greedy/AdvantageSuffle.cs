public class pair{
    public int value;
    public int index;
}
public class Comparer : IComparer<pair>{
    public int Compare(pair a, pair b)
    {
        if(a.value == b.value)
            return a.index-b.index;
        return a.value-b.value;
    }
}
public class SortColors {
    public int[] AdvantageCount(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        Array.Sort(nums1);
        List<pair> b = new();
        for(int k=0;k<n;k++){
            b.Add(new pair{
                value = nums2[k],
                index = k
            });
        }
        b.Sort(new Comparer());
        int i = 0;
        int j = 0;
        int[] res = new int[n];
        Array.Fill(res,-1);

        while(i<n && j<n)
        {
            while(i<n && nums1[i]<=b[j].value)
                i++;
            if(i==n)
                break;
            res[b[j++].index]=nums1[i];
            nums1[i++]=-1;
        }
        i=0;
        while(j<n)
        {
            while(i<n && nums1[i]==-1)
                i++;
            res[b[j++].index]=nums1[i];
            nums1[i++]=-1;
        }
        return res;
    }
}