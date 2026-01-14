namespace TwoPointers.NextPermutation
{
    internal class NextGreaterElementIII
    {
        public int NextGreaterElement(int n)
        {
            List<int> arr = new List<int>();
            while (n > 0)
            {
                arr.Add(n % 10);
                n /= 10;
            }
            arr.Reverse();
            int i = arr.Count - 1;
            while (i > 0 && arr[i] <= arr[i - 1])
                i--;
            if (i == 0)
                return -1;
            else
            {
                int j = i;
                int p = i;
                i--;
                while (j < arr.Count)
                {
                    if (arr[j] > arr[i] && arr[j] < arr[p])
                        p = j;
                    j++;
                }
                int x = arr[i];
                arr[i] = arr[p];
                arr[p] = x;
                arr.Sort(i + 1, arr.Count - i - 1, null);
                long res = 0;
                i = 0;
                while (i < arr.Count)
                {
                    res = res * 10 + arr[i];
                    i++;
                }
                if (res > Int32.MaxValue)
                    return -1;
                return (int)res;

            }
        }
    }
