public class SortColors {
    public int MaxNumberOfFamilies(int n, int[][] rs) {
        Dictionary<int,List<int>> dt = new();
        for(int i=0;i<rs.Length;i++)
        {
            if(dt.ContainsKey(rs[i][0]))
            {
                dt[rs[i][0]].Add(rs[i][1]-1);
            }
            else{
                dt[rs[i][0]] = new List<int>(){rs[i][1]-1};
            }
        }
        int q = (1<<4)-1;
        int q1 = q<<3;
        int q2 = q<<5;
        int q3 = q<<1;
        int res = 0;
        foreach(var kv in dt)
        {
            List<int> l = kv.Value;
            int y = (1<<10)-1;
            foreach(int c in l)
            {
                y&=~(1<<c);
            }
            if((y&q2)==q2 || (y&q3)==q3)
            {
                if((y&q2)==q2)
                    res++;
                
                if((y&q3)==q3)
                    res++;
            }
            else if((y&q1)==q1)
            {
                res++;
            }

        }
        return res+(n-dt.Count)*2;
    }
}