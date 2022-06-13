
int[] data = { 1, 3, 5, 6 };
Console.WriteLine(SearchInsert(data, 5));
static int SearchInsert(int[] nums, int target)
{
    int mid;
    int h = nums.Length - 1;
    int l = 0;
    while (h >= l)
    {
        mid = h + l / 2;
        if (nums[mid] == target)
        {
            return mid;

        }
        else if (nums[mid] > target)
            h = mid - 1;
        else if (nums[mid] < target)
        {
            l = mid + 1;
        }
    }
    return l;
}