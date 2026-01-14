namespace TwoPointers.Others
{
    internal class ShortestDistanceToAChar
    {
        public int[] ShortestToChar(string s, char c)
        {
            List<int> temp = new();
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == c)
                    temp.Add(i);
            }
            int[] res = new int[n];
            Array.Fill(res, 0);
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != temp[idx])
                {
                    res[i] = Math.Abs(i - temp[idx]);
                    if (idx > 0 && i < temp[temp.Count - 1])
                    {
                        res[i] = Math.Min(res[i], Math.Abs(i - temp[idx - 1]));
                    }

                }
                else if (i == temp[idx] && idx < temp.Count - 1)
                {
                    idx++;
                }
            }
            return res;
        }
    }
}
