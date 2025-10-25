public class SortColors {
    public string RemoveKdigits(string num, int k) {
        int n = num.Length;
        Stack<char> st = new();

        for(int i=0;i<n;i++)
        {
            while(st.Count()>0 && st.Peek()>num[i] && k>0)
            {
                st.Pop();
                k--;
            }
            st.Push(num[i]);
        }
        while(k>0)
        {
            st.Pop();
            k--;
        }
        string res = "";
        while(st.Count()>0)
        {
            res = st.Peek()+res;
            st.Pop();
        }
        
        int p = 0;
        while(p<res.Length && res[p]=='0')
            p++;
        
        if(res.Length==p)
            return "0";
        return res.Substring(p);

    }
}