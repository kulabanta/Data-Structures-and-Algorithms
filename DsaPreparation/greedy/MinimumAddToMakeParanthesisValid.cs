public class SortColors {
    public int MinAddToMakeValid(string s) {
        int n = s.Length;
        int open=0;
        int closed=0;
        for(int i=0;i<n;i++)
        {
            if(s[i]=='(')
                open++;
            else{
                if(open>0)
                {
                    open--;
                }
                else{
                    closed++;
                }
            }
        }
        return open+closed;
    }
}