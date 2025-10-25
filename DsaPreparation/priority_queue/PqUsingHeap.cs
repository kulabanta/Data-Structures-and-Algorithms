using System;
namespace priority_queue
{
    public class PQUsingHeap
    {
        public List<int> heap;
        public PQUsingHeap()
        {
            heap = new();
        }
        public void Insert(int value)
        {
            heap.Add(value);
            int current = heap.Count - 1;
            int parent = Parent(current);

            while (parent >= 0 && heap[parent] < heap[current])
            {
                int p = heap[current];
                heap[current] = heap[parent];
                heap[parent] = p;
                current = parent;
                parent = Parent(current);
            }
        }
        public void Remove()
        {
            if (heap.Count == 0)
                return;
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            Heapify(0);
        }
        private int Parent(int index)
        {
            return (index - 1) / 2;
        }
        private void Heapify(int index)
        {
            if (index > heap.Count)
                return;
            int left = 2 * index + 1;
            int right = left + 1;
            int largest = index;

            if (left < heap.Count && heap[left] > heap[largest])
            {
                largest = left;
            }

            if (right < heap.Count && heap[right] > heap[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                int p = heap[largest];
                heap[largest] = heap[index];
                heap[index] = p;
                Heapify(largest);
            }
        }
        public int Peek()
        {
            if (heap.Count < 1)
                return -1;
            return heap[0];
        }


    }
    public class PQImplementation()
    {
        public static void MainFunc()
        {
            PQUsingHeap pq = new();

            pq.Insert(10);
            pq.Insert(34);
            pq.Insert(13);
            pq.Insert(54);
            pq.Insert(17);
            pq.Insert(74);
            pq.Insert(13);
            pq.Insert(11);

            while (pq.Peek() != -1)
            {
                Console.WriteLine($"Peek Element : {pq.Peek()}");
                pq.Remove();

            }
        }
    }
}
