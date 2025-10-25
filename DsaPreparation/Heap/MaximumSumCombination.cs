namespace DsaPreparation.Heap
{
    public class Node
    {
        public int value, x, y;
        public Node(int value, int x, int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }
    }
    public class MaxHeap
    {
        public int capacity, size;
        private Node[] heap;
        public MaxHeap(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            heap = new Node[capacity];
        }
        public void AddElement(Node node)
        {
            if (size == capacity)
            {
                if (heap[0].value < node.value)
                    Remove();
                else
                    return;
            }
            heap[size++] = node;
            Heapify(size - 1);
        }
        public Node Remove()
        {
            if (size == 0)
            {
                return null;
            }
            Node res = heap[0];
            heap[0] = heap[size - 1];
            size--;
            HeapifyFromTop(0);
            return res;
        }
        public Node Peek()
        {
            if (size == 0)
                return null;
            return heap[0];
        }
        private void HeapifyFromTop(int curr)
        {
            if (curr >= size)
            {
                return;
            }
            int temp = curr;
            if (2 * curr + 1 < size && heap[2 * curr + 1].value > heap[temp].value)
            {
                temp = 2 * curr + 1;
            }
            if (2 * curr + 2 < size && heap[2 * curr + 2].value > heap[temp].value)
            {
                temp = 2 * curr + 2;
            }
            if (temp != curr)
            {
                Node p = heap[curr];
                heap[curr] = heap[temp];
                heap[temp] = p;
                HeapifyFromTop(temp);
            }
        }
        private void Heapify(int curr)
        {
            if (curr == 0)
            {
                return;
            }
            int parent = (curr - 1) / 2;
            if (heap[parent].value < heap[curr].value)
            {
                Node temp = heap[parent];
                heap[parent] = heap[curr];
                heap[curr] = temp;
                Heapify(parent);
            }
        }
    }
    public class MaximumSumCombination
    {
        public List<int> topKSumPairs(int[] a, int[] b, int k)
        {
            int n = a.Length;
            if (n == 1)
                return new List<int>() { a[0] + b[0] };
            Array.Sort(a);
            Array.Sort(b);
            HashSet<string> st = new HashSet<string>();
            List<int> res = new List<int>();
            MaxHeap pq = new MaxHeap(n);
            pq.AddElement(new Node(a[n - 1] + b[n - 1], n - 1, n - 1));
            while (k > 0 && pq.size > 0)
            {
                Node node = pq.Remove();
                if (node == null)
                    break;
                res.Add(node.value);
                int x = node.x;
                int y = node.y;
                if (x > 0)
                {
                    string key1 = (x - 1).ToString() + "_" + y.ToString();
                    if (!st.Contains(key1))
                    {
                        pq.AddElement(new Node(a[x - 1] + b[y], x - 1, y));
                        st.Add(key1);
                    }
                }

                if (y > 0)
                {
                    string key2 = (x).ToString() + "_" + (y - 1).ToString();
                    if (!st.Contains(key2))
                    {
                        pq.AddElement(new Node(a[x] + b[y - 1], x, y - 1));
                        st.Add(key2);
                    }
                }

                k--;
            }
            return res;

        }
    }
}
