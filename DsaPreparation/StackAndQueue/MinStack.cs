
public class MinStack {
    Stack<int> st , minSt;
    public MinStack() {
        st = new();
        minSt = new();
    }
    
    public void Push(int val) {
        st.Push(val);
        if(minSt.Count()>0)
        {
            if(val <= minSt.Peek())
                minSt.Push(val);
        }
        else{
            minSt.Push(val);
        }
    }
    
    public void Pop() {
        if(st.Count()>0)
        {
            int val = st.Peek();
            st.Pop();
            if(minSt.Count()>0 && val == minSt.Peek())
            {
                minSt.Pop();
            }
        }
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minSt.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */