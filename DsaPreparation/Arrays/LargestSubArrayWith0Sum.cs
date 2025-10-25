namespace DsaPreparation.Arrays
{
    class LargestSubarrayWith0Sum
    {
        public int maxLength(int[] arr)
        {
            Dictionary<int, int> dt = new Dictionary<int, int>();
            int n = arr.Length;
            int temp = 0;
            int res = 0;

            for (int i = 0; i < n; i++)
            {
                temp += arr[i];
                if (temp == 0)
                    res = Math.Max(res, i + 1);
                else if (dt.ContainsKey(temp))
                    res = Math.Max(res, i - dt[temp]);
                else
                    dt.Add(temp, i);
            }
            return res;

        }
    }
}