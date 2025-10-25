namespace DsaPreparation.Arrays
{
    public class Comparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a[0] == b[0])
            {
                return a[1] - b[1];
            }
            return a[0] - b[0];
        }
    }
    public class MergeIntervals
    {
        private bool Overlaps(int[] a, int[] b)
        {
            int x = Math.Max(a[0], b[0]);
            int y = Math.Min(a[1], b[1]);

            return x <= y;
        }
        public int[][] Merge(int[][] intervals)
        {
            int n = intervals.Length;
            if (n <= 1)
                return intervals;
            Array.Sort(intervals, new Comparer());
            List<int[]> res = new();
            res.Add(intervals[0]);
            for (int i = 1; i < n; i++)
            {
                if (Overlaps(res[res.Count - 1], intervals[i]))
                {
                    int[] a = res[res.Count - 1];
                    a[0] = Math.Min(a[0], intervals[i][0]);
                    a[1] = Math.Max(a[1], intervals[i][1]);
                    res[res.Count - 1] = a;
                }
                else
                {
                    res.Add(intervals[i]);
                }
            }
            return res.ToArray();
        }

    }
}