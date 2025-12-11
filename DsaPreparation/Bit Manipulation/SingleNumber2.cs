namespace DsaPreparation.Bit_Manipulation
{
    internal class SingleNumber2
    {
        public int SingleNumber(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < 31; i++)
            {
                int cnt = 0;
                foreach (var num in nums)
                {
                    if ((num & (1 << i)) > 0)
                        cnt++;
                }
                if ((cnt % 3) > 0)
                {
                    res = res | (1 << i);
                }
            }
            int last = 0;
            foreach (var num in nums)
            {
                if (num < 0)
                    last++;
            }
            if ((last % 3) > 0)
            {
                res = res | (1 << 31);
            }
            return res;
        }

        public int SingleNumberUsingBucket(int[] nums)
        {
            int ones = 0;
            int twos = 0;
            foreach (int num in nums)
            {
                ones = (ones ^ num) & (~twos);
                twos = (twos ^ num) & (~ones);
            }
            return ones;
        }
    }
}
