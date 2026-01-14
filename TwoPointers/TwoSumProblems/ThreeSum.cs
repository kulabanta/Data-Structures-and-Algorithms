namespace TwoPointers.TwoSumProblems
{
    internal class ThreeSum
    {
        public IList<IList<int>> threeSum(int[] nums)
        {
            HashSet<string> hs = new HashSet<string>();
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                int j = i + 1;
                int k = n - 1;

                while (j < k)
                {
                    int p = nums[i] + nums[j] + nums[k];

                    if (p == 0)
                    {
                        string hashKey = nums[i].ToString() + '-' + nums[j].ToString() + '-' + nums[k].ToString();
                        if (!hs.Contains(hashKey))
                        {
                            res.Add(new List<int>() { nums[i], nums[j], nums[k] });
                            hs.Add(hashKey);
                        }
                        j++;
                        k--;
                    }
                    else if (p > 0)
                    {
                        k--;
                    }
                    else
                        j++;
                }
                i++;
            }
            return res;
        }
    }
}
