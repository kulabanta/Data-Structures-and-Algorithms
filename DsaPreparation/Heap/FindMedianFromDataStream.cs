namespace DsaPreparation.Heap
{
    public class MedianFinder
    {
        PriorityQueue<int, int> mxpq, mnpq;
        public MedianFinder()
        {
            mxpq = new();
            mnpq = new();
        }

        public void AddNum(int num)
        {
            if (mxpq.Count == 0)
            {
                mxpq.Enqueue(num, -num);
                return;
            }
            if (num <= mxpq.Peek())
            {
                mxpq.Enqueue(num, -num);
            }
            if (num > mxpq.Peek())
            {
                mnpq.Enqueue(num, num);
            }
            if ((mxpq.Count - mnpq.Count) > 1)
            {
                int val = mxpq.Dequeue();
                mnpq.Enqueue(val, val);
            }
            else if ((mnpq.Count - mxpq.Count) > 1)
            {
                int val1 = mnpq.Dequeue();
                mxpq.Enqueue(val1, -val1);
            }

        }

        public double FindMedian()
        {
            double res;
            if (mxpq.Count == mnpq.Count)
            {
                res = ((double)mxpq.Peek() + (double)mnpq.Peek()) / 2;
            }
            else if (mxpq.Count > mnpq.Count)
            {
                res = (double)mxpq.Peek();
            }
            else
            {
                res = (double)mnpq.Peek();
            }
            return res;
        }
    }
}
