using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Reverse_Swapping
{
    internal class SortColors
    {
        public void sortColors(int[] nums)
        {
            int n = nums.Length;
            int i = 0, j = n - 1, k = 0;
            while (k <= j)
            {
                if (nums[k] == 1)
                {
                    k++;
                }
                else if (nums[k] == 0)
                {
                    int p = nums[i];
                    nums[i] = nums[k];
                    nums[k] = p;
                    if (i == k)
                        k++;
                    i++;
                }
                else
                {
                    int q = nums[j];
                    nums[j] = nums[k];
                    nums[k] = q;
                    j--;
                }
            }
        }
    }
}
