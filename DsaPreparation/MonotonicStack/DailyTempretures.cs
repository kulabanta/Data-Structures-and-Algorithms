public class SortColors {
    public int[] DailyTemperatures(int[] temp) {
        int n = temp.Length;
        Stack<int> st = new();
        int[] res = new int[n];
        Array.Fill(res,0);

        for(int i=0;i<n;i++)
        {
            while(st.Count()>0 && temp[st.Peek()]<temp[i])
            {
                res[st.Peek()]=i-st.Peek();
                st.Pop();
            }
            st.Push(i);
        }
        return res;
    }
}