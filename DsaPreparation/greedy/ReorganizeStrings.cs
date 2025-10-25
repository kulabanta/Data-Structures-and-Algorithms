public class SortColors {
    public string ReorganizeString(string s) {
        int n = s.Length;
        int[] freq = new int[26];
        Array.Fill(freq,0);
        for(int i=0;i<n;i++ )
        {
            int x = (int)s[i]-(int)'a';
            freq[x]++;
        } 
        PriorityQueue<char,int> pq = new();

        for(int i=0;i<26;i++)
        {
            if(freq[i]>0)
            {
                pq.Enqueue((char)('a'+i),-freq[i]);
            }
        }
        string res = "";
        int count;
        char c ;
        pq.TryDequeue(out char ch1 , out int cnt1);

        c=ch1;
        count = cnt1+1;
        res+=c;

        while(pq.Count>0)
        {
            pq.TryDequeue(out char ch , out int cnt);
            if(count<0)
                pq.Enqueue(c,count);
            c=ch;
            count=cnt+1;
            res+=c;
            // Console.WriteLine(res);
        }
        if(res.Length==n)
            return res;
        return "";
    }
}