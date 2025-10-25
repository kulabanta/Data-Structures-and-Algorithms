
namespace DsaPreparation.Heap
{
    public class MinHeapImplementation
    {
        private int capacity,size;
        private int[] heap;
        public MinHeapImplementation(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            heap = new int[capacity];
        }
        public void AddElement(int val)
        {
            if(size == capacity)
            {
                Console.WriteLine("heap is already full. cannot add the new element");
                return;
            }
            heap[size++] = val;
            Heapify(size - 1);
        }
        public void Remove()
        {
            if(size == 0)
            {
                Console.WriteLine("No element to remove ");
            }
            int res = heap[0];
            heap[0] = heap[size - 1];
            size--;
            HeapifyFromTop(0);


        }
        public int Peek()
        {
            if(size == 0 )
                return 0;
            return heap[0];
        }
        private void HeapifyFromTop(int curr)
        {
            if(curr >= size)
            {
                return;
            }
            int temp = curr;
            if(2*curr+1 < size && heap[2 * curr + 1] < heap[temp])
            {
                temp = 2 * curr + 1;
            }
            if (2 * curr + 2 < size && heap[2 * curr + 2] < heap[temp])
            {
                temp= 2 * curr + 2;
            }
            if(temp!=curr)
            {
                int p = heap[curr];
                heap[curr] = heap[temp];
                heap[curr] = p;
                HeapifyFromTop(temp);
            }
        }
        private void Heapify(int curr)
        {
            if(curr == 0)
            {
                return;
            }
            int parent = (curr - 1) / 2;
            if (heap[parent] > heap[curr])
            {
                int temp = heap[parent];
                heap[parent] = heap[curr];
                heap[temp] = temp;
                Heapify(parent);
            }
        }
    }
}
