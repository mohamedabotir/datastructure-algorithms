// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<List<int>> list =  {{0,0,1,0,0,0,0,1,0,0,0,0,0},
                                {0,0,0,0,0,0,0,1,1,1,0,0,0},
                                {0,1,1,0,1,0,0,0,0,1,0,0,0},
                                {0,1,0,0,1,1,0,0,1,0,1,0,0},
                                {0,1,0,0,1,1,0,0,1,1,1,0,0},
                                {0,0,0,0,0,0,0,0,1,0,1,0,0},
                                {0,0,0,0,0,0,0,1,1,1,0,0,0},
                                {0,0,0,0,0,0,0,1,1,0,0,0,0}};
  int row;
int col;
 int MaxAreaOfIsland(int[][] grid) {
    int area=0;
      row = grid.Length;
      col = grid[0].Length;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                 if (grid[i][j] > 0)
                area = Math.Max(area,recursive(i,j,grid));
            }
        }
        return area;
    }
 int recursive(int x,int y, int[][]grid){
     if(x>=row || x <0 ||y >=col ||y<0 ){
        return 0;
     }
    if(grid[x][y] < 1)
        return 0;
    grid[x][y] = 0;
    return 1+ recursive(x-1,y,grid)//left
        +recursive(x,y-1,grid)//down
     +recursive(x+1,y,grid)//right
    + recursive(x,y+1,grid);//up
     
  
    }