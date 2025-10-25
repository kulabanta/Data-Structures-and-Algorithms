public class SortColors {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] left = new int[n];
        int[] right = new int[n];

        left[0]=0;
        for(int i=1;i<n;i++)
        {
            if(ratings[i]>ratings[i-1])
                left[i]=1+left[i-1];
            else
                left[i]=0;
        }
        right[n-1]=0;
        for(int i=n-2;i>=0;i--)
        {
            if(ratings[i]>ratings[i+1])
                right[i]=1+right[i+1];
            else
                right[i]=0;
        }
        int res = 0;
        for(int i=0;i<n;i++)
        {
            res+=Math.Max(left[i],right[i])+1;
        }
        return res;
    }
}