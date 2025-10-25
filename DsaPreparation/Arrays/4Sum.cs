namespace DsaPreparation.Arrays
{
    public class FourSum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            int n = nums.Length;
            List<IList<int>> res = new();
            HashSet<string> hs = new();
            Array.Sort(nums);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int l = j + 1;
                    int r = n - 1;

                    while (l < r)
                    {
                        long x = nums[i] + (long)nums[j] + nums[l] + nums[r];
                        if (x == target)
                        {

                            List<int> temp = new() { nums[i], nums[j], nums[l], nums[r] };
                            string ls = string.Join("-", temp);
                            if (!hs.Contains(ls))
                            {
                                res.Add(temp);
                                hs.Add(ls);
                            }
                            l++;
                            r--;
                        }
                        else if (x > target)
                            r--;
                        else
                            l++;

                    }
                }
            }
            return res;
        }
    }
}