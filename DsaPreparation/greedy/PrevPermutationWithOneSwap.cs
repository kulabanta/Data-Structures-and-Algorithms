public class SortColors {
    public int[] PrevPermOpt1(int[] arr) {
        int n = arr.Length;
        Stack<int> st = new();
        for(int i = n-1;i>=0;i--)
        {
            if(st.Count()>0 && arr[i]>arr[st.Peek()])
            {
                int p = i;
                while(st.Count()>0 && arr[i]>arr[st.Peek()])
                {
                    p=st.Peek();
                    st.Pop();
                }
                int x = arr[i];
                arr[i]=arr[p];
                arr[p]=x;
                break;
            }
            else
            {
                if(st.Count()>0 && arr[i]==arr[st.Peek()])
                    st.Pop();
                st.Push(i);
            }
                
        }
        return arr;
    }
}