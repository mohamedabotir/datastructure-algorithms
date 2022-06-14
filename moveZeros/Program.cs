int[] data = { 0, 1, 0, 3, 12 };
MoveZeroes(data);
void MoveZeroes(int[] nums)
{
    int i = 0;
    foreach (var item in nums)
    {
        if (item != 0)
        {
            nums[i] = item;
            i++;
            Console.WriteLine(i + " " + item);
        }
    }
    while (i < nums.Length)
    {
        nums[i++] = 0;
    }
}