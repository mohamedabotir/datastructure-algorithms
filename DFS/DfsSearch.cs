using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFS
{
    public class DfsSearch
    {
        AdjList[] array;
        int size;
        public DfsSearch(int size)
        {
            this.size = size;
            array = new AdjList[this.size];
            for (var i = 0; i < this.size; i++)
            {
                array[i] = new AdjList();
                array[i].head = null;
            }
        }
        public void AddNode(int src, int value, int dest)
        {
            Node newNode = new Node(value, null, dest);
            newNode.Next = array[src].head;
            array[src].head = newNode;
        }
        public void explore(int start)
        {
            bool[] Visited = new bool[size];
            for (var i = 0; i < size; i++)
            {
                Visited[i] = false;
            }
            Stack<int> s = new Stack<int>();
            s.Push(start);
            while (s.Count > 0)
            {
                int n = s.Pop();
                s.Push(n);
                Visited[n] = true;
                Node head = array[n].head;
                bool isDone = true;
                while (head != null)
                {
                    if (Visited[head.dest] == false)
                    {
                        s.Push(head.dest);
                        Visited[head.dest] = true;
                        isDone = false;
                        break;
                    }
                    else
                    {
                        head = head.Next;
                    }
                }
                if (isDone)
                {
                    int output = s.Pop();
                    Console.WriteLine(output);
                }
            }

        }
    }
}