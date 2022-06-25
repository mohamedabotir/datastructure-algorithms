ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(3);
ListNode node4 = new ListNode(4);
ListNode node5 = new ListNode(5);
node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;
var node = ListNode.ReverseList(node1);
Console.WriteLine("==============");
Console.WriteLine(node.val);
Console.WriteLine(node.next.val);
Console.WriteLine(node.next.next.val);
Console.WriteLine(node.next.next.next.val);
Console.WriteLine(node.next.next.next.next.val);
class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        ListNode node = null;

        while (head != null)
        {
            node = new ListNode(head.val, node);
            head = head.next;
        }

        return node;
    }
}