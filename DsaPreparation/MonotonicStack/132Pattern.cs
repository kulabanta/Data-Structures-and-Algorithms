public class SortColors {
    public bool Find132pattern(int[] nums) {
        int n = nums.Length;
        Stack<int> st = new();
        int[] minimum = new int[n];
        Array.Fill(minimum, 0);

        for(int i=1;i<n;i++)
        {
            if(nums[i]<nums[minimum[i-1]])
            {
                minimum[i]=i;
            }
            else
                minimum[i]=minimum[i-1];
        }
        for(int i=0;i<n;i++)
        {
            while(st.Count()>0 && nums[i]>=nums[st.Peek()])
            {
                st.Pop();
            }
            if(st.Count()>0)
            {
                int x = nums[minimum[st.Peek()]];
                if(x<nums[i])
                    return true;
            }
            st.Push(i);
        }
        return false;
    }
}