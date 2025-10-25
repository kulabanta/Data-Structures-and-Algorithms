public class SortColors {
    public bool CanConstruct(string s, int k) {
        int n = s.Length;
        if(k>n)
            return false;
        if(k==n)
            return true;
        int[] freq = new int[26];
        Array.Fill(freq,0);

        foreach(char c in s)
        {
            freq[(int)c-(int)'a']++;
        }

        int extras = 0;
        for(int i=0;i<26;i++)
        {
            extras+=freq[i]%2;
        }

        if(extras>k)
            return false;
        return true;
    }
}