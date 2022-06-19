int[][] FloodFill(int[][] image, int sr, int sc, int color)
{

    Queue<int[]> queue = new Queue<int[]>();
    HashSet<string> scannedPoints = new HashSet<string>();
    queue.Enqueue(new int[] { sr, sc });
    int colorToScan = image[sr][sc];
    while (queue.Count > 0)
    {
        var point = queue.Dequeue();
        if (point[0] >= image.Length || point[0] < 0) continue; // handle out of bounds
        if (point[1] >= image[point[0]].Length || point[1] < 0) continue; // handle out of bounds
        if (image[point[0]][point[1]] != colorToScan) continue; // does not match color


        var scanKey = $"{point[0]},{point[1]}";
        if (scannedPoints.Contains(scanKey)) continue; // already scanned

        scannedPoints.Add(scanKey);
        image[point[0]][point[1]] = color;
        queue.Enqueue(new int[] { point[0] - 1, point[1] }); // top point
        queue.Enqueue(new int[] { point[0], point[1] - 1 }); // same row, left point
        queue.Enqueue(new int[] { point[0], point[1] + 1 }); // same row, right point
        queue.Enqueue(new int[] { point[0] + 1, point[1] }); // bottom point
    }

    return image;
}

