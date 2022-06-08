using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bfs
{
    public class Bfs
    {
        AdjList[] Data;
        int size;
        public Bfs(int length)
        {
            size = length;
            Data = new AdjList[length];
            for (int i = 0; i < length; i++)
            {
                Data[i] = new AdjList();
                Data[i].head = null;
            }
        }
        public void AddNode(int src, int value, int dest)
        {
            Node newNode = new Node(dest, null, value);
            newNode.Next = Data[src].head;
            Data[src].head = newNode;
        }
        public void explore(int start)
        {
            bool[] Visited = new bool[size];
            for (int i = 0; i < size; i++)
                Visited[i] = false;
            Queue<int> s = new Queue<int>();
            s.Enqueue(start);
            while (s.Any())
            {
                int n = s.Dequeue();

                Console.WriteLine("Node:" + n);
                Visited[n] = true;
                Node head = Data[n].head;
                while (head != null)
                {
                    if (Visited[head.Dest] == false)
                    {
                        s.Enqueue(head.Dest);
                        Visited[head.Dest] = true;
                    }
                    else
                    {
                        head = head.Next;
                    }
                }

            }
        }
    }
}