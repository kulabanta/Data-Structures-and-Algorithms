namespace TwoPointers.TwoSumProblems
{
    internal class SumOfSquareNumbers
    {
        public bool JudgeSquareSum(int c)
        {
            int i = 0;
            int j = (int)Math.Ceiling(Math.Sqrt(c));
            while (i <= j)
            {
                long s = (long)i * i + (long)j * j;
                if (s == (long)c)
                    return true;
                else if (s > c)
                    j--;
                else
                    i++;
            }
            return false;
        }
    }
}
