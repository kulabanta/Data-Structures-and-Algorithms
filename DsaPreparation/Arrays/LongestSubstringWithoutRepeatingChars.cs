namespace DsaPreparation.Arrays
{
    public class LongestSubstringWithoutRepeatingchars
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> hs = new();
            int i = 0, j = 0;
            int res = 0;
            int n = s.Length;

            while (j < n)
            {
                if (hs.Contains(s[j]))
                {
                    res = Math.Max(res, j - i);
                    while (i < j && s[i] != s[j])
                    {
                        hs.Remove(s[i]);
                        i++;
                    }
                    i++;
                }
                else
                {
                    hs.Add(s[j]);
                }
                j++;
            }
            res = Math.Max(res, j - i);
            return res;
        }
    }
}