public class SortColors {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        Stack<int> st = new();

        for(int i=0;i<n;i++)
        {
            while(st.Count()>0 && heights[st.Peek()]>=heights[i])
            {
                st.Pop();
            }
            if(st.Count()>0)
                left[i]=st.Peek()+1;
            else
                left[i]=0;
            st.Push(i);
        }
        st.Clear();
        for(int i=n-1;i>=0;i--)
        {
            while(st.Count()>0 && heights[st.Peek()]>=heights[i])
            {
                st.Pop();
            }
            if(st.Count()>0)
                right[i]=st.Peek()-1;
            else
                right[i]=n-1;
            st.Push(i);
        }
        int res = 0;
        for(int i=0;i<n;i++)
        {
            res = Math.Max(res,(right[i]-left[i]+1)*heights[i]);
        }
        return res;
    }
}