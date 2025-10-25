public class SortColors {
    public int MinSetSize(int[] arr) {
        Dictionary<int,int> d = new();
        int n = arr.Length;
        for(int i=0;i<n;i++)
        {
            if(d.ContainsKey(arr[i]))
                d[arr[i]]++;
            else
                d.Add(arr[i],1);
        }
        d = d.OrderByDescending(kvp =>  kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        int res = 0;
        int temp = 0;

        foreach(var kvp in d)
        {
            temp+=kvp.Value;
            res++;
            if(temp>=n/2){
                return res;
            }

        }
        return res;
    }
}