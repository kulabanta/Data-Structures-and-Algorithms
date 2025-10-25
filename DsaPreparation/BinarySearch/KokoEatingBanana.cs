namespace DsaPreparation.BinarySearch
{
    public class KokoEatingBanana
    {
        public int TimeTakenToComplete(int[] piles, int k)
        {
            int res = 0;

            foreach (int p in piles)
            {
                res += p / k;

                if (p % k > 0)
                    res++;
            }
            return res;
        }
        public int MinEatingSpeed(int[] piles, int h)
        {
            int n = piles.Length;
            int l = 1;
            int r = 1;
            foreach (int p in piles)
            {
                r = Math.Max(r, p);
            }

            while (l < r)
            {
                int m = l + (r - l) / 2;

                if (TimeTakenToComplete(piles, m) <= h)
                    r = m;
                else
                    l = m + 1;
            }
            return l;
        }
    }
}