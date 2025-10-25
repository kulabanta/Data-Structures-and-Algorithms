public class Node{
    public int key,value,freq;
    public Node next,prev;
    public Node(int key, int value){
        this.key = key;
        this.value = value;
        this.freq = 1;
        next = null;
        prev = null;
    }
}
public class FreqNode{
    public Node head,tail;
    public FreqNode(){
        head = null;
        tail = null;
    }
    public Node RemoveFirst()
    {
        if(head == null || head.next == null)
        {
            head = null;
            tail = null;
            return head;
        }
        Node p = head;
        head = head.next;
        p.next = null;
        head.prev = null;
        return p;
    }
    public void Remove(Node node)
    {
        if(node == head && node == tail)
        {
            head = null;
            tail = null;
            return;
        }
        if(head == node)
        {
            head = head.next;
            node.next = null;
            head.prev = null;
            return;
        }
        if(node == tail)
        {
            tail = tail.prev;
            tail.next = null;
            node.prev = null;
            return;
        }
        node.prev.next = node.next;
        node.next.prev =node.prev;
        node.next = null;
        node.prev = null;
    }
    public void AddToLast(Node node)
    {
        if(head == null)
        {
            head = node;
            tail = node;
        }
        tail.next = node;
        node.prev = tail;
        tail = node;
    }
}
public class LFUCache {
    Dictionary<int,Node> dt ;
    SortedDictionary<int,FreqNode> fdt;
    int capacity;
    public LFUCache(int capacity) {
        this.capacity = capacity;
        dt = new();
        fdt = new();
    }
    
    public int Get(int key) {
        if(dt.ContainsKey(key))
        {
            dt[key].freq++;
            UpdateFreqDict(dt[key]);
            return dt[key].value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(dt.ContainsKey(key))
        {
            dt[key].value = value;
            dt[key].freq++;
            UpdateFreqDict(dt[key]);
            return;
        }
        if(dt.Count == capacity)
        {
            Node x  = fdt.First().Value.RemoveFirst();
            if(x!=null)
                dt.Remove(x.key);
        }
        Node temp = new Node(key,value);
        if(!fdt.ContainsKey(temp.freq))
        {
            fdt.Add(temp.freq,new FreqNode());
        }
        fdt[temp.freq].AddToLast(temp);
        dt.Add(key,temp);
    }
    private void UpdateFreqDict(Node node)
    {
        int freq = node.freq;
        if(fdt.ContainsKey(freq-1))
        {
            fdt[freq-1].Remove(node);
            if(fdt[freq-1].head == null)
                fdt.Remove(freq-1);
        }
        if(!fdt.ContainsKey(freq))
        {
            fdt.Add(freq,new FreqNode());
        }   
        fdt[freq].AddToLast(node);
    }
}
