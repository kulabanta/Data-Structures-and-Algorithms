
namespace DsaPreparation.Bit_Manipulation
{
    internal class XORInAnArray
    {
        private int XOR(int n)
        {
            if ((n % 8 == 0) || (n % 8 == 1))
                return n;
            else if ((n % 8 == 2) || (n % 8 == 3))
                return 2;
            else if ((n % 8 == 4) || (n % 8 == 5))
                return n + 2;
            else
                return 0;
        }
        public int XorOperation(int n, int start)
        {
            int x = start + 2 * (n - 1);
            return XOR(start - 2) ^ XOR(x);
        }
    }
}
