namespace DsaPreparation.Arrays
{
    public class SearchA2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int i = 0;
            int j = m - 1;

            while (i < j)
            {
                int mid = i + (j - i) / 2;
                if (matrix[mid][n - 1] < target)
                    i = mid + 1;
                else
                    j = mid;
            }
            if (target > matrix[i][n - 1])
                i++;
            if (i >= m)
                return false;
            int l = 0;
            int r = n - 1;

            while (l <= r)
            {
                int md = l + (r - l) / 2;
                if (matrix[i][md] == target)
                    return true;
                else if (matrix[i][md] < target)
                    l = md + 1;
                else
                    r = md - 1;
            }
            return false;
        }
    }
}