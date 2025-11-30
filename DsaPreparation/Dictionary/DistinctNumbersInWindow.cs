namespace DsaPreparation.Dictionary
{
    internal class DistinctNumbersInWindow
    {
        public List<int> dNums(List<int> A, int B)
        {
            if (B == 1)
            {
                return Enumerable.Repeat(1, A.Count).ToList();
            }
            List<int> res = new();
            Dictionary<int, int> dt = new();
            int i = 0, j = 0;
            while (j < B)
            {
                if (dt.ContainsKey(A[j]))
                {
                    dt[A[j]]++;
                }
                else
                {
                    dt.Add(A[j], 1);
                }
                j++;
            }
            res.Add(dt.Count);
            while (j < A.Count)
            {
                dt[A[i]]--;
                if (dt[A[i]] == 0)
                    dt.Remove(A[i]);
                if (dt.ContainsKey(A[j]))
                {
                    dt[A[j]]++;
                }
                else
                {
                    dt.Add(A[j], 1);
                }
                i++;
                j++;
                res.Add(dt.Count);
            }
            return res;
        }
    }
}
