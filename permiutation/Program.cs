IList<IList<int>> _result = new List<IList<int>>();

IList<IList<int>> Permute(int[] nums)
{
    Perform(nums, new List<int>());
    return _result;
}

void Perform(int[] nums, List<int> permutation)
{
    if (permutation.Count == nums.Length)
    {
        _result.Add(permutation.ToList());
        return;
    }

    foreach (var x in nums.Except(permutation))
    {
        permutation.Add(x);
        Perform(nums, permutation);
        permutation.RemoveAt(permutation.Count - 1);
    }
}
