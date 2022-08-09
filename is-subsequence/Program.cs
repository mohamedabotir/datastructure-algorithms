Console.WriteLine(IsSubsequence("abc", "ahbgdc"));

bool IsSubsequence(string s, string t)
{
    int p1 = 0;
    string subSequence = "";
    for (int i = 0; i < t.Length; i++)
    {
        if (p1 == 3)
            break;
        if (s[p1] == t[i])
        {

            subSequence += s[p1];
            p1++;
        }
    }
    Console.WriteLine(subSequence);
    return subSequence == s ? true : false;
}