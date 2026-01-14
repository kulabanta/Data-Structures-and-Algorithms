using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers.NextPermutation
{
    internal class NextPermutation
    {
        private void Reverse(int[] arr, int l, int r)
        {
            while (l < r)
            {
                int x = arr[l];
                arr[l] = arr[r];
                arr[r] = x;
                l++;
                r--;
            }
        }
        public void nextPermutation(int[] nums)
        {
            int n = nums.Length;
            int i = n - 1;
            while (i > 0 && nums[i] <= nums[i - 1])
                i--;
            if (i == 0)
            {
                Reverse(nums, 0, n - 1);
                return;
            }

            i--;
            int j = i + 1;
            int ng = j;
            while (j < n)
            {
                if (nums[j] > nums[i] && nums[j] <= nums[ng])
                    ng = j;
                j++;
            }
            int x = nums[i];
            nums[i] = nums[ng];
            nums[ng] = x;
            Reverse(nums, i + 1, n - 1);
        }
    }
}
