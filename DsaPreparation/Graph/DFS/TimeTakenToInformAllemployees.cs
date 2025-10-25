public class SortColors {
    private int[] resultTime;
    private int Dfs(int n, int curr , int headId , int[] manager , int[] informTime)
    {
        if(curr == headId)
            return 0;
        if(resultTime[curr]>0)
            return resultTime[curr];
        
        int p = manager[curr];
        resultTime[curr]= informTime[p]+Dfs(n,p,headId,manager,informTime);
        return resultTime[curr];
    }
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        resultTime = new int[n];
        Array.Fill(resultTime,0);
        int result = 0;
        for(int i=0;i<n;i++)
        {
            result = Math.Max(result,Dfs(n,i,headID,manager,informTime));
        }
        return result;
    }
}