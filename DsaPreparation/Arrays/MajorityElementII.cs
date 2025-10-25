namespace DsaPreparation.Arrays
{
    public class LongestSnx
    {
        private int MajorityElementHalf(int[] nums, int i, int j)
        {
            Console.WriteLine($"i = {i}, j={j}");
            if (i == j)
                return nums[i];
            if (i > j)
                return int.MaxValue;
            int n = j - i + 1;
            int cnt = 1;
            int p = nums[i];

            for (int k = i + 1; k <= j; k++)
            {
                if (nums[k] == p)
                    cnt++;
                else
                    cnt--;
                if (cnt == 0)
                {
                    cnt = 1;
                    p = nums[k];
                }
            }
            cnt = 0;
            for (int l = i; l <= j; l++)
            {
                if (nums[l] == p)
                    cnt++;
            }
            if (cnt >= n / 2)
                return p;
            return int.MaxValue;
        }
        public IList<int> MajorityElement(int[] nums)
        {
            int n = nums.Length;
            List<int> res = new();
            int ele1 = int.MaxValue, ele2 = int.MaxValue;
            int cnt1 = 0, cnt2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (cnt1 == 0 && nums[i] != ele2)
                {
                    cnt1 = 1;
                    ele1 = nums[i];
                }
                else if (cnt2 == 0 && nums[i] != ele1)
                {
                    cnt2 = 1;
                    ele2 = nums[i];
                }
                else if (ele1 == nums[i])
                    cnt1++;
                else if (ele2 == nums[i])
                    cnt2++;
                else
                {
                    cnt1--;
                    cnt2--;
                }
            }
            cnt1 = 0;
            cnt2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == ele1)
                    cnt1++;
                else if (nums[i] == ele2)
                    cnt2++;
            }
            Console.WriteLine($"1 - {cnt1} - {ele1}");
            Console.WriteLine($"2 - {cnt2} - {ele2}");

            if (cnt1 > n / 3)
                res.Add(ele1);
            if (cnt2 > n / 3)
                res.Add(ele2);
            return res;
        }
    }
}