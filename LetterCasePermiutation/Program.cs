IList<string> LetterCasePermutation(string s)
{
    var rtn = new List<string>();
    var chars = s.ToCharArray();
    Generate(rtn, chars, 0);
    return rtn;
}

void Generate(List<string> set, char[] s, int index)
{
    set.Add(new string(s));
    for (int i = index; i < s.Length; i++)
    {
        if (Char.IsLetter(s[i]))
        {
            s[i] = Convert(s[i]);
            Generate(set, s, i + 1);
            //Restore
            s[i] = Convert(s[i]);
        }
    }
}

char Convert(char c)
{
    if (Char.IsLower(c))
    {
        return Char.ToUpper(c);
    }
    return Char.ToLower(c);
}