public class SortColors {
    public IList<int> NumOfBurgers(int ts, int cs) {
        if((ts%2)!=0 || ts<cs)
            return [];
        
        int jb = (ts-2*cs)/2;
        int sb = cs-jb;

        if(jb<0 || sb<0 )
            return [];
        return [jb,sb];
    }
}