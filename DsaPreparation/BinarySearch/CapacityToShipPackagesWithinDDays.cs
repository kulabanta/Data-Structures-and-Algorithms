namespace DsaPreparation.BinarySearch
{
    public class CapacityToShipPackagesWithinDDays
    {
        public int DaysRequiredToShip(int[] weights, int capacity)
        {
            int n = weights.Length;
            if (n == 0)
                return 0;
            int res = 1;
            int temp = 0;
            foreach (int p in weights)
            {
                if (p > capacity)
                    return int.MaxValue;

                if (temp + p > capacity)
                {
                    temp = p;
                    res++;
                }
                else
                {
                    temp += p;
                }
            }
            return res;
        }
        public int ShipWithinDays(int[] weights, int days)
        {
            int n = weights.Length;
            int l = 0;
            int r = 0;

            foreach (int p in weights)
                r += p;

            while (l < r)
            {
                int m = l + (r - l) / 2;

                int daysRequired = DaysRequiredToShip(weights, m);

                if (daysRequired > days)
                    l = m + 1;
                else
                    r = m;
            }
            return l;

        }
    }
}