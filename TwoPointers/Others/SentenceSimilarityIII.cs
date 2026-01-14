namespace TwoPointers.Others
{
    internal class SentenceSimilarityIII
    {
        public bool AreSentencesSimilar(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }
            if (s1.Length < s2.Length)
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
            }
            int i1 = 0, j1 = s1.Length - 1;
            int i2 = 0, j2 = s2.Length - 1;
            string prefix = "", suffix = "";
            while (i1 <= j1 && i2 <= j2)
            {
                string ts1 = "", ts2 = "";
                int p1 = i1, p2 = i2;
                while (i1 <= j1 && s1[i1] != ' ')
                {
                    ts1 += s1[i1++];
                }
                while (i2 <= j2 && s2[i2] != ' ')
                {
                    ts2 += s2[i2++];
                }
                if (ts1 == ts2)
                    prefix += ts1 + ' ';
                else
                {
                    i1 = p1;
                    i2 = p2;
                    break;
                }
                i1++;
                i2++;
            }
            while (j1 >= i1 && j2 >= i2)
            {
                string ts11 = "", ts22 = "";
                while (j1 >= i1 && s1[j1] != ' ')
                {
                    ts11 = s1[j1--] + ts11;
                }
                while (j2 >= i2 && s2[j2] != ' ')
                {
                    ts22 = s2[j2--] + ts22;
                }
                if (ts11 == ts22)
                    suffix = ts11 + ' ' + suffix;
                else
                    break;
                j1--;
                j2--;
            }
            if (prefix.Length > 0)
            {
                prefix = prefix.Remove(prefix.Length - 1);
            }
            if (suffix.Length > 0)
            {
                suffix = suffix.Remove(suffix.Length - 1);
            }
            string res = prefix + " " + suffix;
            return (prefix == s2) || (suffix == s2) || (res == s2);
        }
    }
}
