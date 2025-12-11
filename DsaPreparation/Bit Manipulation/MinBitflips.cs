namespace DsaPreparation.Bit_Manipulation
{
    internal class MinBitflips
    {
        public int MinBitFlips(int start, int goal)
        {
            return CountSetBits(start ^ goal);
        }
        private int CountSetBits(int n)
        {
            int res = 0;
            while (n > 0)
            {
                res += n & 1;
                n = n >> 1;
            }
            return res;
        }
    }
}
