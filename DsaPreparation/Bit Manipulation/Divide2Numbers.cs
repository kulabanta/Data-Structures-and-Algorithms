namespace DsaPreparation.Bit_Manipulation
{
    internal class Divide2Numbers
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == divisor)
                return 1;

            bool sign = true;
            if ((dividend >= 0 && divisor < 0) || (dividend < 0 && divisor >= 0))
                sign = false;
            long n = (long)Math.Abs((long)dividend);
            long d = (long)Math.Abs((long)divisor);
            long count = 0;

            while (n >= d)
            {
                int curr = 0;
                while (n >= (d << (curr + 1)))
                    curr++;
                count += (long)1 << curr;
                n -= d << curr;
            }
            if (count >= (long)Int32.MaxValue + 1)
            {
                return sign ? Int32.MaxValue : Int32.MinValue;
            }
            if (!sign)
                return -1 * (int)count;
            return (int)count;

        }
    }
}
