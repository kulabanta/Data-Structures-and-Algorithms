using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaPreparation.priority_queue
{
    public class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if(x < y) return 1;
            if(x > y) return -1;
            return 0;
        }
    }
    public class PqImplementation
    {
        PriorityQueue<string, int> pq = new(new Comparer());

        public void AddToQueue(string element,int priority)
        {
            pq.Enqueue(element,priority);
        }
        public void RemoveElement()
        {
            if(pq.Count == 0) return;
            pq.TryDequeue(out string element,out int priority);
            Console.WriteLine($"removed element {element},{priority}");
        }
        public void PrintAllElements()
        {
           while(pq.Count > 0)
            {
                RemoveElement();
            }
        }
    }
}
