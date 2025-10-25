public class SortColors {
    public int[] NextGreaterElements(int[] nums) {
        int n = nums.Length;
        Stack<int> st = new();
        int[] res = new int[n];
        Array.Fill(res,-1);

        for(int i=0;i<2*n;i++)
        {
            int x = i%n;
            while(st.Count()>0 && nums[st.Peek()]<nums[x])
            {
                res[st.Peek()]=x;
                st.Pop();
            }
            st.Push(x);
        }
        for(int i=0;i<n;i++)
        {
            if(res[i]!=-1)
            {
                res[i]=nums[res[i]];
            }
        }
        return res;
    }
}