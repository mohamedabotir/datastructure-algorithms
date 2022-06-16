string input = "Let's take LeetCode contest";
Console.Write(ReverseWords(input));
string ReverseWords(string s)
{
    var words = s.Split(' ');
    string temp;
    for (var i = 0; i < words.Length; i++)
    {
        temp = words[i];
        words[i] = "";
        foreach (var item in temp.Reverse())
        {
            words[i] += item;
        }
        if (i == words.Length - 1)
            break;
        words[i] += " ";
    }
    string output = "";
    foreach (var item in words)
    {
        output += item;
    }
    return output;
}
