 Node root1 = new Node(1);
    root1.left = new Node(2);
    root1.right = new Node(3);
    root1.left.left = new Node(4);
    root1.left.right = new Node(5);
    root1.right.right = new Node(7);
    root1.right.left = new Node(6);
    var node = Node.Connect(root1);
 
List<Node> d= new List<Node>();
   /* Queue<Node> d = new Queue<Node>();
    d.Enqueue(node);
    while(d.Count>0){
        var temp = d.Dequeue();
        LinkedList<Node> nodes = new LinkedList<Node>();
        nodes.Append(temp);
        int count = d.Count;
        while(count>0){
         count--;
         if(temp.left!=null)
        d.Enqueue(temp.left);
         if(temp.right!=null)
            d.Enqueue(temp.right);

        
        }
        for (int i = 0; i < nodes.Count-1; i++)
        {
            Console.WriteLine(nodes.ElementAt(i).val+" "+nodes.ElementAt(i).next==null?"#":nodes.ElementAt(i+1).val);
        }
    }*/
    
internal class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;

    }
public static Node  Connect(Node root) {
         Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while(queue.Count>0){
            LinkedList<Node> list = new LinkedList<Node>();
            int count = queue.Count;
            while(count>0){
                count--;
                Node node = queue.Dequeue();
                list.AddLast(node);
                if(node == null)
                continue;
                if(node.left!=null)
                queue.Enqueue(node.left);
                if(node.right!=null)
                    queue.Enqueue(node.right);
                
                
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i).val);
               list.ElementAt(i).next = list.ElementAt(i+1);
            }

        }
         return root;
    }
}
