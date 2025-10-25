public class SortColors {
    public int FindContentChildren(int[] g, int[] s) {
        int n = g.Length;
        int m = s.Length;

        int i = 0;
        int j = 0;

        Array.Sort(g);
        Array.Sort(s);

        while(i<n)
        {
            while(j<m && g[i]>s[j])
                j++;
            if(j==m)
                break;
            else
                j++;
            i++;
        }
        return i;
    }
}