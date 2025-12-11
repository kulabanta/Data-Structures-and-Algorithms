namespace DsaPreparation.Bit_Manipulation
{
    internal class Subsets
    {
        public IList<IList<int>> GetSubsets(int[] nums)
        {
            var res = new List<IList<int>>();
            int n = nums.Length;
            int p = Power(2, n);
            for (int i = 0; i < p; i++)
            {
                List<int> temp = new();
                for (int j = 0; j < n; j++)
                {
                    if ((i & 1 << j) > 0)
                    {
                        temp.Add(nums[j]);
                    }
                }
                res.Add(temp);
            }
            return res;
        }
        private int Power(int a, int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 0)
                return Power(a * a, n / 2);
            return a * Power(a, n - 1);
        }

    }
}
