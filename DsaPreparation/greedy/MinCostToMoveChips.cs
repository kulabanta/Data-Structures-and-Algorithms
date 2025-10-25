public class SortColors {
    public int MinCostToMoveChips(int[] position) {
        int n = position.Length;
        int even = 0;
        int odd = 0;

        foreach(int p in position)
        {
            if((p%2)==0)
                even++;
            else
                odd++;
        }
        return Math.Min(even,odd);
    }
}