namespace TwoPointers.Others
{
    internal class MinLengthOfStringsAfterDeletingSimilarEnds
    {
        public int MinimumLength(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            int k;
            while (i < j)
            {
                if (s[i] == s[j])
                {
                    k = i;
                    while (i <= j && s[i] == s[k])
                        i++;
                    while (j >= i && s[j] == s[k])
                        j--;
                }
                else
                    break;
            }
            return j - i + 1;
        }
    }
}
