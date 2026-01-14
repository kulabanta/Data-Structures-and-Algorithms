namespace TwoPointers.Trapping_rain_water
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int n = height.Length;
            int i = 0;
            int j = n - 1;
            int res = 0;
            while (i < j)
            {
                res = Math.Max(res, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] <= height[j])
                    i++;
                else
                    j--;
            }
            return res;
        }
    }
}
