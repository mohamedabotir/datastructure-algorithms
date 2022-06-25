

ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(4);

node1.next = node2;

node2.next = node3;
ListNode node4 = new ListNode(1);
ListNode node5 = new ListNode(3);
ListNode node6 = new ListNode(4);
node4.next = node5;
node5.next = node6;
var node = ListNode.MergeTwoLists(node1, node4);
while (node != null)
{
    Console.WriteLine(node.val);
    node = node.next;
}
class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;

    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }
        if (list1 == null && list2 != null)
        {
            return list2;
        }
        if (list1 != null && list2 == null)
        {
            return list1;
        }
        if (list1.val > list2.val)
        {
            ListNode temp = list1;
            list1 = list2;
            list2 = temp;
        }

        ListNode result = null;

        result = list1;

        while (list1 != null && list2 != null)
        {
            ListNode node = null;
            while (list1 != null && list1.val <= list2.val)
            {
                node = list1;
                list1 = list1.next;
            }
            node.next = list2;
            ListNode temp = list1;
            list1 = list2;
            list2 = temp;
        }
        return result;
    }
}