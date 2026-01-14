namespace TwoPointers.TwoSumProblems
{
    internal class BoatsToSavePeople
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            int n = people.Length;
            Array.Sort(people);
            int res = 0;
            int i = 0;
            int j = n - 1;

            while (i <= j)
            {
                if (i == j)
                {
                    res++;
                    break;
                }
                int s = people[i] + people[j];
                if (s <= limit)
                {
                    res++;
                    i++;
                    j--;
                }
                else
                {
                    res++;
                    j--;
                }
            }
            return res;
        }
    }
}
