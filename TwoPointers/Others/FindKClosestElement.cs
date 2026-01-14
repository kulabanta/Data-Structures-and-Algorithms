using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Others
{
    internal class FindKClosestElement
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int n = arr.Length;
            if (k == n)
                return arr.ToList();
            int i = 0, j = n - 1;
            while (i < j)
            {
                int mid = i + (j - i) / 2;
                if (arr[mid] >= x)
                {
                    j = mid;
                }
                else
                {
                    i = mid + 1;
                }
            }
            i = j - 1;
            LinkedList<int> res = new LinkedList<int>();

            while (res.Count < k)
            {
                if (i < 0)
                {
                    while (j < n && res.Count < k)
                    {
                        res.AddLast(arr[j++]);
                    }
                }
                else if (j >= n)
                {
                    while (i >= 0 && res.Count < k)
                    {
                        res.AddFirst(arr[i--]);
                    }
                }
                else if (Math.Abs(arr[j] - x) < Math.Abs(arr[i] - x))
                {
                    res.AddLast(arr[j++]);
                }
                else
                {
                    res.AddFirst(arr[i--]);
                }
            }
            return res.ToList();
        }
    }
}
