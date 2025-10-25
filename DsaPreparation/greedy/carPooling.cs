
public class CarPooling {
    
    public bool CarPoolingImpl(int[][] trips, int capacity) {
        int n = trips.Length;
        Array.Sort(trips,(a,b)=>{
             if(a[1]==b[1])
                return a[2]-b[2];
            return a[1]-b[1];
        });
        PriorityQueue<int,int> q = new();

        for(int i=0;i<n;i++)
        {
            while(q.Count>0)
            {
                q.TryDequeue(out int p1, out int p2);
                if(p2<=trips[i][1])
                {
                    capacity+=p1;
                }
                else
                {
                    q.Enqueue(p1,p2);
                    break;
                }
                    

            }
            capacity-=trips[i][0];
            if(capacity<0)
                return false;
            q.Enqueue(trips[i][0],trips[i][2]);
        }
        return true;
    }
}

//class Solution {
//public:
//	bool carPooling(vector<vector<int>>& trips, int capacity) {

//		int trip_len = 1001;
//		vector<int>stops(trip_len, 0);

//		for (int i = 0; i < trips.size(); i++) {
//			stops[trips[i][1]] += trips[i][0];
//			stops[trips[i][2]] -= trips[i][0];
//		}

//		for (int i = 0; i < trip_len; i++) {
//			if (i != 0) stops[i] += stops[i-1];
//			if (stops[i] > capacity)
//				return false;
//		}


//		return true;
//	}
//};