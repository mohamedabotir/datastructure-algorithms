
int[] data = { 1, 2, 3, 4, 5, 6, 7 };
Rotate(data, 3);
void Rotate(int[] nums, int k)
{
    int[] temp = new int[nums.Length];
    for (var i = 0; i < nums.Length; i++)
    {
        temp[(i + k) % nums.Length] = nums[i];
    }
    nums = temp;

    display(nums);
}
void display(int[] nums)
{
    Console.WriteLine();
    Console.Write('[');
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums.Length - 1 == i)
        {
            Console.Write(nums[i]);
        }
        else
            Console.Write(nums[i] + ",");
    }
    Console.Write(']');
    Console.WriteLine();
}