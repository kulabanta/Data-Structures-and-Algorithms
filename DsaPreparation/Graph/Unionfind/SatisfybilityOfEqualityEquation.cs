public class SortColors {
    int[] parent,rank;
    public int Find(int x)
    {
        if(parent[x]==x)
            return x;
        return Find(parent[x]);
    }
    public void Union(int x,int y)
    {
        int a = Find(x);
        int b = Find(y);

        if(a==b)
            return ;
        
        if(rank[a]>rank[b])
        {
            parent[b]=a;
        }
        else if(rank[a]<rank[b])
        {
            parent[a]=b;
        }
        else{
            parent[a]=b;
            rank[b]++;
        }
    }
    public bool EquationsPossible(string[] equations) {
        parent = new int[26];
        rank = new int[26];
        for(int i=0;i<26;i++)
        {
            parent[i]=i;
            rank[i]=0;
        }
        List<int> extra = new();
        for(int i=0;i<equations.Length;i++)
        {
            if(equations[i][1]=='!')
                extra.Add(i);
            else{
                Union((int)equations[i][0]-(int)'a',(int)equations[i][3]-(int)'a');
            }
        }
        foreach(int p in extra)
        {
            string s = equations[p];

            if(Find((int)s[0]-(int)'a')==Find((int)s[3]-(int)'a'))
                return false;
        }
        return true;
    }
}