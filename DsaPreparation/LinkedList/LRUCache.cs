public class Node{
    public int key;
    public int value;
    public Node next,prev;
    public Node(int key,int value)
    {
        this.key = key;
        this.value = value;
        next = null;
        prev = null;
    }
}
public class LRUCache {
    int capacity;
    Dictionary<int,Node> dt;
    Node head = null,tail = null;
    public LRUCache(int capacity) {
        dt = new();
        head = null;
        tail = null;
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(dt.ContainsKey(key))
        {
            AddToLast(dt[key]);
            return dt[key].value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(dt.ContainsKey(key))
        {
            dt[key].value = value;
            AddToLast(dt[key]);
            return;
        }
        if(dt.Count==capacity)
        {
            EvictLRU();
        }
        Node node = new Node(key,value);
        dt.Add(key,node);
        AddToLast(node);
    }
    private void EvictLRU(){
        dt.Remove(head.key);
        if(head.next == null)
        {
            head = null;
        }else{
            Node p = head;
            head = head.next;
            p.next = null;
            head.prev = null;
        }
    }
    private void AddToLast(Node node)
    {
        if(head == null)
        {
            head = node;
            tail = node;
            return;
        }
        if(node == tail)
            return;
        if(node.next == null)
        {
            tail.next = node;
            node.prev = tail;
            tail = node;
            return;
        }
        if(head == node)
        {
            Node p = head;
            head = head.next;
            head.prev = null;
            p.next = null;
        }
        else{
            node.prev.next =node.next;
            node.next.prev = node.prev;
        }
        tail.next = node;
        node.prev = tail;
        node.next = null;
        tail = node;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */