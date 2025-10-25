public class SortColors {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        int i = 0;
        int d = 0;
        int e = 0;
        int res = 0;
        while(i<n)
        {
            e+=(gas[i]-cost[i]);
            if(e<0)
            {
                d+=e;
                res = i+1;
                e=0;
            }
            i++;
        }
        if(e+d>=0)
            return res;
        return -1;

    }
}