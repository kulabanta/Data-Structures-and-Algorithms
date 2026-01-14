namespace TwoPointers.Others
{
    public class BagOfTokens
    {
        public int BagOfTokensScore(int[] token, int power)
        {
            int res = 0;
            Array.Sort(token);
            int i = 0;
            int j = token.Length - 1;
            while (i < j)
            {
                if (power >= token[i])
                {
                    res++;
                    power -= token[i];
                    i++;
                }
                else if (res >= 1)
                {
                    power += token[j];
                    res--;
                    j--;
                }
                else
                {
                    break;
                }
            }
            if (i == j && power >= token[i])
                res++;
            return res;
        }
    }
}
