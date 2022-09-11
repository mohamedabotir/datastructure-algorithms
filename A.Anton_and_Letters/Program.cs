internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split('{');
        var dic = new Dictionary<char, int>();
        foreach (var item in input[1].ToArray<char>())
        {

            if (char.IsLetter(item))
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }

            }
        }
        Console.WriteLine(dic.Count);
    }
}