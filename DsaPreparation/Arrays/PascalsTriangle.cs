namespace DsaPreparation.Arrays
{
    public class PascalTriangles
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> res = new();
            res.Add(new List<int>() { 1 });
            for (int i = 1; i < numRows; i++)
            {
                List<int> temp = new();
                temp.Add(1);
                for (int j = 0; j < res[i - 1].Count - 1; j++)
                {
                    temp.Add(res[i - 1][j] + res[i - 1][j + 1]);
                }
                temp.Add(1);
                res.Add(temp);
            }
            return res;
        }
    }
}