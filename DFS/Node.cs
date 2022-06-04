using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFS
{
    public class Node
    {
        public int value;
        public int dest;
        public Node Next;
        public Node(int value, Node Next, int dest)
        {
            this.value = value;
            this.Next = Next;
            this.dest = dest;
        }
    }
}