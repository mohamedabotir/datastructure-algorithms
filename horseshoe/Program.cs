internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");

        var items = new Dictionary<int, int>();
        items.Add(int.Parse(input[0]), 1);
        for (var i = 1; i < input.Length; i++)
        {
            var converter = int.Parse(input[i]);

            if (!items.ContainsKey(converter))
            {
                items.Add(converter, 1);
            }
        }
        Console.WriteLine(4 - items.Count());
    }
}