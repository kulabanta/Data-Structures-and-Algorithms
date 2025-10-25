public class SortColors {
    public int[] CanSeePersonsCount(int[] heights) {
        int n = heights.Length;
        Stack<int> st = new();
        int[] res = new int[n];
        Array.Fill(res,0);

        for(int i= n-1;i>=0;i--)
        {
            int p = 0;
            while(st.Count()>0)
            {
                int x = Math.Min(heights[i],st.Peek());
                if(x > p)
                {
                    res[i]++;
                    p=Math.Max(p,st.Peek());
                    st.Pop();
                }
                else
                    break;
            }
            st.Push(p);
            st.Push(heights[i]);
        }
        return res;
    }
}