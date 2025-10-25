/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class SortColors {
    public Node CopyRandomList(Node head) {
        if(head==null)
            return null;
        Node res = null ,resTemp = null;
        Node temp = head;
        Dictionary<Node,Node> dt = new();

        while(temp!=null)
        {
            if(resTemp == null)
            {
                resTemp = new Node(temp.val);
                res = resTemp;
                dt.Add(temp,res);
            }
            if(temp.next!=null && dt.ContainsKey(temp.next))
                resTemp.next =dt[temp.next];
            else{
                if(temp.next!=null)
                {
                    resTemp.next = new Node(temp.next.val);
                    dt.Add(temp.next,resTemp.next);
                }
            }
            if(temp.random!=null && dt.ContainsKey(temp.random))
                resTemp.random = dt[temp.random];
            else{
                if(temp.random!=null)
                {
                    resTemp.random = new Node(temp.random.val);
                    dt.Add(temp.random,resTemp.random);
                }
            }
            temp = temp.next;
            resTemp = resTemp.next;
        }
        return res;
    }
}