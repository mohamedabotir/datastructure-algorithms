// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    class Edge{
       public int src,dest;
    }
    class graph{
        int vertix,edges;
       public Edge[]edge;
        public graph(int v,int e){
            vertix = v;
            edges = e;
            edge = new Edge[edges];
            for(int i = 0;i<edges;i++){
                edge[i] = new Edge();
            }
            
        }
        
        int find(int[]parent,int i){
            if(parent[i]==-1)
            return i;
            return find(parent,parent[i]);
        }
        void union(int[]parent,int i,int x){
            parent[i]=x;
        }
        
        public int isCycle(graph g){
            int[]parent = new int[g.vertix];
            for(int i=0;i<g.vertix;i++)
            parent[i]=-1;
            
            for(int i=0;i<g.edges;i++){
                int x = g.find(parent,g.edge[i].src);
                int y = g.find(parent,g.edge[i].dest);
                if(x==y)
                 return 1;
                
                g.union(parent,x,y);
            }
        
            return 0;
        }
    }
    public static void Main(string[] args)
    {
        graph g = new graph(3,2);
        g.edge[0].src = 0;
        g.edge[0].dest=1;
        
        g.edge[1].src=1;
        g.edge[1].dest=2;
        
        
        
    
        
        if(g.isCycle(g) == 1)
        Console.WriteLine("this graph is Cycle");
        if(g.isCycle(g)==0)
        Console.WriteLine("not cycle");

    }
}
