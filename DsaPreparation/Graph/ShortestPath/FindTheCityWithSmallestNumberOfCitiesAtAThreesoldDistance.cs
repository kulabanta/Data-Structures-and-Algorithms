public class SortColors {
    public int FindTheCity(int n, int[][] edges, int dt) {
        int[][] dist = new int[n][];
        for(int i=0;i<n;i++)
        {
            dist[i]=new int[n];
            Array.Fill(dist[i],Int32.MaxValue);
            dist[i][i]=0;
        }
        foreach(int[] e in edges)
        {
            dist[e[0]][e[1]]=e[2];
            dist[e[1]][e[0]]=e[2];
        }
        for(int k=0;k<n;k++)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(dist[i][k]< Int32.MaxValue && dist[k][j]<Int32.MaxValue && 
                    dist[i][k]+dist[k][j]<dist[i][j])
                    {
                        dist[i][j]=dist[i][k]+dist[k][j];
                    }
                }
            }
        }
        int res = -1;
        int resCount = Int32.MaxValue;
        for(int i=0;i<n;i++)
        {
            int temp = 0;
            for(int j=0;j<n;j++)
            {
                if(i!=j && dist[i][j]<=dt)
                    temp++; 
            }
            if(temp<=resCount)
            {
                resCount = temp;
                res = i;
            }
        }
        return res;
    }
}