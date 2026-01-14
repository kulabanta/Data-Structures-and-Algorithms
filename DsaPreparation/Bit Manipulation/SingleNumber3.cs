namespace DsaPreparation.Bit_Manipulation
{
    internal class SingleNumber3
    {
        public int[] SingleNumber(int[] nums)
        {
            int n = nums.Length;
            long xor = 0;
            foreach (int num in nums)
            {
                xor ^= (long)num;
            }
            // consider the first bit from right which is set in the xor number(let say xth bit from right)
            // same numbers will be cancelled 
            // one number in result will have xth bit set and another will not have it set
            // find out a number where only xth bit is set

            long x = (xor & (xor - 1)) ^ xor;
            Console.WriteLine(x);

            //divide the numbers into two buckets
            // one where xth bit is set and another where xth bit is not set .
            // the two result numbers will always appear in differnt buckets

            int xSet = 0, xUnset = 0;

            foreach (int num in nums)
            {
                if ((num & x) > 0)
                {
                    xSet ^= num;
                }
                else
                {
                    xUnset ^= num;
                }
            }
            return new int[] { xSet, xUnset };
        }
    }
}
