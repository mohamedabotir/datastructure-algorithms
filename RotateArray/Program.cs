
int[] data = { -1, -100, 3, 99 };
Rotate(data, 2);
void Rotate(int[] nums, int k)
{
    while (k > 0)
    {
        for (int i = nums.Length - 1; i > 0; i--)
        {

            int temp = nums[nums.Length - 1];

            int temp1 = nums[i];
            nums[i] = nums[i - 1];
            nums[i - 1] = temp1;
        }

        k--;
    }
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