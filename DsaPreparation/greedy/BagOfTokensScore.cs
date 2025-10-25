public class SortColors {
    public int BagOfTokensScore(int[] token, int power) {
        int n = token.Length;
        Array.Sort(token);

        int i = 0;
        int j = n-1;

        int res = 0;

        while(i<=j)
        {
            Console.WriteLine($"i : {i} , j : {j}, power : {power}");
            if(i==j)
            {
                if(power >= token[i])
                {
                    res++;
                }
                break;
            }

            if(power >= token[i])
            {
                power-=token[i];
                res++;
                i++;
            }
            else if(res >= 1) {
                power+=token[j];
                res--;
                j--;
            }
            else
                break;
        }
        return res;
    }
}