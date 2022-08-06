int PivotIndex(int[] nums)
{
    int sum = 0;
    int leftSum = 0;
    foreach (var num in nums)
        sum += num;
    for (int i = 0; i < nums.Length; i++)
    {
        if (leftSum == sum - leftSum - nums[i]) return i;
        leftSum += nums[i];
    }
    return -1;
}