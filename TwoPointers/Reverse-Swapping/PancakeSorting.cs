namespace TwoPointers.Reverse_Swapping
{
    public class PancakeSorting
    {
        public void ReverseArray(ref int[] arr, int idx)
        {
            int i = 0;
            int j = idx;

            while (i < j)
            {
                int p = arr[i];
                arr[i] = arr[j];
                arr[j] = p;
                i++;
                j--;
            }
        }
        public IList<int> PancakeSort(int[] arr)
        {
            IList<int> res = new List<int>();
            int n = arr.Length;

            for (int i = n - 1; i > 0; i--)
            {
                int mxIdx = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (arr[j] > arr[mxIdx])
                    {
                        mxIdx = j;
                    }
                }
                if (mxIdx > 0)
                {
                    ReverseArray(ref arr, mxIdx);
                    res.Add(mxIdx + 1);
                }
                ReverseArray(ref arr, i);
                res.Add(i + 1);

            }
            return res;

        }
    }
}
