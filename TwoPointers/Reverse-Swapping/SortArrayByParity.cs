using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.Reverse_Swapping
{
    internal class SortArrayByParity
    {
        public int[] sortArrayByParity(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;

            while (i < j)
            {
                if (nums[i] % 2 != 0)
                {
                    int p = nums[i];
                    nums[i] = nums[j];
                    nums[j] = p;
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return nums;
        }
    }
}
