
int n = 0;
int m = 0;
int[] x_direction = { 1, 0, -1, 0 };
int[] y_direction = { 0, 1, 0, -1 };
int OrangesRotting(int[][] grid)
{
    int minuts = 0;
    Queue<int[]> rotten = new Queue<int[]>();
    int possibleRottenCount = 0;
    m = grid.Length;
    n = grid[0].Length;
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            if (grid[i][j] == 2)
            {
                rotten.Enqueue(new int[] { i, j });
            }
            if (grid[i][j] == 1)
                possibleRottenCount++;
        }
    }
    if (possibleRottenCount == 0)
    {
        return 0;
    }
    while (rotten.Count > 0)
    {
        int size = rotten.Count;
        while (size > 0)
        {
            size--;
            var temp = rotten.Dequeue();
            int p_x = temp[0]; int p_y = temp[1];
            for (var i = 0; i < 4; i++)
            {
                int toX = p_x + x_direction[i];
                int toY = p_y + y_direction[i];
                if (toX < 0 || toY < 0 || toX == m || toY == n)
                {
                    continue;
                }
                if (grid[toX][toY] == 1)
                {
                    possibleRottenCount--;
                    rotten.Enqueue(new int[] { toX, toY });
                    grid[toX][toY] = 2;
                }
            }
        }
        if (rotten.Count > 0)
            minuts++;

    }
    return possibleRottenCount == 0 ? minuts : -1;
}
