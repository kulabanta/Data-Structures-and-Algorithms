public class StockSpanner
{
    Stack<int> st;
    Dictionary<int, int> dt;
    public StockSpanner()
    {
        st = new();
        dt = new();
    }

    public int Next(int price)
    {
        int val = 1;
        while (st.Count() > 0 && price >= st.Peek())
        {
            val += dt[st.Peek()];
            dt.Remove(st.Peek());
            st.Pop();
        }
        st.Push(price);
        dt.Add(price, val);
        return val;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */