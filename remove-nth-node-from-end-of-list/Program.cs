var node = new ListNode(1);
var node1 = new ListNode(2);
var node2 = new ListNode(3);
node.next = node1;
node1.next = node2;
/*
var node3 = new ListNode(4);
var node4 = new ListNode(5);
var node5 = new ListNode(6);
node2.next = node3;
node3.next = node4;
node4.next = node5;
*/
var data = ListNode.RemoveNthFromEnd(node, 3);
//Console.WriteLine(data.val);

Console.WriteLine(data.val);
Console.WriteLine(data.next.val);
Console.WriteLine(data.next.next.val);

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int size = 1;
        int p1 = 0;
        int target = 0;
        ListNode temp = head;
        while (temp.next != null)
        {
            size++;

            if (temp.next == null)
                break;
            temp = temp.next;
        }
        target = size - n + 1;


        if (size == 1)
        {
            temp = null;
        }
        else
        {
            if (size == n)
            {
                head = head.next;
                return head;
            }
            temp = head;

            while (head.next != null)
            {
                p1++;
                if (head.next == null)
                    break;

                if (p1 == target - 1)
                {
                    head.next = head.next.next;
                    break;

                }
                head = head.next;

            }
        }


        return temp;
    }
}