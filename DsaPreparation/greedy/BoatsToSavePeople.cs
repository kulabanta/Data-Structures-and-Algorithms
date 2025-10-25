public class SortColors {
    public int NumRescueBoats(int[] people, int limit) {
        int n = people.Length;
        Array.Sort(people);

        int i = 0;
        int j = n-1;

        int res = 0;

        while(i<=j)
        {
            if(i==j)
            {
                res++;
                break;
            }
            
            if(people[j]+people[i]<=limit)
            {
                res++;
                j--;
                i++;
            }
            else{
                res++;
                j--;
            }
        }
        return res;
    }
}