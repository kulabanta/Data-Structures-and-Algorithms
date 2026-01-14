namespace DsaPreparation.Bit_Manipulation
{
    internal class XORFrom1ToN
    {
        private int FindXORFrom1(int n)
        {
            if (n % 4 == 1)
                return 1;
            else if (n % 4 == 2)
                return n + 1;
            else if (n % 4 == 3)
                return 0;
            else
                return n;
        }
        public int findXOR(int l, int r)
        {
            int x = FindXORFrom1(l - 1);
            int y = FindXORFrom1(r);
            return x ^ y;

        }
    }
}
