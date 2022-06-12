// See https://aka.ms/new-console-template for more information
int[] data = { 5 };
Console.WriteLine(Search(data, 5));
static int Search(int[] nums, int target)
{
    int mid = 0;
    int h = nums.Length - 1;
    int l = 0;
    bool isFound = false;
    while (h >= l)
    {
        mid = h + l / 2;
        if (nums[mid] == target)
        {
            isFound = true;
            break;

        }
        else if (nums[mid] > target)
            h = mid - 1;
        else if (nums[mid] < target)
        {
            l = mid + 1;
        }
    }
    return isFound == true ? mid : -1;
}