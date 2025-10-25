public class SortColors {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] left = new int[n];
        int[] right = new int[n];

        int mxl = 0;
        for(int i=0;i<n;i++)
        {
            mxl = Math.Max(mxl,height[i]);
            left[i]=mxl;
        }
        int mxr = 0;
        for(int i=n-1;i>=0;i--)
        {
            mxr = Math.Max(mxr,height[i]);
            right[i]=mxr;
        }       
        int res = 0;
        for(int i=0;i<n;i++)
        {
            res+=Math.Min(left[i],right[i])-height[i];
        }
        return res;
    }
}