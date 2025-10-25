class CelebrityProblem
{
    public int celebrity(int[,] mat)
    {
        int n = (int)Math.Sqrt(mat.Length);
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < n; i++)
        {

            bool pot = true;
            while (st.Count() > 0)
            {
                if (mat[st.Peek(), i] == 1 && mat[i, st.Peek()] == 1)
                {

                    pot = false;
                }
                if (mat[st.Peek(), i] == 1)
                    st.Pop();
                else
                {
                    break;
                }
            }
            if (pot)
                st.Push(i);
        }
        while (st.Count() > 0)
        {
            int p = st.Peek();
            st.Pop();
            bool res = true;
            for (int i = 0; i < n; i++)
            {
                if (i != p && (mat[i, p] == 0 || mat[p, i] == 1))
                {
                    res = false;
                    break;
                }
            }
            if (res)
                return p;
        }
        return -1;
    }
}
