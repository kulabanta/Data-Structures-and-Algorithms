public class Solution1
{
    public int[] FindBuildings(int[] heights)
    {
        int n = heights.Length;
        Stack<int> st = new();

        for(int i=0;i<n;i++)
        {
            while(st.Count() >0 && heights[st.Peek()]<=heights[i])
                st.Pop();
            st.Push(i);
        }
        int[] res = new int[st.Count()];
        while(st.Count()>0)
        {
            res[st.Count()-1]=st.Peek();
            st.Pop();
        }
        return res;
    }
}