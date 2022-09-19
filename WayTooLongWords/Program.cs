var input = Console.ReadLine();
var lines = int.Parse(input);
var words = new string[lines];
for (var i = 0; i < lines; i++)
{
    words[i] = Console.ReadLine();
}

for (var i = 0; i < lines; i++)
{
    if (words[i].Length > 10)
        words[i] = words[i].ToCharArray()[0].ToString() + (words[i].Length - 2) + words[i].ToCharArray()[words[i].Length - 1];
}

foreach (var item in words)
{
    Console.WriteLine(item);
}