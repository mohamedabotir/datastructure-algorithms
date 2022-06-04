using DFS;
DfsSearch dfs = new DfsSearch(6);
dfs.AddNode(0, 50, 2);
dfs.AddNode(0, 50, 1);
dfs.AddNode(1, 40, 4);
dfs.AddNode(1, 40, 3);
dfs.AddNode(1, 40, 0);
dfs.AddNode(3, 30, 1);
dfs.AddNode(4, 45, 1);
dfs.AddNode(2, 55, 5);
dfs.AddNode(2, 55, 0);
dfs.AddNode(5, 60, 2);

dfs.explore(0);
