// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int max=0;
List<List<int>> list = new List<List<int>>();
int MaxAreaOfIsland(int[][] grid) {
        int result = recursive(0,0,grid);
        return result;
    }
int recursive(int x,int y, int[][]grid){
     int row = grid.Length;
     int col = grid[0].Length;
     if(x>col || x <0 ||y >row ||y<0){
        return max;
     }
     if(grid[x][y]!=1)
      return 0;
      max++;
     recursive(x-1,y,grid);//left
     recursive(x+1,y,grid);//right
     recursive(x,y+1,grid);//up
     recursive(x,y-1,grid);//down
    return max;
    }
