
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int x) 
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    static public bool HasCycle(ListNode head)
    {
        List<ListNode> nodes = new List<ListNode>();
        while (head != null)
        {
            if (nodes.Contains(head))
            {
                return true;
            }
            nodes.Add(head);
            head = head.next;
        }
        return false;
    }
}