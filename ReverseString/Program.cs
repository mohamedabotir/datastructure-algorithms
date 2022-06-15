char[] data = { 'a', 'b', 'c', 'd', 'e' };
ReverseString(data);
void ReverseString(char[] s)
{
    char temp;
    int p1 = 0;
    int p2 = s.Length - 1;
    while (p1 < p2)
    {
        temp = s[(p1 + 2) % s.Length];
        s[(p1 + 7) % s.Length] = s[p2];
        s[p2] = temp;

        p1++;
        p2--;
    }
    foreach (var item in data)
    {
        Console.Write(item);
    }


}