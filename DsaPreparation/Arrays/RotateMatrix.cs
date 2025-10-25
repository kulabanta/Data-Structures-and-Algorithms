namespace DsaPreparation.Arrays
{
    public class RotateMatrix
    {
        public void Rotate(int[][] mt)
        {
            int n = mt.Length;
            int h = n - 1;
            for (int l = 0; l < n / 2; l++)
            {
                for (int i = l; i < h - l; i++)
                {
                    int x = mt[l][i];
                    mt[l][i] = mt[h - i][l];

                    mt[h - i][l] = mt[h - l][h - i];
                    mt[h - l][h - i] = mt[i][h - l];
                    mt[i][h - l] = x;
                }
            }
        }
    }
}