int m;
int n;
int max = 0;
bool isFound = false;
bool start = false;
int[][] UpdateMatrix(int[][] mat)
{
    m = mat.Length;
    n = mat[0].Length;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (mat[i][j] == 1)
            {

                start = true;
                recurse(i, j, mat);
                mat[i][j] = max;
                max = 0;
                isFound = false;
                start = false;
            }
        }
    }
    return mat;
}
void recurse(int x, int y, int[][] mat)
{
    if (x >= m || x < 0 || y >= n || y < 0)
    {
        return;
    }

    if (isFound)
        return;
    if (mat[x][y] == 0 && !isFound)
    {
        Console.WriteLine(mat[x][y]);
        max++;
        isFound = true;
        return;
    }
    else if (start)
    {
        max = 0;
        start = false;
    }
    else
    {
        max++;
    }
    recurse(x - 1, y, mat);
    recurse(x + 1, y, mat);
    recurse(x, y - 1, mat);
    recurse(x, y + 1, mat);



}