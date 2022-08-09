Dictionary<int, int> occurence1 = new Dictionary<int, int>();
Dictionary<int, int> occurence2 = new Dictionary<int, int>();
string char1 = "aa";
string char2 = "bb";
int p1 = 0;
int sum = 1;
for (var i = 1; i < char1.Length; i++)
{

    if (char1[i] == char1[p1] && char1.Length == 2)
    {
        occurence1[p1] = sum;
    }
    else if (char1[i] == char1[p1])
    {

        sum++;
    }
    else
    {
        occurence1[p1] = sum;
        sum = 1;
        p1 = i;
    }
    if (char1.Length - 1 == i)
    {
        if (char1[i] != char1[i - 1])
        {
            occurence1[p1] = 1;
        }
    }
}
sum = 1;
p1 = 0;
for (var i = 1; i < char2.Length; i++)
{

    if (char2[i] == char2[p1] && char2.Length == 2)
    {
        occurence2[p1] = sum;
    }
    else if (char2[i] == char2[p1])
    {
        sum++;
    }
    else
    {
        occurence2[p1] = sum;
        sum = 1;
        p1 = i;
    }
    if (char2.Length - 1 == i)
    {
        Console.WriteLine(i + " " + p1);
        if (char2[i] != char2[i - 1])
        {
            occurence2[p1] = 1;
        }
    }
}


foreach (var item in occurence1)
{
    Console.WriteLine(item);
}
Console.WriteLine("===========");
foreach (var item in occurence2)
{
    Console.WriteLine(item);
}


for (var i = 0; i < occurence1.Count; i++)
{
    if (occurence1.ElementAt(i).Key == occurence2.ElementAt(i).Key)
    {
        if (occurence1.ElementAt(i).Value != occurence1.ElementAt(i).Value)
        {
            Console.WriteLine(false);
        }
    }
}