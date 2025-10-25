namespace DsaPreparation.DynamicProgramming.MInimumMaximumPathToReachTarget
{
    public class MinimumFallingPathSum
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int ld = j <= 0 ? int.MaxValue : matrix[i - 1][j - 1];
                    int lt = matrix[i - 1][j];
                    int rd = j >= n - 1 ? int.MaxValue : matrix[i - 1][j + 1];

                    matrix[i][j] += Math.Min(lt, Math.Min(ld, rd));
                }
            }

            int res = int.MaxValue;
            for (int i = 0; i < n; i++)
                res = Math.Min(res, matrix[n - 1][i]);
            return res;
        }
    }
}