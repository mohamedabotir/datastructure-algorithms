
int[] data = { -7, -3, 2, 3, 11 };
foreach (var item in SortedSquares(data))
{
    Console.WriteLine(item);
}
int[] SortedSquares(int[] nums)
{
    int[] data = new int[nums.Length];
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = (int)Math.Pow((double)nums[i], 2);

    }
    return round(data);
}
int[] round(int[] nums)
{
    int min;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        min = i;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] > nums[j])
            {
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
            }
        }
    }
    return nums;
}