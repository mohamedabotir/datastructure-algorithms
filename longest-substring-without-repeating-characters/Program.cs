Console.WriteLine(LengthOfLongestSubstring("dvdf"));
int LengthOfLongestSubstring(string s)
{
    int max = 0;
    int p1 = 0;
    int p2 = 0;
    Dictionary<char, int> data = new Dictionary<char, int>();
    while (p1 < s.Length)
    {
        if (!data.ContainsKey(s[p1]))
        {
            data.Add(s[p1], p1);
            p1++;
            max = Math.Max(max, data.Count);
        }
        else
        {
            data.Remove(s[p2]);
            p2++;
        }
    }


    return max;
}
