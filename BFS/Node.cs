using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bfs
{
    public class Node
    {
        public Node Next;
        public int Dest;
        public int Value;
        public Node(int dest, Node next, int value)
        {
            Next = next;
            Dest = dest;
            Value = value;
        }
    }
}